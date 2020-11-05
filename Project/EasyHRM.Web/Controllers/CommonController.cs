using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyHRM.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CommonController : Controller
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IDesignationRepository designationRepository;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IUserRepository userRepository;

        public CommonController(IDepartmentRepository departmentRepository, IDesignationRepository designationRepository,
            IEmployeeRepository employeeRepository, IUserRepository userRepository)
        {
            this.departmentRepository = departmentRepository;
            this.designationRepository = designationRepository;
            this.employeeRepository = employeeRepository;
            this.userRepository = userRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        #region Department

        [HttpGet]
        public IActionResult DepartmentList()
        {
            return View(departmentRepository.All());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DepartmentList(DepartmentModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    departmentRepository.Update(model, model.Id);
                    return RedirectToAction("DepartmentList");
                }
                departmentRepository.Insert(model);
                return RedirectToAction("DepartmentList");
            }
            return View(departmentRepository.All());
        }

        public ActionResult DeleteDeparment(int id)
        {
            var dept = departmentRepository.Find(id);
            if (dept != null)
            {
                departmentRepository.Delete(dept);
                return RedirectToAction("DepartmentList");
            }
            return RedirectToAction("DepartmentList");
        }
        [HttpPost]
        public JsonResult DeptExists(string Name, int id)
        {
           return Json(!departmentRepository.AlreadyExist(Name, id));
        }
        [HttpPost]
        public JsonResult DesgExists(string Name, int id)
        {
            return Json(!designationRepository.AlreadyExist(Name, id));
        }
        #endregion

        #region Designation
        [HttpGet]
        public ActionResult AddDesignation()
        {
            ViewBag.Depertments = departmentRepository.GetAllDepertmentForDropDown();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDesignation(DesignationModel model)
        {
            if (!ModelState.IsValid) return View(model);
            designationRepository.Insert(model);
            return RedirectToAction("DesignationList");
        }
        public IActionResult DesignationList()
        {
            return View(departmentRepository.All().Include(x=>x.Designations));
        }
        [HttpGet]
        public ActionResult EditDesignation(int designationId)
        {
            var designation = designationRepository.Find(designationId);
            if (designation != null)
            {
                ViewBag.Depertments = departmentRepository.GetAllDepertmentForDropDown();
                return View(designation);
            }
               
            return RedirectToAction("DesignationList");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDesignation(DesignationModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Depertments = departmentRepository.GetAllDepertmentForDropDown();
                return View(model);
            }
            designationRepository.Update(model, model.Id);
            return RedirectToAction("DesignationList");
        }

        public ActionResult DeleteDesignation(int id)
        {
            var designation = designationRepository.Find(id);
            if (designation != null)
            {
                designationRepository.Delete(designation);
                return RedirectToAction("DesignationList");
            }
            return RedirectToAction("DesignationList");
        }

        #endregion

        #region Employee 

        public ActionResult EmployeeList()
        {
            return View(employeeRepository.All().Include(x => x.DesignationModel).Include(x => x.DepertmentModel));
        }
        [HttpGet]
        public ActionResult EditEmployee(int id)
        {
            var employee = employeeRepository.Find(id);
            ViewBag.Department = departmentRepository.GetAllDepertmentForDropDown();
            ViewBag.Designation = designationRepository.GetAllDesignationForDropDown();
            return View(employee);
        }

        public ActionResult EditEmployee(EmployeeModel model, IFormFile logoPostedFileBase)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Department = departmentRepository.GetAllDepertmentForDropDown();
                ViewBag.Designation = designationRepository.GetAllDesignationForDropDown();
                return View(model);
            }
            var employee = employeeRepository.Find(model.Id);
            if (logoPostedFileBase != null && logoPostedFileBase.Length > 0)
            {
                var path = Path.Combine(
                 Directory.GetCurrentDirectory(), "wwwroot/Images",
                 logoPostedFileBase.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    logoPostedFileBase.CopyTo(stream);
                }
                model.ImagePath = $"/Images/{logoPostedFileBase.FileName}";
            }else
            {
                model.ImagePath = employee.ImagePath;
            }
            employee.ImagePath = model.ImagePath;
            employee.Name = model.Name;
            employee.Mobile = model.Mobile;
            employee.JoiningDate = model.JoiningDate;
            employee.PermanentAddress = model.PermanentAddress;
            employee.PresentAddress = model.PresentAddress;
            employee.Gender = model.Gender;
            employee.Email = model.Email;
            employee.DegisnationId = model.DegisnationId;
            employee.DepertmentId = model.DepertmentId;

            employee.BasicSalary = model.BasicSalary;
            employee.ResignDate = model.ResignDate;

            employee.AccountName = model.AccountName;
            employee.AccountNumber = model.AccountNumber;
            employee.Branch = model.Branch; 


            employeeRepository.Update(employee, employee.Id);
            return RedirectToAction("EmployeeList");
        }

        public IActionResult DeleteEmployee(int id)
        {
            var emp = employeeRepository.Find(id);
            if (emp != null)
            {
                employeeRepository.Delete(emp);
                var user = userRepository.All().FirstOrDefault(x => x.UserId == emp.Id);
                userRepository.Delete(user);
                return RedirectToAction("EmployeeList");
            }
            return RedirectToAction("EmployeeList");
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            ViewBag.Department = departmentRepository.GetAllDepertmentForDropDown();
            ViewBag.Designation = designationRepository.GetAllDesignationForDropDown();
            return View(new EmployeeModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddEmployee(EmployeeModel model, IFormFile logoPostedFileBase)
        {

            if (!ModelState.IsValid) return View(model);
            if (logoPostedFileBase != null && logoPostedFileBase.Length > 0)
            {
                var path = Path.Combine(
                 Directory.GetCurrentDirectory(), "wwwroot/Images",
                 logoPostedFileBase.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    logoPostedFileBase.CopyTo(stream);
                }
                model.ImagePath = $"/Images/{logoPostedFileBase.FileName}";
            }
            employeeRepository.Insert(model);
            userRepository.Insert(new UserModel { Email = model.Email, Password = "12345", Role = "User", UserId=model.Id });
            ViewBag.Msg = "Employee & User created successfully, Please change the default password after first login!";
            return RedirectToAction("EmployeeList");
        }

        public JsonResult DesignationByDepartment(int departmentId)
        {
            return Json(designationRepository.AllDesignationByDepartmentId(departmentId));
        }
        #endregion
    }
}
