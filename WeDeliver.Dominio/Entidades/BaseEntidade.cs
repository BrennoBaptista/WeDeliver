using System;

namespace WeDeliver.Dominio.Entidades
{
    public class BaseEntidade
    {
        public Guid Id { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
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
