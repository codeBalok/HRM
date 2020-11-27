using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Core.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EasyHRM.Web.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly IHolidayRepository holidayRepository;
        private readonly IAwardRepository awardRepository;
        private readonly IEmployeeRepository employeeRepository;
        private readonly INoticeRepository noticeRepository;
        private readonly IDashboardRepository dashboardRepository;
        private readonly ILeaveGroupRepository leaveGroupRepository;
        private readonly ILeaveEmployeeRepository leaveEmployeeRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly ILeaveApplicationRepository leaveApplicationRepository;
        private readonly IUserRepository userRepository;

        public AdminController(IHolidayRepository holidayRepository, IAwardRepository awardRepository, 
            IEmployeeRepository employeeRepository, INoticeRepository noticeRepository, 
            IDashboardRepository dashboardRepository, ILeaveGroupRepository leaveGroupRepository,
            ILeaveEmployeeRepository leaveEmployeeRepository, ILeaveTypeRepository leaveTypeRepository, 
            ILeaveApplicationRepository leaveApplicationRepository, IUserRepository userRepository)
        {
            this.holidayRepository = holidayRepository;
            this.awardRepository = awardRepository;
            this.employeeRepository = employeeRepository;
            this.noticeRepository = noticeRepository;
            this.dashboardRepository = dashboardRepository;
            this.leaveGroupRepository = leaveGroupRepository;
            this.leaveEmployeeRepository = leaveEmployeeRepository;
            this.leaveTypeRepository = leaveTypeRepository;
            this.leaveApplicationRepository = leaveApplicationRepository;
            this.userRepository = userRepository;
        }

        // admin dashboard

        //[Route("Admin/Index={EduDashManagerID}")]
        public IActionResult Index()
        {
            DashboardViewModel vm = new DashboardViewModel();
            vm.TotalEmployee = dashboardRepository.totalEmplooyee();
            vm.TotalDept = dashboardRepository.totalDepartment();
            vm.PresentCountToday = dashboardRepository.TotalPresent();
            vm.AbsenceCountToday = dashboardRepository.totalAbsent();
            vm.Notices = dashboardRepository.LastFiveNotifications().ToList();
            vm.Holidays = dashboardRepository.LastFiveHolidays().ToList();
            return View(vm);
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePasswordViewModel model)
        {
            var user = userRepository.All().FirstOrDefault(x => x.Id == CurrentUserId());
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


        #region holiday
        [HttpGet]
        public IActionResult Holidays()
        {
            DateTime dt = DateTime.Now;
            string currentMonth = dt.ToString("MMMM");
            return View(holidayRepository.All().Where(x=>x.Month == currentMonth));
        }
        [HttpPost]
        public JsonResult Holidays(string month)
        {
            var holidays = holidayRepository.All().Where(x => x.Month == month);
            return Json(holidays);
        }
        [HttpGet]
        public ActionResult AddHoliday()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddHoliday(HolidayModel model)
        {
            if (ModelState.IsValid)
            {
                model.Month = model.Date.ToString("MMMM");
                model.Day = model.Date.DayOfWeek.ToString();
                holidayRepository.Insert(model);
                return RedirectToAction("holidays");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditHoliday(int holidayId)
        {
            var holiday = holidayRepository.Find(holidayId); 
            if (holiday != null)
            {
                return View(holiday);
            }
            return RedirectToAction("Holidays");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditHoliday(HolidayModel model)
        {
            model.Month = model.Date.ToString("MMMM");
            model.Day = model.Date.DayOfWeek.ToString();
            var holiday = holidayRepository.Find(model.Id);
            if (ModelState.IsValid && holiday !=  null)
            {
                holiday.Date = model.Date;
                holiday.Day = model.Day;
                holiday.Month = model.Month;
                holidayRepository.Update(holiday, model.Id);
                return RedirectToAction("Holidays");
            }
            return RedirectToAction("Holidays");
        }
        public IActionResult DeleteHoliday(int id)
        {
            var holiday = holidayRepository.Find(id);
            if (holiday != null)
            {
                holidayRepository.Delete(holiday);
                return RedirectToAction("Holidays");
            }
            return RedirectToAction("Holidays");
        }

        #endregion

        #region award
        public ActionResult AwardList()
        {
            return View(awardRepository.All().Include(x=> x.EmployeeModel));
        }
        [HttpGet]
        public ActionResult AddAward()
        {
            ViewBag.Employees = employeeRepository.GetAllEmployeeForDropDown();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddAward(AwardModel model)
        {
            model.Month = model.Date.ToString("MMMM");
            if (!ModelState.IsValid)
            {
                ViewBag.Employees = employeeRepository.GetAllEmployeeForDropDown();
                return View(model);
            }
            awardRepository.Insert(model);
            return RedirectToAction("AwardList");
        }
        [HttpGet]
        public ActionResult EditAward(int id)
        {
            var award = awardRepository.Find(id);
            if (award != null)
            {
                ViewBag.Employees = employeeRepository.GetAllEmployeeForDropDown();
                return View(award);
            } 
            return RedirectToAction("AwardList");
        }
        public ActionResult EditAward(AwardModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Employees = employeeRepository.GetAllEmployeeForDropDown();
                return View(model);
            }
            var award = awardRepository.Find(model.Id);
            award.Gift = model.Gift;
            award.Price = model.Price;
            award.Date = model.Date;
            award.EmployeeId = model.EmployeeId;
            award.Month = model.Date.ToString("MMMM");
            awardRepository.Update(award, model.Id);
            return RedirectToAction("AwardList");
        }

        public ActionResult DeleteAward(int id)
        {
            var award = awardRepository.Find(id); 
            if (award != null)
            {
                awardRepository.Delete(award);
                return RedirectToAction("awardlist");
            }
            return RedirectToAction("awardlist");
        }
        #endregion

        #region notice
        [HttpGet]
        public IActionResult NoticeList()
        {
            return View(noticeRepository.All());
        }
        [HttpGet]
        public IActionResult AddNotice()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNotice(NoticeModel model)
        {
            if (!ModelState.IsValid) return View(model);
            noticeRepository.Insert(model);
            return RedirectToAction("NoticeList");
        }
        [HttpGet]
        public ActionResult EditNotice(int id)
        {
            var notice = noticeRepository.Find(id);
            if (notice != null)
            {
                return View(notice);
            }
            return RedirectToAction("NoticeList");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditNotice(NoticeModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            noticeRepository.Update(model, model.Id);
            return RedirectToAction("NoticeList");
        }

        public ActionResult DeleteNotice(int id)
        {
            var notice = noticeRepository.Find(id);
            if (notice != null)
            {
                noticeRepository.Delete(notice);
                return RedirectToAction("NoticeList");
            }
            return RedirectToAction("NoticeList");
        }

        #endregion

        #region Leave Type
        [HttpGet]
        public IActionResult LeaveTypeList()
        {
            return View(leaveTypeRepository.All());
        }
        [HttpPost]
        public IActionResult LeaveTypeList(LeaveTypeModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    leaveTypeRepository.Update(model, model.Id);
                    return RedirectToAction("LeaveTypeList");
                }
                if (leaveTypeRepository.All().Any(x => x.LeaveTypeName == model.LeaveTypeName))
                {
                    ModelState.AddModelError("LeaveTypeName", "Already Exists!");
                    return View(leaveTypeRepository.All());
                }
                leaveTypeRepository.Insert(model);
                return RedirectToAction("LeaveTypeList");
            }
            return View(leaveTypeRepository.All());
        }
        [HttpGet]
        public IActionResult DeleteLeaveType(int id)
        {
            var leaveType = leaveTypeRepository.Find(id);
            if (leaveType != null)
            {
                leaveTypeRepository.Delete(leaveType);
                //success
                return RedirectToAction("LeaveTypeList");
            }
            //failed
            return RedirectToAction("LeaveTypeList");
        }


        public IActionResult LeaveApplicationList()
        {
            return View(leaveApplicationRepository.All().Include(x=>x.EmployeeModel).Include(x=>x.LeaveType));
        }

        public IActionResult ChangeLeaveStatus(int id, string status)
        {
            var leaveApp = leaveApplicationRepository.Find(id);
            leaveApp.Status = status;
            leaveApplicationRepository.Update(leaveApp, leaveApp.Id);
            return RedirectToAction("LeaveApplicationList");
        }
        
        #endregion

        #region Leave Group
        [HttpGet]
        public IActionResult AddLeaveGroup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddLeaveGroup(LeaveGroupModel model)
        {
            if (!ModelState.IsValid) return View(model);
            leaveGroupRepository.Insert(model);
            //success message
            return RedirectToAction("LeaveGroupList");
        }
        public IActionResult LeaveGroupList()
        {
            return View(leaveGroupRepository.All());
        }
        [HttpGet]
        public IActionResult EditGroupLeave(int id)
        {
            var leaveGroup = leaveGroupRepository.Find(id);
            if (leaveGroup != null) return View(leaveGroup);
            return RedirectToAction("LeaveGroupList");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditGroupLeave(LeaveGroupModel model)
        {
            if (!ModelState.IsValid) return View(model);
            leaveGroupRepository.Update(model, model.Id);
            //success
            return RedirectToAction("LeaveGroupList");
        }

        public IActionResult DeleteLeaveGroup(int id)
        {
            var leaveGroup = leaveGroupRepository.Find(id); 
            if (leaveGroup != null)
            {
                leaveGroupRepository.Delete(leaveGroup);
                //success
                return RedirectToAction("LeaveGroupList");
            }
            //fail
            return RedirectToAction("LeaveGroupList");
        }

        #endregion

        #region leavegroupMapping

        public IActionResult LeaveGroupMappingList()
        {
           
            return View(leaveEmployeeRepository.All().Include(x=>x.Employee).Include(x=> x.LeaveGroup));
        }
        [HttpGet]
        public IActionResult AddLeaveGroupMapping()
        {
            ViewBag.Employees = employeeRepository.GetAllEmployeeExceptMappingForDropDown();
            ViewBag.LeaveGroups = leaveGroupRepository.GetAllLeaveGroupForDropDown();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddLeaveGroupMapping(LeaveEmployeeModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Employees = employeeRepository.GetAllEmployeeForDropDown();
                ViewBag.LeaveGroups = leaveGroupRepository.GetAllLeaveGroupForDropDown();
                return View(model);
            }
            leaveEmployeeRepository.Insert(model);
            return RedirectToAction("LeaveGroupMappingList");
           


        }

        [HttpGet]
        public IActionResult EditLeaveGroupEmployee(int id)
        {
            var leaveEmployeee = leaveEmployeeRepository.Find(id);
            if (leaveEmployeee != null)
            {
                ViewBag.Employees = employeeRepository.GetAllEmployeeForDropDown();
                ViewBag.LeaveGroups = leaveGroupRepository.GetAllLeaveGroupForDropDown();
                return View(leaveEmployeee);
            }
            return RedirectToAction("LeaveGroupMappingList");
        }
        [HttpPost]
        public IActionResult EditLeaveGroupEmployee(LeaveEmployeeModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Employees = employeeRepository.GetAllEmployeeForDropDown();
                ViewBag.LeaveGroups = leaveGroupRepository.GetAllLeaveGroupForDropDown();
                return View(model);
            }
            leaveEmployeeRepository.Update(model, model.Id);
            return RedirectToAction("LeaveGroupMappingList");
        }

        #endregion


        private int CurrentUserId()
        {
            var user = userRepository.All().SingleOrDefault(x => x.Email == User.Identity.Name);
            return user.Id;
        }
        private UserModel CurrentUser()
        {
            var user = userRepository.All().SingleOrDefault(x => x.Email == User.Identity.Name);
            return user;
          
        }
    }
}