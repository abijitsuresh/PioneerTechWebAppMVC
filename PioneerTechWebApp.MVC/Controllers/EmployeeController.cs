using PioneerTechSystem.DAL;
using PioneerTechSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PioneerTechWebApp.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
        // GET: Employee
        public ActionResult Index()
        {
            //Employee firstEmployee = new Employee()
            //{
            //    FirstName = "Abijit",
            //    LastName = "Suresh",
            //    EmailID = "abijit.suresh@outlook.com",
            //    MobileNumber = "832-551-4070"
            //};
            //Employee secondEmployee = new Employee()
            //{
            //    FirstName = "Amit",
            //    LastName = "Suresh",
            //    EmailID = "amit.suresh@outlook.com",
            //    MobileNumber = "832-551-4070"
            //};
            //List<Employee> employeeList = new List<Employee>() { 
            //    firstEmployee,
            //    secondEmployee
            //    };

            List<Employee> employeeList = employeeDataAccessLayer.ViewEmployeeData();

            return View(employeeList);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {

                Employee personalDetail = new Employee()
                {
                    FirstName = collection[1],
                    LastName = collection[2],
                    EmailID = collection[3],
                    MobileNumber = collection[4],
                    AlternateMobileNumber = collection[5],
                    AddressLine1 = collection[6],
                    AddressLine2 = collection[7],
                    AddressState = collection[8],
                    AddressCountry = collection[9],
                    AddressZipCode = collection[10],
                    HomeCountry = collection[11]
                };
                //Employee personalDetail = new Employee();
                //UpdateModel(personalDetail);
                employeeDataAccessLayer.SaveEmployeePersonalDetails(personalDetail);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Employee personalDetail = employeeDataAccessLayer.GetPersonalData(id.ToString());
            return View(personalDetail);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                //Employee employee = new Employee();
                Employee personalDetail = new Employee()
                {
                    EmployeeID = id,
                    FirstName = collection[2],
                    LastName = collection[3],
                    EmailID = collection[4],
                    MobileNumber = collection[5],
                    AlternateMobileNumber = collection[6],
                    AddressLine1 = collection[7],
                    AddressLine2 = collection[8],
                    AddressState = collection[9],
                    AddressCountry = collection[10],
                    AddressZipCode = collection[11],
                    HomeCountry = collection[12]
                };

                //UpdateModel(employee);
                employeeDataAccessLayer.SaveEmployeePersonalDetails(personalDetail);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
