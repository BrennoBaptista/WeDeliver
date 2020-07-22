using System;
using System.ComponentModel.DataAnnotations;

namespace WeDeliver.Dominio.Entidades
{
    public class BaseEntidade
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }

        public BaseEntidade()
        {
            Iniciar();
        }

        public void Iniciar()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }
        public void AtualizarModificacao()
        {
            DataModificacao = DateTime.Now;
        }
    }
}
