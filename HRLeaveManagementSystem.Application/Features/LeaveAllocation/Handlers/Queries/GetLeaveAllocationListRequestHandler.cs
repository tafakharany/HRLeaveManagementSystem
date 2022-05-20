using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HRLeaveManagementSystem.Application.DTOs.LeaveAllocation;
using HRLeaveManagementSystem.Application.Features.LeaveAllocation.Requests.Queries;
using HRLeaveManagementSystem.Application.Persistance.Contracts;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveAllocationListRequestHandler:IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var result = await _leaveAllocationRepository.GetAll();
            return _mapper.Map<List<LeaveAllocationDto>>(result);
        }
    }
}