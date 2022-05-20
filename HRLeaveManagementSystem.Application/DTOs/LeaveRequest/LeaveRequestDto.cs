using HRLeaveManagementSystem.Application.DTOs.Common;
using System;
using HRLeaveManagementSystem.Application.DTOs.LeaveType;

namespace HRLeaveManagementSystem.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto : BaseDto
    {
        public LeaveRequestDto(string requestComments)
        {
            RequestComments = requestComments;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTimeOffset DateRequested { get; set; }
        public string RequestComments { get; set; }
        public LeaveTypeDto? LeaveType { get; set; }
        public DateTimeOffset? DatedActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
