using BlogWebY.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Data.Mapping
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId= Guid.Parse("CEF5328A-BB41-4F5A-91F6-A8514570E453"),
                RoleId= Guid.Parse("8A938CC1-331A-4373-96A4-0F35D1858CC1"),

            },
            new AppUserRole
            {
                UserId= Guid.Parse("A0AFAFBD-64C6-4146-94D3-F81F6D752B7C"),
                RoleId= Guid.Parse("0046F62E-323D-4764-81F8-2551E9277EE1")
            });
        }
    }
}
