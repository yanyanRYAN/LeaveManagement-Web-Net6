using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            // Id = guid;  just take existing guid in user table and change it
            builder.HasData(
                new IdentityRole
                {
                    Id = "7e8ea000-b102-408a-8596-96b2684395ca",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                }, new IdentityRole
                {
                    Id = "7e8ea000-b102-668a-8596-96b2686666ca",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                });
        }
    }
}