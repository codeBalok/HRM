using EasyHRM.Core.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EasyHRM.Core.ViewModel
{
    public class DashboardViewModel
    {
        public DashboardViewModel()
        {
            Notices = new Collection<NoticeModel>();
            Holidays = new Collection<HolidayModel>();
        }
        public int TotalEmployee { get; set; }
        public int TotalDept { get; set; }
        public int PresentCountToday { get; set; }
        public int AbsenceCountToday { get; set; }

        public ICollection<NoticeModel> Notices { get; set; }
        public ICollection<HolidayModel> Holidays { get; set; }

    }
}
