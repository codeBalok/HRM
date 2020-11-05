using EasyHRM.Core.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Core.Interfaces
{
    public interface IDashboardRepository 
    {
        int totalEmplooyee();
        int totalDepartment();
        int TotalPresent();
        int totalAbsent();
        IEnumerable<NoticeModel> LastFiveNotifications();
        IEnumerable<HolidayModel> LastFiveHolidays();
    }
}
