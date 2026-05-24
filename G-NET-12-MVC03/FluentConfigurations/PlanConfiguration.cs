using G_NET_12_MVC03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_NET_12_MVC03.FluentConfigurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan> 
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(P => P.Name)
                .HasColumnType("Varchar")
                .HasMaxLength(30);

            builder.Property(P => P.Description)
                .HasMaxLength(200);

            builder.Property(P => P.Price)
                .HasPrecision(10, 2);

            builder.Property(P => P.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.ToTable(TB =>
            {

                TB.HasCheckConstraint("PlanDurationCheck" , "DurationDays Between 1 and 365");



            });


        }

    }
}
