using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HRLeaveManagementSystem.Application.DTOs;
using HRLeaveManagementSystem.Application.DTOs.LeaveRequest;
using HRLeaveManagementSystem.Application.Features.LeaveAllocation.Requests.Queries;
using HRLeaveManagementSystem.Application.Features.LeaveRequests.Requests.Queries;
using HRLeaveManagementSystem.Application.Persistance.Contracts;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestsListRequestHandler:IRequestHandler<GetLeaveRequestsListRequest, List<LeaveRequestDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestsListRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestsListRequest request, CancellationToken cancellationToken)
        {
            var result = await _leaveRequestRepository.GetAll();
            return _mapper.Map<List<LeaveRequestDto>>(result);
        }
    }
}