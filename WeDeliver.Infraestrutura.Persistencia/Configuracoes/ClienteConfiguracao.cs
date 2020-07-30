using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Infraestrutura.Persistencia.Configuracoes
{
    public class ClienteConfiguracao : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.DataCriacao).HasColumnName("DataCriacao").HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(a => a.DataModificacao).HasColumnName("DataCriacao").HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(a => a.Nome).HasColumnName("Nome").HasMaxLength(20).IsRequired();
            builder.Property(a => a.Sobrenome).HasColumnName("Sobrenome").HasMaxLength(20).IsRequired();
            builder.Property(a => a.Email).HasColumnName("Email").HasMaxLength(20).IsRequired();
            builder.Property(a => a.Telefone).HasColumnName("Telefone").HasMaxLength(12).IsRequired();
            
            builder.OwnsOne(a => a.Documento, documento =>
            {
                documento.Property(a => a.Identidade).HasColumnName("Identidade").HasMaxLength(9).IsRequired(); ;
                documento.Property(a => a.Cpf).HasColumnName("Cpf").HasMaxLength(11).IsRequired(); ;
                documento.Property(a => a.DataNascimento).HasColumnName("DataNascimento").HasColumnType("Date");
            });

            builder.OwnsOne(a => a.Endereco, endereco => {
                endereco.Property(a=>a.Cep).HasColumnName("Cep").HasMaxLength(7);
                endereco.Property(a => a.Logradouro).HasColumnName("Logradouro").HasMaxLength(50);
                endereco.Property(a => a.Bairro).HasColumnName("Bairro").HasMaxLength(25);
                endereco.Property(a => a.Cidade).HasColumnName("Cidade").HasMaxLength(25);
                endereco.Property(a => a.Estado).HasColumnName("Estado").HasMaxLength(25);
                endereco.Property(a => a.Lote).HasColumnName("Lote").HasMaxLength(4);
                endereco.Property(a => a.Complemento).HasColumnName("Complemento").HasMaxLength(25);
            });

            builder.Ignore(a => a.Pacotes);//Verificar como tratar isto.
        }
    }
}
