using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Config
{
    public class KhoaThiConfiguration : IEntityTypeConfiguration<KhoaThi>
    {
        public void Configure(EntityTypeBuilder<KhoaThi> builder)
        {
            builder.ToTable("KhoaThi");
            builder.HasKey(kt => kt.MaKhoaThi);
        }
    }
}