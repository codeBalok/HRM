using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Data.HRMdbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyHRM.Data.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly AppDbContext _context;
        public DashboardRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<NoticeModel> LastFiveNotifications()
        {
            return _context.Notices.Take(5).OrderByDescending(x => x.CreateDate);
        }
        public IEnumerable<HolidayModel> LastFiveHolidays()
        {
            return _context.Holidays.Take(5).OrderByDescending(x => x.CreateDate);
        }

        public int totalAbsent()
        {
            //return _context.Attendences.Where(x => x.Status == "Absense" && x.AttendenceDate.ToShortDateString() == DateTime.Now.ToShortDateString()).ToList().Count();
            return 0;
        }

        public int totalDepartment()
        {
            return _context.Depertments.ToList().Count();
        }

        public int totalEmplooyee()
        {
           return _context.Employees.ToList().Count();
        }

        public int TotalPresent()
        {
            //return _context.Attendences.Where(x => x.Status == "Present" && x.AttendenceDate.ToShortDateString() == DateTime.Now.ToShortDateString()).ToList().Count();
            return 0;
        }
    }
}
