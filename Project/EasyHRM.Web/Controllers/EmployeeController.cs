using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Core.Interfaces.PaySlip;
using EasyHRM.Core.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyHRM.Web.Controllers
{
    //[Authorize(Roles = "User")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeDashboard dashboardRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IAwardRepository awardRepository;
        private readonly ILeaveApplicationRepository leaveApplicationRepository;
        private readonly IUserRepository userRepository;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IEmployeePaySlipRepository employeePaySlipRepository;
        private readonly IPaySlipAllowanceRepository paySlipAllowanceRepository;
        private readonly IAttendenceRepository attendenceRepository;

        public EmployeeController(IEmployeeDashboard dashboardRepository, ILeaveTypeRepository leaveTypeRepository,
            IAwardRepository awardRepository, ILeaveApplicationRepository leaveApplicationRepository, IUserRepository userRepository,
            IEmployeeRepository employeeRepository, IEmployeePaySlipRepository employeePaySlipRepository, IPaySlipAllowanceRepository paySlipAllowanceRepository,
            IAttendenceRepository attendenceRepository)

        {
            this.dashboardRepository = dashboardRepository;
            this.leaveTypeRepository = leaveTypeRepository;
            this.awardRepository = awardRepository;
            this.leaveApplicationRepository = leaveApplicationRepository;
            this.userRepository = userRepository;
            this.employeeRepository = employeeRepository;
            this.employeePaySlipRepository = employeePaySlipRepository;
            this.paySlipAllowanceRepository = paySlipAllowanceRepository;
            this.attendenceRepository = attendenceRepository;
        }

        public IActionResult Index()
        {
            

            EmployeeViewModel empViewModel = new EmployeeViewModel();
            empViewModel.Notices = dashboardRepository.Notices().ToList();
            empViewModel.Holidays = dashboardRepository.Holidays().ToList();
            empViewModel.Employee = CurrentUser();
            empViewModel.RecentAwardList = dashboardRepository.RecentAwardList(CurrentUserId()).ToList();
            empViewModel.RecentPaySlipList = dashboardRepository.RecentPaySlipList(CurrentUserId()).ToList();
            empViewModel.TotalAbsenceInMonth = dashboardRepository.TotalAbsenceInMonth(CurrentUserId());
            empViewModel.TotalAttendencInMonth = dashboardRepository.TotalAttendencInMonth(CurrentUserId());
            empViewModel.TotalLeaveInMonth = dashboardRepository.TotalLeaveInMonth(CurrentUserId());
            return View(empViewModel);
        }
        [HttpGet]
        public ActionResult LeaveApplicationList()
        {
            int currentUserId = CurrentUserId();
            return View(leaveApplicationRepository.All().Include(c=>c.LeaveType).Where(x=>x.EmployeeId == currentUserId));
        }
        [HttpGet]
        public ActionResult LeaveApplication()
        {
            
            ViewBag.LeaveTypes = leaveTypeRepository.GetAllLeaveTypeForDropDown();
            return View();
        }
        [HttpPost]
        public ActionResult LeaveApplication(LeaveApplicationModel model)
        {
            model.EmployeeId =CurrentUserId();
            if (!ModelState.IsValid)
            {
                ViewBag.LeaveTypes = leaveTypeRepository.GetAllLeaveTypeForDropDown();
                return View(model);
            }
            leaveApplicationRepository.Insert(model);
            return RedirectToAction("LeaveApplicationList");
        }

        [HttpGet]
        public IActionResult EditLeaveApplication(int id)
        {
            var leaveApp = leaveApplicationRepository.Find(id);
            if (leaveApp != null &&  (leaveApp.Status == "Pending" || leaveApp.Status == "Reject")  && leaveApp.EmployeeId == CurrentUserId())
            {
                ViewBag.LeaveTypes = leaveTypeRepository.GetAllLeaveTypeForDropDown();
                return View(leaveApp);
            }
            return RedirectToAction("LeaveApplicationList");
        }
        [HttpPost]
        public IActionResult EditLeaveApplication(LeaveApplicationModel model)
        {
            var leaveApp = leaveApplicationRepository.Find(model.Id);
            if (ModelState.IsValid && leaveApp.EmployeeId == CurrentUserId())
            {
                leaveApp.LeaveDate = model.LeaveDate;
                leaveApp.LeaveTypeId = model.LeaveTypeId;
                leaveApp.Reason = model.Reason;
                leaveApp.Status = model.Status;
                leaveApplicationRepository.Update(leaveApp, model.Id);
                return RedirectToAction("LeaveApplicationList");
            }
            ViewBag.LeaveTypes = leaveTypeRepository.GetAllLeaveTypeForDropDown();
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteLeaveApplication(int id)
        {
            var leaveApp = leaveApplicationRepository.Find(id);
            if (leaveApp != null && (leaveApp.Status == "Pending" || leaveApp.Status == "Reject") && leaveApp.EmployeeId == CurrentUserId())
            {
                leaveApplicationRepository.Delete(leaveApp);
                return RedirectToAction("LeaveApplicationList");
            }
            return RedirectToAction("LeaveApplicationList");
        }

        public IActionResult Profile()
        {
            var employee = employeeRepository.All().Include(x=>x.DesignationModel).FirstOrDefault(x => x.Id == CurrentUserId());
            return View(employee);
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePasswordViewModel model)
        {
            var user = userRepository.All().FirstOrDefault(x => x.UserId == CurrentUserId());
            if (user != null && model.CurrentPass == user.Password)
            {
                user.Password = model.NewPass;
                userRepository.Update(user, user.Id);
                TempData["Msg"] = "Password changed successfully!";
                return View();
            }
            TempData["FMsg"] = "Current password doesn't match, Failed to changed password! ";
            return View(model);
        }

        public IActionResult AwardList()
        {
            return View(awardRepository.All().Where(x=>x.EmployeeId == CurrentUserId()));
        }
        [HttpGet]
        public IActionResult Attendence()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Attendence(EmployeeAttandenceViewModel model)
        {
            int days = DateTime.DaysInMonth(DateTime.Now.Year, model.Month);
            DateTime firstdayofmonth = new DateTime(DateTime.Now.Year, model.Month, 1);
            DateTime lastdayofmonth = new DateTime(DateTime.Now.Year, model.Month, 1).AddMonths(1).AddDays(-1);

            var attendences = attendenceRepository.All().Where(x => x.AttendenceDate >= firstdayofmonth && x.AttendenceDate <= lastdayofmonth
                                                        && x.EmployeeId == CurrentUserId()).OrderBy(x => x.AttendenceDate).ToList();


            AttendenceReportViewModel vm = new AttendenceReportViewModel();
            vm.Month = model.Month;

            for (int i = 1; i <= days; i++)
            {
                string currentDate = new DateTime(DateTime.Now.Year, model.Month, i).ToShortDateString();
                vm.AllCurrentMonthDate.Add(currentDate);
            }

            EmployeeStatustViewModel empStatusVm = new EmployeeStatustViewModel(days, model.Month);
            empStatusVm.EmployeeId = CurrentUser().Id;
            empStatusVm.EmployeeName = CurrentUser().Name;
            foreach (var attEmp in attendences)
            {
                string attndDate = attEmp.AttendenceDate.ToShortDateString();

                if (vm.AllCurrentMonthDate.Contains(attndDate))
                {
                    var statusR = empStatusVm.statustViewModel.FindIndex(x => x.Date.ToShortDateString() == attndDate);
                    empStatusVm.statustViewModel.RemoveAt(statusR);

                    var status = new StatustViewModel();
                    status.Date = attEmp.AttendenceDate;
                    if (attEmp.Status == "Present")
                    {
                        status.Status = "Present";
                    }

                    if (attEmp.Status == "Absense")
                    {
                        status.Status = "Absense";
                    }
                    empStatusVm.statustViewModel.Insert(statusR, status);
                }
                
            }
            vm.StatusViewModel.Add(empStatusVm);
            return View(vm);
        }

        public IActionResult PaySlipList()
        {
            return View(employeePaySlipRepository.All().Where(x=>x.EmployeeId == CurrentUserId()));
        }

        public ActionResult EmpPaySlipDetails(int id)
        {
            var employeePaySlip = employeePaySlipRepository.All().Include(x => x.Employee).Include(x => x.PaySlip).FirstOrDefault(x => x.Id == id && x.EmployeeId == CurrentUserId());
            employeePaySlip.PaySlipAllowances = paySlipAllowanceRepository.All().Where(x => x.EmployeePaySlipId == employeePaySlip.Id).ToList();
            return View(employeePaySlip);
        }
        public ActionResult PrintPaySlip(int id)
        {
            var employeePaySlip = employeePaySlipRepository.All().Include(x => x.Employee).Include(x => x.PaySlip).FirstOrDefault(x => x.Id == id);
            employeePaySlip.PaySlipAllowances = paySlipAllowanceRepository.All().Where(x => x.EmployeePaySlipId == employeePaySlip.Id).ToList();
            //return View(employeePaySlip);
            return new ViewAsPdf("PrintPaySlip", employeePaySlip)
            {
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait
            };
        }


        private int CurrentUserId()
        {
            var user = userRepository.All().SingleOrDefault(x => x.Email == User.Identity.Name);
            return employeeRepository.All().FirstOrDefault(x => x.Id == user.UserId).Id;
        }
        private EmployeeModel CurrentUser()
        {
            var user = userRepository.All().SingleOrDefault(x => x.Email == User.Identity.Name);
            return employeeRepository.All().FirstOrDefault(x => x.Id == user.UserId);
        }

    }
}
