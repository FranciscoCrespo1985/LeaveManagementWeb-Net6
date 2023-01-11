using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LeaveManagement.Web.Constants;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
                (
                    new IdentityRole
                    {
                        Id = "0869adb5-4441-4e7c-959b-e521af835928",
                        Name = Roles.Administrator,
                        NormalizedName = Roles.Administrator.ToUpper()
                    },
                     new IdentityRole
                     {
                         Id = "2569adb5-4441-4e7c-959b-e521af835928",
                         Name = Roles.User,
                         NormalizedName = Roles.User.ToUpper()
                     }
                ); ;
        }
    }
}