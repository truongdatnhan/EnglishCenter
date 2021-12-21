using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class PhongThiConfiguration : IEntityTypeConfiguration<PhongThi>
    {
        public void Configure(EntityTypeBuilder<PhongThi> builder)
        {
            builder.ToTable("PhongThi");
            builder.HasKey(p => p.MaPhong);



        }
    }
}