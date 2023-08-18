using DataAccess.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Persistence.Configurations;

public class ProducerProductConfiguration : EntityConfiguration<ProducerProduct>//five
{
    public override void Configure(EntityTypeBuilder<ProducerProduct> builder)
    {
        builder.HasKey(pp => new { pp.ProducerId, pp.ProductId });

        builder.HasOne(x => x.Product)
            .WithMany(y => y.ProducerProducts)
            .HasForeignKey(o => o.ProductId);

        builder.HasOne(x => x.Producer)
            .WithMany(y => y.ProducerProducts)
            .HasForeignKey(o => o.ProducerId);
    }
}