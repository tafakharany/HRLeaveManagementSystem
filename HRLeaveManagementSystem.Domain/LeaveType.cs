using HRLeaveManagementSystem.Domain.Common;

namespace HRLeaveManagementSystem.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}