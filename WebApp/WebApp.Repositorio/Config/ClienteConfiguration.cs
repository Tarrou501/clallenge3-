using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Dominio.Entidades;

namespace WebApp.Repositorio.Config
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);
            builder
                .Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(30);
            builder
                .Property(c => c.SobreNome)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(11);
            builder
                .Property(c => c.DataNasc)
                .IsRequired();

            builder
             .Ignore(c => c.Idade);

            builder
             .Property(c => c.Profissao)
             .IsRequired(false);

            builder
             .HasIndex(c => c.SobreNome);

            builder
                .ToTable("t_Cliente");
        }
    }
}
