namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        // can prepend LeaveType to Id and EF knows its a primary,  or in this case "Id" by itself EF knows its a primary key

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
