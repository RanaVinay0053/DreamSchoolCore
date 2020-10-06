using DreamSchool.BL.Class;
using DreamSchool.BO.Class;
using DreamSchool.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DreamSchool.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult Index()
        {
            //ClassViewModel obj = new ClassViewModel();
            List<ClassBO> _listClasses = new ClassBL().GetClasses();
            return View(_listClasses);
        }

        public ActionResult AddClass(string Id)
        {
            ClassViewModel obj;
            if (string.IsNullOrEmpty(Id))
            {
                obj = new ClassViewModel();
            }
            else
            {
                ClassBO _objClass = new ClassBL().GetClassById(Id);
                obj = new ClassViewModel()
                {
                    Id = _objClass.Id,
                    ClassName = _objClass.ClassName,
                    ClassType = Convert.ToInt32(_objClass.ClassType),
                    NumericalValue = Convert.ToInt32(_objClass.NumericalValue),
                    Fees = _objClass.Fees
                };
            }
            return View(obj);
        }

        [HttpPost]
        public ActionResult SaveClass(ClassViewModel objClassViewModel)
        {
            if (ModelState.IsValid)
            {
                var objClassBO = new ClassBO()
                {
                    Id = objClassViewModel.Id,
                    ClassName = objClassViewModel.ClassName,
                    ClassType = objClassViewModel.ClassType.ToString(),
                    NumericalValue = objClassViewModel.NumericalValue.ToString(),
                    Fees = objClassViewModel.Fees
                };
                int _result = new ClassBL().SaveClass(objClassBO);
                if (_result >= 1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("AddClass", objClassViewModel);
                }
            }
            else
            {
                return View("AddClass", objClassViewModel);
            }

        }

    }
}