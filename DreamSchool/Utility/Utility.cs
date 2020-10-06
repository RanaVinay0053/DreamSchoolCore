using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace DreamSchool.Utility
{
    public static class Utility
    {
        /// <summary>
        /// To the nullable int32.
        /// </summary>
        /// <param name="s">This String</param>
        /// <returns>System.Nullable{System.Int32}.</returns>
        public static int? ToNullableInt32(this string s)
        {
            int i;
            if (Int32.TryParse(s, out i)) return i;
            return null;
        }

        public static int ToNonNullableInt32(this string s)
        {
            int i;
            if (Int32.TryParse(s, out i)) return i;
            return 0;
        }

        public static bool? ToNullableBool(this string s)
        {
            bool value;
            if (bool.TryParse(s, out value)) return value;
            return null;
        }

        public static bool IsValidEmail(this string emailString)
        {
            bool isEmail = Regex.IsMatch(emailString.ToLower().Trim(), @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            return isEmail;
        }


        public static bool GetDDMMYYYDate(object arg)
        {
            DateTime dt;
            bool valid = DateTime.TryParseExact(arg.ToString().Trim(), "dd/MM/yyyy hh:mm:ss tt", null, DateTimeStyles.None, out dt);
            return valid;
        }
        public static DateTime GetDDMMYYYDateTime(object arg)
        {
            DateTime dt = DateTime.ParseExact(arg.ToString().Trim(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

            // dt = DateTime.ParseExact(arg.ToString(), "dd/MM/yyyy hh:mm:ss tt", null, DateTimeStyles.None, out dt);
            return dt;
        }


        public static string base64Encode(string sData)
        {
            try
            {
                byte[] encData_byte = new byte[sData.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(sData);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string base64Decode(string sData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(sData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        public static bool IsEmptyDataset(DataSet metaDataDataSet)
        {
            if (metaDataDataSet.Tables.Count < 1)
                return true;
            if (metaDataDataSet.Tables[0].Rows.Count < 1)
                return true;

            return false;
        }
        public static bool IsEmptyString(object arg)
        {
            if (string.IsNullOrEmpty(arg + ""))
                return true;
            else
                return false;
        }
        public static bool IsEmptyOrWhiteSpaceString(object arg)
        {
            if (string.IsNullOrWhiteSpace(arg + ""))
                return true;
            else
                return false;
        }
        public static string GetNonNullString(object arg)
        {
            if (string.IsNullOrEmpty(arg + ""))
                return "";
            else
                return arg.ToString().Trim();
        }
        public static string GetNonNullParsedString(object arg)
        {
            if (string.IsNullOrEmpty(arg + ""))
                return "";
            else
                return ParseSpeacialChars(arg.ToString().Trim());
        }

        public static string ParseSpeacialChars(string rawData)
        {


            if (!string.IsNullOrEmpty(rawData))
            {
                return System.Security.SecurityElement.Escape(rawData);
            }
            else
                return rawData;
        }

        public static bool CheckMultipleCharacters(string str, char c)
        {
            int counter = 0;

            if (c == '.')  //subDomain check
            {
                str = str.Substring(str.IndexOf("@"), str.Length - str.IndexOf("@"));
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (c.ToString().ToLower() == str[i].ToString().ToLower())
                {
                    counter++;
                }
            }
            if (counter <= 1) { return false; }
            else return true;
        }

        public static bool GetBoolValue(this string input)
        {
            bool op = false;
            try
            {
                if (input.Trim() == "1" || input.ToLower().Trim() == "true")
                    op = true;
            }
            catch
            {
                op = false;
            }
            return op;
        }

        public static bool In<T>(this T obj, IEnumerable<T> values)
        {
            return values.Contains(obj);
        }

        public static bool In<T>(this T[] obj, IEnumerable<T> values)
        {
            return values.All(val => val.In<T>(obj));
        }

        public static string TrimString(string str)
        {
            if (str.Length > 0)
            {
                str = str.TrimStart(',').TrimEnd(',');
            }
            return str;
        }

        public static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                //aesAlg.Mode = CipherMode.CBC;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream.
            return encrypted;

        }

        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.

            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;
                    //aesAlg.Mode = CipherMode.OFB;
                    aesAlg.Mode = CipherMode.ECB;
                    aesAlg.Padding = PaddingMode.PKCS7;
                    // Create a decrytor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    // Create the streams used for decryption.
                    using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {

                                // Read the decrypted bytes from the decrypting stream 
                                // and place them in a string.
                                plaintext = srDecrypt.ReadToEnd();

                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                plaintext = string.Empty;
            }

            return plaintext;

        }

        public static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static string GetString(object arg)
        {
            if (!string.IsNullOrEmpty(arg + ""))
                return arg.ToString().Trim();
            else
                return null;
        }

        public static Guid? GetGuid(object arg)
        {
            if (arg == null)
                return null;

            return (System.Guid)System.Data.SqlTypes.SqlGuid.Parse(arg.ToString());
        }

        public static int GetInteger(object stringToParse)
        {
            int output;
            if (int.TryParse(stringToParse.ToString(), out output))
                return output;
            else
                return 0;
        }

        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        public static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        if (column.ColumnName == "Emp_Nationality_V")
                        {
                            pro.SetValue(obj, Convert.ToString(dr[column.ColumnName]), null);
                        }
                        else if (column.ColumnName == "EmployeeUniqueID")
                        {
                            pro.SetValue(obj, Convert.ToInt32(dr[column.ColumnName]), null);
                        }
                        else
                        {
                            pro.SetValue(obj, dr[column.ColumnName], null);
                        }
                    }
                    else
                        continue;
                }
            }
            return obj;
        }

        public static List<T> ConvertDataTableToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItemForList<T>(row);
                data.Add(item);
            }
            return data;
        }

        public static T GetItemForList<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {

                        pro.SetValue(obj, Convert.ToString(dr[column.ColumnName]), null);

                    }
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}