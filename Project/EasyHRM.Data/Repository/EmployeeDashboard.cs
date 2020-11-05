using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Data.HRMdbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyHRM.Data.Repository
{
    public class EmployeeDashboard : IEmployeeDashboard
    {
        private int day;
        private int month;
        private DateTime startDate;
        private DateTime endDate;
        private readonly AppDbContext context;

        public EmployeeDashboard(AppDbContext context)
        {
            this.context = context;
          
            // current month days
            //day = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

        }
        public IEnumerable<HolidayModel> Holidays()
        {
            return context.Holidays.Take(5).OrderByDescending(x => x.CreateDate);
        }

        public IEnumerable<NoticeModel> Notices()
        {
            return context.Notices.Take(5).OrderByDescending(x => x.CreateDate);
        }
       
        public IEnumerable<AwardModel> RecentAwardList(int id)
        {
            return context.Awards.Take(5).
                OrderByDescending(x => x.CreateDate).Where(x =>x.EmployeeId == id).ToList();
        }

        public IEnumerable<EmployeePaySlipModel> RecentPaySlipList(int id)
        {
            return context.EmployeePaySlip.Take(5).
               OrderByDescending(x => x.CreateDate).Where(x => x.EmployeeId == id).ToList();
        }

      

        // need to modify
        public int TotalAbsenceInMonth(int id)
        {
            return context.Attendences.Where(x => x.Status == "Absense" && x.EmployeeId == id &&
            x.AttendenceDate >= startDate && x.AttendenceDate <= endDate).Count();
           
        }

       
        public int TotalAttendencInMonth(int id)
        {
            return context.Attendences.Where(x => x.Status == "Present" && x.EmployeeId == id &&
           x.AttendenceDate >= startDate && x.AttendenceDate <= endDate).Count();
        }

      
        public int TotalLeaveInMonth(int id)
        {
            return context.LeaveApplication.Where(x => x.Status == "Approve"
                                                    && x.EmployeeId == id && 
                                                    x.LeaveDate >= startDate && x.LeaveDate <= endDate).Count();
        }
    }
}
