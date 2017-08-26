using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PioneerTechSystem.DAL;
using PioneerTechSystem.Models;

namespace PioneerTechWebApp.MVC.Controllers
{
    public class TechnicalController : Controller
    {
        private EmployeeDataAccessLayer employeeDataAccessLayerObject = new EmployeeDataAccessLayer();

        // GET: Technical/SaveData
        public ActionResult SaveData()
        {
            ViewBag.ReturnMessage = string.Empty;
            ViewBag.EmployeeID = new SelectList(employeeDataAccessLayerObject.GetEmployeeID(), "EmployeeID", "EmployeeID");
            return View();
        }

        // POST: Technical/SaveData
        [HttpPost]
        public ActionResult SaveData(FormCollection collection)
        {
            try
            {
                Technical technicalDetail = new Technical();
                UpdateModel(technicalDetail);
                string returnValue = employeeDataAccessLayerObject.SaveEmployeeTechnicalDetails(technicalDetail);

                if (Convert.ToInt32(returnValue) > 0)
                {
                    ViewBag.ReturnMessage = "Saved/Updated successfully!!";
                }
                else
                    ViewBag.ReturnMessage = "Error Occured!!: " + returnValue;
                ViewBag.EmployeeID = new SelectList(employeeDataAccessLayerObject.GetEmployeeID(), "EmployeeID", "EmployeeID");
                return View();
            }
            catch
            {
                return View();
            }
        }        
    }
}
