using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PioneerTechSystem.DAL;
using PioneerTechSystem.Models;

namespace PioneerTechWebApp.MVC.Controllers
{
    public class EducationController : Controller
    {
        private EmployeeDataAccessLayer employeeDataAccessLayerObject = new EmployeeDataAccessLayer();

        // GET: Education/SaveData
        public ActionResult SaveData()
        {
            ViewBag.ReturnMessage = string.Empty;
            ViewBag.EmployeeID = new SelectList(employeeDataAccessLayerObject.GetEmployeeID(), "EmployeeID", "EmployeeID");
            return View();
        }

        // POST: Education/SaveData
        [HttpPost]
        public ActionResult SaveData(FormCollection collection)
        {
            try
            {
                Educational educationDetail = new Educational();
                UpdateModel(educationDetail);
                string returnValue = employeeDataAccessLayerObject.SaveEmployeeEducationDetails(educationDetail);

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
