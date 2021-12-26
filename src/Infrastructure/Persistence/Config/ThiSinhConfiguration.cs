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
            //One-to-many trình độ
            builder.HasOne(ts => ts.TrinhDo).WithMany(td => td.ThiSinhs).HasForeignKey(ts => ts.TenTrinhDo);
            //Many-to-many with Khoá thi
            builder.HasMany(ts => ts.KhoaThis).WithMany(kt => kt.ThiSinhs).UsingEntity<DanhSachDangKy>(
                    e => e.HasOne<KhoaThi>().WithMany().HasForeignKey(e => e.MaKT),
                    e => e.HasOne<ThiSinh>().WithMany().HasForeignKey(e => e.SBD),
                    e =>
                    {
                        e.ToTable("DanhSachDangKy");
                    }
               );

            /*builder.HasMany(ts => ts.KhoaThis).WithMany(kt => kt.ThiSinhs).UsingEntity<DanhSachDangKy>(
                    j => j.HasOne(ds => ds.KhoaThi).WithMany(kt => kt.DanhSachDangKi).HasForeignKey(ds => ds.MaKT),
                    j => j.HasOne(ds => ds.ThiSinh).WithMany(ts => ts.DanhSachDangKi).HasForeignKey(ds => ds.SBD),
                    j =>
                    {
                        j.ToTable("DanhSachDangKy");
                        j.HasKey(ds => new { ds.SBD, ds.MaKT });
                    }
               );*/
        }
    }
}