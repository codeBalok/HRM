using EasyHRM.Core.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Core.Interfaces
{
    public interface IEmployeeDashboard
    {
        int TotalAttendencInMonth(int id);
        int TotalAbsenceInMonth(int id);
        int TotalLeaveInMonth(int id);

        IEnumerable<NoticeModel> Notices();
        IEnumerable<HolidayModel> Holidays();
        IEnumerable<EmployeePaySlipModel> RecentPaySlipList(int id);
        IEnumerable<AwardModel> RecentAwardList(int id);
    }
}
