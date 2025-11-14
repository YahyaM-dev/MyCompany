using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCompany.DAL.Models;

namespace MyCompany.DAL.Data.ModelsConfigurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.DepartmentId);
            builder.Property(D => D.DepartmentId).UseIdentityColumn(10, 10);
            builder.Property(D => D.Code).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(D => D.Name).HasMaxLength(50).HasColumnType("varchar").IsRequired();
        }
    }
}
