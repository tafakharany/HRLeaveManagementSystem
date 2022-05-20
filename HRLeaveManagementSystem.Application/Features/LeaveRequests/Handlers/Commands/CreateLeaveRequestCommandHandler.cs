using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HRLeaveManagementSystem.Application.Features.LeaveRequests.Requests.Commands;
using HRLeaveManagementSystem.Application.Persistance.Contracts;
using MediatR;

namespace HRLeaveManagementSystem.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler:IRequestHandler<CreateLeaveRequestCommand, int>
    {
        private readonly ILeaveRequestRepository _repository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequestEntity = _mapper.Map<Domain.LeaveRequest>(request.CreateLeaveRequestDto);
            var result = await _repository.Add(leaveRequestEntity);
            return result.Id;
        }
    }
}