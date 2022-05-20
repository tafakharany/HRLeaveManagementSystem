using System.Collections;
using System.Collections.Generic;
using HRLeaveManagementSystem.Application.DTOs;
using HRLeaveManagementSystem.Application.DTOs.LeaveRequest;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestsListRequest:IRequest<List<LeaveRequestDto>>
    {
        
    }
}