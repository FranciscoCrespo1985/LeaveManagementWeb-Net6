using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData
                (
                    new IdentityUserRole<string>
                    {
                        RoleId = "0869adb5-4441-4e7c-959b-e521af835928",
                        UserId = "408aa945-4441-4e7c-959b-e521af835928"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "2569adb5-4441-4e7c-959b-e521af835928",
                        UserId = "bb38929a-75ed-45db-aed0-10d10eeb70e0"
                    }
                );
        }
    }
}