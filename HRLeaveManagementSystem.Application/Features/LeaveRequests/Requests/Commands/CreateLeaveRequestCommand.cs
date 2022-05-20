﻿using HRLeaveManagementSystem.Application.DTOs.LeaveRequest;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand:IRequest<int>
    {
        public  CreateLeaveRequestDto CreateLeaveRequestDto { get; set; }
    }
}