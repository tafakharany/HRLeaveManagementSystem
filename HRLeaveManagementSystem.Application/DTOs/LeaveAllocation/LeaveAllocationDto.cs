﻿using HRLeaveManagementSystem.Application.DTOs.Common;
using HRLeaveManagementSystem.Application.DTOs.LeaveType;

namespace HRLeaveManagementSystem.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
