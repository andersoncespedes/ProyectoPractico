using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class UsuarioConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("usuario");

        builder.Property(e => e.UserName)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(e => e.UserEmail)
        .HasColumnName("correo")
        .HasColumnType("varchar")
        .IsRequired()
        .HasMaxLength(40);

        builder.Property(e => e.UserPassword)
        .HasColumnName("contraseña")
        .HasColumnType("varchar")
        .IsRequired()
        .HasMaxLength(255);

        builder.HasMany(e => e.Rols)
        .WithMany(e => e.Users)
        .UsingEntity<UserRol>(
            j => j.HasOne(e => e.Rol)
            .WithMany(e => e.UsersRols)
            .HasForeignKey(e => e.IdRol),

            j => j.HasOne(e => e.User)
            .WithMany(e => e.UsersRols)
            .HasForeignKey(e => e.IdUser),

            j =>
            {
                j.ToTable("usuarios_roles");
                j.HasKey(x => new { x.IdUser, x.IdRol });
            }
        );
    }
}
