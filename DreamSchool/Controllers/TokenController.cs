using DreamSchool.BL.Enquiry;
using DreamSchool.BO.Enquiry;
using DreamSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace DreamSchool.Controllers
{
    public class TokenController : Controller
    {
        // GET: Token
        public ActionResult SearchInquiry(Int64 token = 0)
        {
            if(token == 0)
            {
                SearchEnquiryBO objSearchEnquiryBO = new SearchEnquiryBO()
                {
                    listEnquiry = new List<EnquiryBO>(),
                };
                return View(objSearchEnquiryBO);
            }
            else
            {
                List<EnquiryBO> listEnquiry = new List<EnquiryBO>();
                EnquiryBO objEnquiryBO = new EnquiryBL().GetEnquiryByToken(token.ToString());
                if(objEnquiryBO != null)
                {
                    listEnquiry.Add(objEnquiryBO);
                }
                SearchEnquiryBO objSearchEnquiryBO = new SearchEnquiryBO()
                {
                    listEnquiry = listEnquiry,
                    token = token
                };
                return View(objSearchEnquiryBO);
            }            
        }

        public ActionResult Inquiry()
        {
            EnquiryViewModel obj = new EnquiryViewModel();
            return View(obj);
        }

        [HttpPost]
        public ActionResult SaveEnquiry(EnquiryViewModel objEnquiryViewModel)
        {
            if (ModelState.IsValid)
            {
                var objEnquiryBO = new EnquiryBO()
                {
                    Id = objEnquiryViewModel.Id,
                    Name = objEnquiryViewModel.Name,
                    FatherName = objEnquiryViewModel.FatherName,
                    Address = objEnquiryViewModel.Address,
                    ClassType = objEnquiryViewModel.ClassTypeId.ToString(),
                    Email = objEnquiryViewModel.Email,
                    PhoneNumber = objEnquiryViewModel.PhoneNumber
                };
                int _result = new EnquiryBL().SaveEnquiry(objEnquiryBO);
                if (_result >= 1)
                {
                    return RedirectToAction("Index","CommonDashboard",null);
                }
                else
                {
                    return RedirectToAction("Inquiry", objEnquiryViewModel);
                }
            }
            else
            {
                return View("AddEnquiry", objEnquiryViewModel);
            }

        }
    }
}