using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class ThiSinhConfiguration : IEntityTypeConfiguration<ThiSinh>
    {
        public void Configure(EntityTypeBuilder<ThiSinh> builder)
        {
            builder.ToTable("ThiSinh");
            builder.HasKey(ts => ts.SBD);
            builder.HasOne(ts => ts.TrinhDo).WithMany(td => td.ThiSinhs).HasForeignKey(ts => ts.TenTrinhDo);
            builder.HasMany(ts => ts.KhoaThis).WithMany(kt => kt.ThiSinhs).UsingEntity<DanhSachDangKy>(
                e => e.HasOne<ThiSinh>().WithMany().HasForeignKey(e => e.MaKT),
                e => e.HasOne<KhoaThi>().WithMany().HasForeignKey(e => e.SBD),
                e => e.ToTable("DanhSachDangKy")
               );
        }
    }
}