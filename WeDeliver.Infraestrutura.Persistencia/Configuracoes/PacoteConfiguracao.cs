using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Infraestrutura.Persistencia.Configuracoes
{
    public class PacoteConfiguracao : IEntityTypeConfiguration<Pacote>
    {
        public void Configure(EntityTypeBuilder<Pacote> builder)
        {
            builder.HasKey(a => a.Id);
            builder.ToTable("Pacote");
            builder.Property(a => a.DataCriacao)
                .HasColumnName("Cadastro")
                .IsRequired()
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");
        }
    }
}
