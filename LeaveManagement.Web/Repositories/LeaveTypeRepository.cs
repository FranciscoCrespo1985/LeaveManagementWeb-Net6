using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeReposity
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
