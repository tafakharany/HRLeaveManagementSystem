using HRLeaveManagementSystem.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationDetailsRequest:IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}