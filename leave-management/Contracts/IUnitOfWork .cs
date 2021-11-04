using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IUnitOfWork
    {
        public IGenericRepository<LeaveType> LeaveTypes { get; }
        IGenericRepository<LeaveRequests> LeaveRequests { get; }
        IGenericRepository<LeaveAllocation> LeaveAllocations { get; }
        Task Save();
    }
}
