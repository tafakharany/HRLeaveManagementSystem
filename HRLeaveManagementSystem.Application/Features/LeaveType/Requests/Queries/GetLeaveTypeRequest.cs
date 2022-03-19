using HRLeaveManagementSystem.Application.DTOs;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypeRequest:IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
