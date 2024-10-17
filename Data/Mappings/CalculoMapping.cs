using CalculadoraPekus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalculadoraPekus.Data.Mappings;

public class CalculoMapping : IEntityTypeConfiguration<Calculo>
{
    public void Configure(EntityTypeBuilder<Calculo> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();


        builder.Property(x => x.TipoCalculo).HasColumnName("Operação")
            .IsRequired()
            .HasConversion<string>();
        
        builder.Property(x => x.ValorA)
            .IsRequired()
            .HasColumnName("ValorA")
            .HasColumnType("DECIMAL");
        
        builder.Property(x => x.ValorB)
            .IsRequired()
            .HasColumnName("ValorB")
            .HasColumnType("DECIMAL");

        builder.Property(x => x.Resultado)
            .IsRequired()
            .HasColumnName("Resultado")
            .HasColumnType("DECIMAL");
        
        builder.Property(x => x.DataCalculo).HasColumnName("DataCalculo")
            .IsRequired()
            .HasDefaultValue(DateTime.Now)
            .HasColumnType("DATETIME2");
    }
}