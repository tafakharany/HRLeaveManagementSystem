using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HRLeaveManagementSystem.Application.DTOs;
using HRLeaveManagementSystem.Application.Features.LeaveAllocation.Requests.Queries;
using HRLeaveManagementSystem.Application.Persistance.Contracts;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveAllocationDetailsRequestHandler:IRequestHandler<GetLeaveAllocationDetailsRequest, LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationDetailsRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailsRequest request, CancellationToken cancellationToken)
        {
            var result = await _leaveAllocationRepository.Get(request.Id);
            return _mapper.Map<LeaveAllocationDto>(result);
        }
    }
}