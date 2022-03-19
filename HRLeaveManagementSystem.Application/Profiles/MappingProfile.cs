using AutoMapper;
using HRLeaveManagementSystem.Application.DTOs;
using HRLeaveManagementSystem.Application.DTOs.LeaveRequest;
using HRLeaveManagementSystem.Domain;

namespace HRLeaveManagementSystem.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
