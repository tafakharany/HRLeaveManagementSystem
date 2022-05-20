using MediatR;
using System.Collections.Generic;
using HRLeaveManagementSystem.Application.DTOs.LeaveType;

namespace HRLeaveManagementSystem.Application.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypeListRequest:IRequest<List<LeaveTypeDto>>
    {
    }
}
