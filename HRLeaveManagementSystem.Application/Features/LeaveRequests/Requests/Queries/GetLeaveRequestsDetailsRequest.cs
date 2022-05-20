using HRLeaveManagementSystem.Application.DTOs.LeaveRequest;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestsDetailsRequest:IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}