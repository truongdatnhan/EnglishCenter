using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class TrinhDoConfiguration : IEntityTypeConfiguration<TrinhDo>
    {
        public void Configure(EntityTypeBuilder<TrinhDo> builder)
        {
            builder.ToTable("TrinhDo");
            builder.HasKey(td => td.TenTrinhDo);

        }
    }
}