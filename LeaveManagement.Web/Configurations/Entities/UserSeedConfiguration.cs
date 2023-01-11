using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "408aa945-4441-4e7c-959b-e521af835928",
                    Email = "admin@localhost.com.ar",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM.AR",
                    UserName = "admin@localhost.com.ar",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM.AR",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Shinobu_1"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "bb38929a-75ed-45db-aed0-10d10eeb70e0",
                    Email = "user@localhost.com.ar",
                    NormalizedEmail = "USER@LOCALHOST.COM.AR",
                    NormalizedUserName = "USER@LOCALHOST.COM.AR",
                    UserName = "user@localhost.com.ar",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Shinobu_1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}