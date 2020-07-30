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
            builder.ToTable("Pacotes");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.DataCriacao).HasColumnName("DataCriacao").HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(a => a.DataModificacao).HasColumnName("DataCriacao").HasColumnType("Date").HasDefaultValueSql("GetDate()");

            builder.Property(a => a.RemetenteId).HasColumnName("RemetenteId").IsRequired();
            builder.HasOne(a => a.Remetente).WithMany().HasForeignKey(a => a.RemetenteId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(a => a.DestinatarioId).HasColumnName("DestinatarioId").IsRequired();
            builder.HasOne(a => a.Destinatario).WithMany().HasForeignKey(a => a.DestinatarioId).OnDelete(DeleteBehavior.NoAction);
            
            builder.Property(a => a.Status).HasColumnName("Status").IsRequired();
            builder.Property(a => a.Tipo).HasColumnName("Tipo").IsRequired();
            
            builder.Ignore(a => a.Objetos);//Verificar como tratar isto.
        }
    }
}
