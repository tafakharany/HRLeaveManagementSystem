using System.Collections.Generic;
using HRLeaveManagementSystem.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationListRequest:IRequest<List<LeaveAllocationDto>>
    {
        
    }
}