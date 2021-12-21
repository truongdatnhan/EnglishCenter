using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class BaiThiConfiguration : IEntityTypeConfiguration<BaiThi>
    {
        public void Configure(EntityTypeBuilder<BaiThi> builder)
        {
            builder.ToTable("BaiThi");
            builder.HasKey(b => b.MaBaiThi);



        }
    }
}