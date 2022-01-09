using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string> 
                { 
                    RoleId = "7e8ea000-b102-408a-8596-96b2684395ca", 
                    UserId = "dd910685-0f1c-426e-931d-f68fc8e95122"
                },// sys admin
                new IdentityUserRole<string>
                {
                    RoleId = "7e8ea000-b102-668a-8596-96b2686666ca",
                    UserId = "ee910685-0f1c-426e-931d-f68fc8e50125"
                }// first user
                );
        }
    }
}