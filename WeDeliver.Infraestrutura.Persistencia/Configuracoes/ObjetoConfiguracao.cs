using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Infraestrutura.Persistencia.Configuracoes
{
    public class ObjetoConfiguracao : IEntityTypeConfiguration<Objeto>
    {
        public void Configure(EntityTypeBuilder<Objeto> builder)
        {
            builder.HasKey(a => a.Id);
            builder.ToTable("Objeto");
            builder.Property(a => a.DataCriacao)
                .HasColumnName("Cadastro")
                .IsRequired()
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");
        }
    }
}
