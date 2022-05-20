using HRLeaveManagementSystem.Application.DTOs.LeaveType;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypeRequest:IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
