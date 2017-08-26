using PioneerTechSystem.DAL;
using PioneerTechSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PioneerTechWebApp.MVC.Controllers
{
    public class CompanyController : Controller
    {
        private EmployeeDataAccessLayer employeeDataAccessLayerObject = new EmployeeDataAccessLayer();

        // GET: Company/SaveData
        public ActionResult SaveData()
        {
            ViewBag.ReturnMessage = string.Empty;
            ViewBag.EmployeeID = new SelectList(employeeDataAccessLayerObject.GetEmployeeID(), "EmployeeID", "EmployeeID");
            return View();
        }

        // POST: Company/SaveData
        [HttpPost]
        public ActionResult SaveData(FormCollection collection)
        {
            try
            {
                Company companyDetail = new Company();
                UpdateModel(companyDetail);
                string returnValue = employeeDataAccessLayerObject.SaveEmployeeCompanyDetails(companyDetail);

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
