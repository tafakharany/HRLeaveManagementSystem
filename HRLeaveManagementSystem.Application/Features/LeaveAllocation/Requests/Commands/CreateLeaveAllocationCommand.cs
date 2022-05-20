using System.Windows.Input;
using HRLeaveManagementSystem.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveAllocation.Requests.Commands
{
    public class CreateLeaveAllocationCommand:IRequest<int>
    {
        public LeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}