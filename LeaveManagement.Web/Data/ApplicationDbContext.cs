using LeaveManagement.Web.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder) //on database generation, what should it do
        {
            base.OnModelCreating(builder);
            //set config for roles
            builder.ApplyConfiguration(new RoleSeedConfiguration());//create roles
            builder.ApplyConfiguration(new UserSeedConfiguration());//create user for the role
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<LeaveType> LeaveTypes { get; set; } //dbset -- "collection of" modeled off LeaveType pluralized
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        
        //when creating views using the view models the scaffolding operation will add a dbset. we remove them otherwise the ViewModel will be created as a table in the db
        
        
        
        
        
    }
}