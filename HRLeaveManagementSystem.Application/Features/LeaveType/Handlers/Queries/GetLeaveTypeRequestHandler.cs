using AutoMapper;
using HRLeaveManagementSystem.Application.DTOs;
using HRLeaveManagementSystem.Application.Features.LeaveType.Requests.Queries;
using HRLeaveManagementSystem.Application.Persistance.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HRLeaveManagementSystem.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeRequestHandler : IRequestHandler<GetLeaveTypeRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public GetLeaveTypeRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(id: request.Id);
            return  _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}