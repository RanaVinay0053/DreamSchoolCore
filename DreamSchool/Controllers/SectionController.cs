using DreamSchool.BL.Class;
using DreamSchool.BO.Class;
using DreamSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace DreamSchool.Controllers
{
    public class SectionController : Controller
    {
        // GET: Section
        public ActionResult Index()
        {
            List<SectionBO> _listSectiones = new SectionBL().GetSections();
            return View(_listSectiones);
        }


        public ActionResult AddSection(string Id)
        {
            SectionViewModel obj;
            if (string.IsNullOrEmpty(Id))
            {
                obj = new SectionViewModel() {
                    BatchStartYear = DateTime.Now.Year
                };
            }
            else
            {
                SectionBO _objSection = new SectionBL().GetSectionById(Id);
                obj = new SectionViewModel()
                {
                    Id = _objSection.Id,
                    SectionName = _objSection.SectionName,
                    Class = Convert.ToInt32(_objSection.Class),
                    BatchStartYear = Convert.ToInt32(_objSection.BatchStartYear),
                    Description = _objSection.Description,
                    ClassTeacher = Convert.ToInt32(_objSection.ClassTeacher),
                    RoomName = _objSection.Description
                };
            }
            return View(obj);
        }

        [HttpPost]
        public ActionResult SaveSection(SectionViewModel objSectionViewModel)
        {
            if (ModelState.IsValid)
            {
                var objSectionBO = new SectionBO()
                {
                    Id = objSectionViewModel.Id,
                    SectionName = objSectionViewModel.SectionName,
                    Class = Convert.ToString(objSectionViewModel.Class),
                    BatchStartYear = Convert.ToString(objSectionViewModel.BatchStartYear),
                    Description = objSectionViewModel.Description,
                    ClassTeacher = Convert.ToString(objSectionViewModel.ClassTeacher),
                    RoomName = objSectionViewModel.Description
                };
                int _result = new SectionBL().SaveSection(objSectionBO);
                if (_result >= 1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("AddSection", objSectionViewModel);
                }
            }
            else
            {
                return View("AddSection", objSectionViewModel);
            }

        }
    }
}