using DreamSchool.BO.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;

namespace DreamSchool.Utility
{
    public class Helper
    {
        private string GetLocalizedCookieName(string cookieName)
        {
            string cookiePrefix = ConfigurationManager.AppSettings["LocalizedCookiePrefix"];
            if (cookiePrefix != null)
                cookieName = cookiePrefix + cookieName;

            return cookieName;
        }

        public void CreateCookie(string cookieName, string cookieValue)
        {
            cookieName = GetLocalizedCookieName(cookieName);

            HttpCookie cookie = new HttpCookie(cookieName);
            cookie.Value = cookieValue;
            cookie.Expires = DateTime.Now.AddDays(10);
            //cookie.Expires = DateTime.Now.AddDays(1);
            //HttpContext.Current.Response.Cookies.Add(new HttpCookie(cookieName, cookieValue));
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
        public string GetCookieValue(string nameContain)
        {
            nameContain = GetLocalizedCookieName(nameContain);

            HttpCookieCollection MyCookieColl;
            List<string> CookieNameColl = new List<string>();
            string requiredCookieName = Constants.MG_STR_EMPTYSTRING;
            string requiredCookieValue = Constants.MG_STR_EMPTYSTRING;

            MyCookieColl = HttpContext.Current.Request.Cookies;

            CookieNameColl = MyCookieColl.AllKeys.ToList().Distinct().ToList();

            requiredCookieName = Utility.GetNonNullParsedString(CookieNameColl.ToList().Where(CN => CN.Contains(nameContain)).FirstOrDefault());
            if (!Utility.IsEmptyString(requiredCookieName))
            {
                requiredCookieValue = HttpContext.Current.Request.Cookies[requiredCookieName].Value;
            }
            return requiredCookieValue;

        }
        //public string GetCookieName(string nameContain)
        //{
        //    nameContain = GetLocalizedCookieName(nameContain);

        //    HttpCookieCollection MyCookieColl;
        //    List<string> CookieNameColl = new List<string>();
        //    string requiredCookieName = Constants.MG_STR_EMPTYSTRING;

        //    MyCookieColl = HttpContext.Current.Request.Cookies;

        //    CookieNameColl = MyCookieColl.AllKeys.ToList().Distinct().ToList();

        //    requiredCookieName = Utility.GetNonNullParsedString(CookieNameColl.ToList().Where(CN => CN.Contains(nameContain)).FirstOrDefault());
        //    return requiredCookieName;

        //}
        //public void RemoveCookie(string nameContain)
        //{
        //    nameContain = GetLocalizedCookieName(nameContain);

        //    HttpCookieCollection MyCookieColl;
        //    List<string> CookieNameColl = new List<string>();
        //    string requiredCookieName = Constants.MG_STR_EMPTYSTRING;

        //    MyCookieColl = HttpContext.Current.Request.Cookies;

        //    CookieNameColl = MyCookieColl.AllKeys.ToList().Distinct().ToList();

        //    requiredCookieName = Utility.GetNonNullParsedString(CookieNameColl.ToList().Where(CN => CN.Contains(nameContain)).FirstOrDefault());
        //    if (!Utility.IsEmptyString(requiredCookieName))
        //    {
        //        HttpContext.Current.Request.Cookies.Remove(requiredCookieName);

        //    }
        //}


        public int GetUserID()
        {
            string secondCookie = string.Empty;
            int userID = 0;
            secondCookie = GetCookieValue(Constants.Cookies_SMS_ASPNET_SessionId);
            if (!Utility.IsEmptyString(secondCookie))
            {
                string[] otherItems = secondCookie.Split(Constants.MG_CHAR_PIPE);
                if (otherItems.Length > 0)
                {
                    userID = Utility.ToNonNullableInt32(otherItems[1]);
                }
            }
            return userID;
        }

        public string GetUserName()
        {
            string secondCookie = string.Empty;
            string userName = string.Empty;
            secondCookie = GetCookieValue(Constants.Cookies_SMS_ASPNET_SessionId);
            if (!Utility.IsEmptyString(secondCookie))
            {
                string[] otherItems = secondCookie.Split(Constants.MG_CHAR_PIPE);
                if (otherItems.Length > 0)
                {
                    userName = Convert.ToString(otherItems[0]);
                }
            }
            return userName;
        }
        public DataTable ToDataTable<T>(IList<T> data)// T is any generic type
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public DataSet ReadExcelAndFillDataSet()
        {
            OleDbConnection oledbConn = new OleDbConnection();
            try
            {
                string strFilePath = HttpContext.Current.Server.MapPath("Files/heatmapData.xls");
                string path = strFilePath;
                string name = "Sheet1";
                if (Path.GetExtension(path) == ".xls")
                {
                    oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
                }
                else if (Path.GetExtension(path) == ".xlsx")
                {
                    oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
                }

                oledbConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter oleda = new OleDbDataAdapter();
                DataSet ds = new DataSet();

                cmd.Connection = oledbConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [" + name + "$]";
                oleda = new OleDbDataAdapter(cmd);
                oleda.Fill(ds, "dsSlno");
                if (ds.Tables[0].Columns.Count > 0)
                {
                    for (int c = 0; c < ds.Tables[0].Columns.Count; c++)
                    {
                        ds.Tables[0].Columns[c].ColumnName = ds.Tables[0].Columns[c].ColumnName.Trim();
                        ds.AcceptChanges();
                    }
                }

                string valuesarr = string.Empty;
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    valuesarr = string.Empty;
                    List<object> lst = new List<object>(ds.Tables[0].Rows[i].ItemArray);
                    foreach (object s in lst)
                    {
                        valuesarr += s.ToString();
                    }
                    if (string.IsNullOrEmpty(valuesarr.Trim()))
                    {
                        ds.Tables[0].Rows[i].Delete();
                        //Remove row here, this row do not have any value 
                    }
                }
                ds.AcceptChanges();


                return ds;
            }
            catch (Exception ex)
            {

                return null;

            }
            finally
            {
                oledbConn.Close();
            }

        }
    }
}