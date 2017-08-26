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
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();

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

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                
                //Employee employee = new Employee() {
                //    FirstName = collection[1],
                //    LastName = collection[2],
                //    EmailID = collection[3],
                //    MobileNumber = collection[4],
                //    AlternateMobileNumber = collection[5],
                //    AddressLine1 = collection[6],
                //    AddressLine2 = collection[7],
                //    AddressState = collection[8],
                //    AddressCountry = collection[9],
                //    AddressZipCode = collection[10],
                //    HomeCountry = collection[11]
                //};
                Employee employee = new Employee();
                UpdateModel(employee);
                EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
                employeeDataAccessLayer.SaveEmployeePersonalDetails(employee);

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
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            Employee employee = employeeDataAccessLayer.GetPersonalData(id.ToString());
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
                //Employee employee = new Employee();
                Employee employee = new Employee()
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
                employeeDataAccessLayer.SaveEmployeePersonalDetails(employee);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
