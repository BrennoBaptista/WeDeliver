using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Infraestrutura.Persistencia.Configuracoes
{
    public class ClienteConfiguracao : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(a => a.Id);
            builder.ToTable("Clientes");
            builder.Property(a => a.DataCriacao)
                .HasColumnName("Pacote")
                .IsRequired()
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");
            builder.Property(a => a.DataCriacao)
                .HasColumnName("Cadastro")
                .IsRequired()
                .HasColumnType("Date")
                .HasDefaultValueSql("GetDate()");
        }
    }
}
