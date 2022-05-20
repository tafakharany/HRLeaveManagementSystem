using HRLeaveManagementSystem.Application.DTOs.LeaveType;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveType.Requests.Commands
{
    public class CreateLeaveTypeCommand:IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}