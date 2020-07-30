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
            builder.ToTable("Objetos");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.DataCriacao).HasColumnName("DataCriacao").HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(a => a.DataModificacao).HasColumnName("DataCriacao").HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(a => a.Peso).HasColumnName("Peso").IsRequired();
            builder.Property(a => a.Altura).HasColumnName("Altura").IsRequired();
            builder.Property(a => a.Largura).HasColumnName("Largura").IsRequired();
            builder.Property(a => a.Profundidade).HasColumnName("Profundidade").IsRequired();
        }
    }
}
