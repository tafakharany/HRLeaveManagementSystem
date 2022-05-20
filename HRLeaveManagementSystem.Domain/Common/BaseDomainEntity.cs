using System;

namespace HRLeaveManagementSystem.Domain.Common
{
    public abstract class BaseDomainEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LatModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

    }
}