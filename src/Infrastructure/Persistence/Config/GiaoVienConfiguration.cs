using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Config
{
    public class GiaoVienConfiguration : IEntityTypeConfiguration<GiaoVien>
    {
        public void Configure(EntityTypeBuilder<GiaoVien> builder)
        {
            builder.ToTable("GiaoVien");
            builder.HasKey(gv => gv.MaGV);
        }
    }
}