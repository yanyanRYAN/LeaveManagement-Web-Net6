using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")] // can also use data annotation
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        //if you prepend the Type with Id, EF will know LeaveTypeId is a foreign key referencing LeaveType

        public string EmployeeId { get; set; }

        public int Period { get; set; }

    }
}
