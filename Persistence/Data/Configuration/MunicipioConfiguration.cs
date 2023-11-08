using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class MunicipioConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        builder.ToTable("ciudad");

        builder.Property(e => e.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(e => e.Departamento)
        .WithMany(e => e.Ciudades)
        .HasForeignKey(e => e.IdDepartamentoFk);
    }
}
