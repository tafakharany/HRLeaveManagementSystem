using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HRLeaveManagementSystem.Application.Features.LeaveAllocation.Requests.Commands;
using HRLeaveManagementSystem.Application.Persistance.Contracts;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveAllocation.Handlers.Commands
{
    public class CreateLeaveAllocationCommandHandler:IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly ILeaveAllocationRepository _repository;
        private readonly IMapper _mapper;

        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocationEntity = _mapper.Map<Domain.LeaveAllocation>(request.LeaveAllocationDto);
            var result = await _repository.Add(leaveAllocationEntity);
            return result.Id;
        }
    }
}