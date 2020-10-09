using DreamSchool.BL.Integration;
using DreamSchool.BO.Integration;
using DreamSchool.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DreamSchool.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            return View();
        }


        #region Login Method
        [HttpPost]

        public async Task<IActionResult> Login(string username, string password)
        {
            try
            {
                // ViewBag.lstWebsiteMenu = CommonConfig.MenuModel(_objHelper, _objDataHelper);



                if (!ModelState.IsValid)
                {
                    return View("_Layout.cshtml");
                }

                var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;

                var objBO = new IntegrationBO()
                {
                    Username = username,
                    password = password,

                };

                DataTable dt = new IntegrationBL().Login(objBO);
                ResponseModel _Resp = new ResponseModel();
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(dt.Rows[0]["IsActive"]))
                    {
                        var claims = new List<Claim>
                    {
                        new Claim("userid", dt.Rows[0]["UserID"].ToString()),
                        new Claim("name", dt.Rows[0]["Name"].ToString()),
                        new Claim("username", dt.Rows[0]["Username"].ToString()),
                        new Claim("rolename", dt.Rows[0]["Role"].ToString()),
                        new Claim(ClaimTypes.Role, dt.Rows[0]["Role"].ToString())
                         };

                        var userIdentity = new ClaimsIdentity(claims, "Cookie");
                        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                        await
                        HttpContext.SignInAsync(
                        scheme: CookieAuthenticationDefaults.AuthenticationScheme,
                        principal: principal
                        );

                        if (Convert.ToString(dt.Rows[0]["Role"]).ToLower().Contains("admin"))
                        {
                            //return RedirectToAction("Index");

                            _Resp.response = 1;
                            _Resp.data = "Success";
                            return Json(_Resp);
                        }
                        else
                        {
                            return RedirectToAction("PersonalDetails", "Student");
                        }


                    }
                    else
                    {
                        ViewData["ErrorMessage"] = "User is disable. Please contact with Administration";
                    }
                }
                else
                {
                    ViewData["ErrorMessage"] = "Please check your login credentials";
                    _Resp.response = 0;
                    _Resp.data = "Please check your login credentials";
                    return Json(_Resp);
                }
                return View();


            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Please try again later.";
                return View();
            }
        }
        #endregion
    }
}