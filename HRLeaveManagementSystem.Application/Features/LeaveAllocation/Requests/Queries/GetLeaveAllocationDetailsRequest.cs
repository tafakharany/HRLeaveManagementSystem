using HRLeaveManagementSystem.Application.DTOs;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationDetailsRequest:IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}