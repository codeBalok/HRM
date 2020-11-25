using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Core.Interfaces.PaySlip;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyHRM.Web.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class PayRollController : Controller
    {
        private readonly IAllowanceTypeRepository allowanceTypeRepository;
        private readonly IAllowanceRepository allowanceRepository;
        private readonly IDepartmentRepository departmentRepository;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IAllowanceEmployee allowanceEmployee;
        private readonly IPaySlipRepository paySlipRepository;
        private readonly IEmployeePaySlipRepository employeePaySlipRepository;
        private readonly IPaySlipAllowanceRepository paySlipAllowanceRepository;

        // GET: /<controller>/
        public PayRollController(IAllowanceTypeRepository allowanceTypeRepository, IAllowanceRepository allowanceRepository,
            IDepartmentRepository departmentRepository, IEmployeeRepository employeeRepository, IAllowanceEmployee allowanceEmployee, IPaySlipRepository paySlipRepository,
            IEmployeePaySlipRepository employeePaySlipRepository, IPaySlipAllowanceRepository paySlipAllowanceRepository)
        {
            this.allowanceTypeRepository = allowanceTypeRepository;
            this.allowanceRepository = allowanceRepository;
            this.departmentRepository = departmentRepository;
            this.employeeRepository = employeeRepository;
            this.allowanceEmployee = allowanceEmployee;
            this.paySlipRepository = paySlipRepository;
            this.employeePaySlipRepository = employeePaySlipRepository;
            this.paySlipAllowanceRepository = paySlipAllowanceRepository;
        }

        #region Allowance Type List
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AllowanceTypeList()
        {
            return View(allowanceTypeRepository.All());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AllowanceTypeList(AllowanceTypeModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    allowanceTypeRepository.Update(model, model.Id);
                    return RedirectToAction("AllowanceTypeList");
                }
                if (allowanceTypeRepository.All().Any(x => x.AllowanceTypeName == model.AllowanceTypeName))
                {
                    ModelState.AddModelError("AllowanceTypeName", "Already Exists!");
                    return View(allowanceTypeRepository.All());
                }
                allowanceTypeRepository.Insert(model);
                return RedirectToAction("AllowanceTypeList");
            }
            return View(allowanceTypeRepository.All());
        }

        public IActionResult DeleteAllowanceType(int id)
        {
            var allowanceType = allowanceTypeRepository.Find(id);
            if (allowanceType != null)
            {
                allowanceTypeRepository.Delete(allowanceType);
                return RedirectToAction("AllowanceTypeList");
            }
            return RedirectToAction("AllowanceTypeList");
        }
        #endregion

        #region Allowance
        [HttpGet]
        public IActionResult AllowanceList(int id=0)

        {
            ViewBag.Depertments = allowanceTypeRepository.GetAllForDropDown();
            ViewBag.AllowanceList = allowanceRepository.All();
            if (id > 0)
            {
                var allowance = allowanceRepository.Find(id);
                return View(allowance);
            }
            return View(new AllowanceModel());       
        }
        [HttpPost]
        public IActionResult AllowanceList(AllowanceModel model)
        {
            ViewBag.Depertments = allowanceTypeRepository.GetAllForDropDown();
            ViewBag.AllowanceList = allowanceRepository.All();
            if (ModelState.IsValid)
            {   
                if (model.Id > 0)
                {
                    allowanceRepository.Update(model, model.Id);
                    //success updated
                    return RedirectToActionPermanent("AllowanceList", new {id=0});
                }
                if (allowanceRepository.All().Any(x => x.AllowanceType == model.AllowanceType))
                {
                    ModelState.AddModelError("AllowanceType", "Already Added into allowance List");
                    ViewBag.Depertments = allowanceTypeRepository.GetAllForDropDown();
                    ViewBag.AllowanceList = allowanceRepository.All();
                    return View(model);
                }
                allowanceRepository.Insert(model);
                return RedirectToAction("AllowanceList");
            }
            return View(model);
        }
        public IActionResult DeleteAllowance(int id)
        {
            var allowance = allowanceRepository.Find(id); 
            if (allowance != null)
            {
                allowanceRepository.Delete(allowance);
                //success
                return RedirectToAction("AllowanceList");
            }
            //failed not found
            return RedirectToAction("AllowanceList");
        }
        #endregion

        #region AllowanceEmployee
        [HttpGet]
        public IActionResult EmployeeWithAllowance()
        {
            ViewBag.Depertments = departmentRepository.GetAllDepertmentForDropDown();
            return View();
        }
        [HttpPost]
        public IActionResult SaveEmployeeAllowance(int empId, int[] ids)
        {

            if (empId != 0 && ids != null)
            {
                var allowancesForEmp = allowanceEmployee.All().Where(x => x.EmployeeId == empId).ToList();
                foreach (var item in allowancesForEmp)
                {
                    allowanceEmployee.Delete(item);
                }
                foreach (var id in ids)
                {
                    allowanceEmployee.Insert(new AllowanceEmployeeModel { EmployeeId = empId, AllowanceId = id });
                }
                //success
                return RedirectToAction("EmployeeWithAllowance");
            }
            return RedirectToAction("EmployeeWithAllowance");
        }

        [HttpGet]
        public JsonResult EmployeeByDeprt(int deptId)
        {
            return Json(employeeRepository.AllByDepartmentId(deptId));
        }
        [HttpGet]
        public JsonResult AllowanceListByEmployee(int deptId, int EmpId)
        {
            var allowances = allowanceRepository.All();
            var employeeWithAllowances = allowanceEmployee.All().Include(x=>x.Allowance).Where(x => x.EmployeeId == EmpId);
            foreach (var allowance in allowances)
            {
                foreach (var emp in employeeWithAllowances)
                {
                    if (emp.Allowance == allowance)
                        allowance.isCheck = true;
                }
            }
            return Json(allowances);
        }

        #endregion

        #region PaySlip


        [HttpGet]
        public IActionResult PaySlipList()
        {
            return View(paySlipRepository.All());
        }

        [HttpGet]
        public ActionResult CreatePaySlip()
        {
            ViewBag.Departments = departmentRepository.GetAllDepertmentForDropDown();
            return View();
        }
        [HttpPost]
        
        public ActionResult CreatePaySlip(PaySlipModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = departmentRepository.GetAllDepertmentForDropDown();
                return View(model);
            }
            model.Month = new DateTime(DateTime.Now.Year, Convert.ToInt16(model.Month), DateTime.Now.Day).ToString("MMMM", CultureInfo.InvariantCulture);
            var Employees = new List<EmployeeModel>();
            paySlipRepository.Insert(model);
            if (model.DepartmentId > 0)
                Employees  = employeeRepository.AllByDepartmentId(model.DepartmentId).ToList();
            else
                Employees = employeeRepository.All().ToList();

            if (Employees != null)
            {
                foreach (var item in Employees)
                {
                    EmployeePaySlipModel employeePaySlipModel = new EmployeePaySlipModel();
                    List<PaySlipAllowanceModel> paySlipAllowances = new List<PaySlipAllowanceModel>();
                    var allowances = allowanceEmployee.All().Include(x => x.Employee).Include(x => x.Allowance).Where(x => x.EmployeeId == item.Id).ToList();
                    double totalAllowances = 0;
                    double totalDeduction = 0;
                    double allowance = 0;
                    double deduction = 0;
                    double basicSalary  = item.BasicSalary;
                    double amount = 0;
                    foreach (var ad in allowances)
                    {
                        amount = ad.Allowance.IsValue? ad.Allowance.Value : ((ad.Allowance.Value / 100) * basicSalary);
                        if (ad.Allowance.Type == "Allowance")
                        {
                            allowance = amount;
                            totalAllowances += allowance; 
                        }
                        if (ad.Allowance.Type == "Deduction")
                        {
                            deduction = amount;
                            totalDeduction += deduction; 
                        }
                        paySlipAllowances.Add(new PaySlipAllowanceModel { AllowanceName = ad.Allowance.AllowanceType,
                            AllowanceType = ad.Allowance.Type, IsValue = ad.Allowance.IsValue, Value = ad.Allowance.Value, Amount = amount});
                    }

                    employeePaySlipModel.AllowanceTotal = totalAllowances;
                    employeePaySlipModel.BasicSalary = item.BasicSalary;
                    employeePaySlipModel.DeductionTotal = totalDeduction;
                    employeePaySlipModel.NetSalary = (item.BasicSalary + totalAllowances) - totalDeduction;
                    employeePaySlipModel.Status = "Paid";
                    employeePaySlipModel.EmployeeId = item.Id;
                    employeePaySlipModel.PaySlipId = model.Id;
                    employeePaySlipModel.PaySlipAllowances = paySlipAllowances;
                    employeePaySlipRepository.Insert(employeePaySlipModel);
                }
            }

            return RedirectToAction("PaySlipList");
        }

        public ActionResult PaySlipDetails(int id)
        {
            var details = employeePaySlipRepository.All().Include(x=>x.Employee).Where(x => x.PaySlipId == id).ToList();
            return View(details);
        }

        public ActionResult DeletePaySlip(int id)
        {
            var paySlip = paySlipRepository.Find(id);
            paySlipRepository.Delete(paySlip);

            var employeePaySlips = employeePaySlipRepository.All().Where(x => x.PaySlipId == paySlip.Id);
            foreach (var item in employeePaySlips)
            {
                employeePaySlipRepository.Delete(item);
            }
            return RedirectToAction("PaySlipList");
        }

        public ActionResult EmpPaySlipDetails(int id)
        {
            var employeePaySlip = employeePaySlipRepository.All().Include(x=>x.Employee).Include(x => x.PaySlip).FirstOrDefault(x=>x.Id == id);
            employeePaySlip.PaySlipAllowances = paySlipAllowanceRepository.All().Where(x => x.EmployeePaySlipId == employeePaySlip.Id).ToList();
            return View(employeePaySlip);
        }

        public ActionResult PrintPaySlip(int id)
        {

            var employeePaySlip = employeePaySlipRepository.All().Include(x => x.Employee).Include(x=>x.PaySlip).FirstOrDefault(x => x.Id == id);
            employeePaySlip.PaySlipAllowances = paySlipAllowanceRepository.All().Where(x => x.EmployeePaySlipId == employeePaySlip.Id).ToList();
            //return View(employeePaySlip);
            return new ViewAsPdf("PrintPaySlip", employeePaySlip)
            {
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait
            }  ;
            //{
            //    PageMargins = { Left = 0, Bottom = 20, Right = 0, Top = 20 },
            //};

        }
        #endregion
    }
}
