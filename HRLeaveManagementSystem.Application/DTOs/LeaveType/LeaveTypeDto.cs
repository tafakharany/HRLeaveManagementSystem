using HRLeaveManagementSystem.Application.DTOs.Common;

namespace HRLeaveManagementSystem.Application.DTOs.LeaveType
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
