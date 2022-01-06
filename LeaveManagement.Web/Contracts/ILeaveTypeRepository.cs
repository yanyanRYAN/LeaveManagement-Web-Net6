using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Contracts
{
    /*
     * So instead of inheriting <T> for IGenericRepository we inhearting <LeaveType>
     * so that that it is in the context of LeaveType
     */
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
    }
}
