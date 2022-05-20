using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HRLeaveManagementSystem.Application.DTOs.LeaveRequest;
using HRLeaveManagementSystem.Application.Features.LeaveType.Requests.Commands;
using HRLeaveManagementSystem.Application.Persistance.Contracts;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveType.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler :IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _repository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveTypeEntity = _mapper.Map<Domain.LeaveType>(request.LeaveTypeDto);
            var result=await _repository.Add(leaveTypeEntity);
            return result.Id;
        }
    }
}