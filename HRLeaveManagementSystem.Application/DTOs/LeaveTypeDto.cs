using HRLeaveManagementSystem.Application.DTOs.Common;

namespace HRLeaveManagementSystem.Application.DTOs
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
