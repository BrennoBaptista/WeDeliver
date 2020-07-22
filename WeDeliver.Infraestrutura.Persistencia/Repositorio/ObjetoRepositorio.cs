using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Interfaces.Repositorios;

namespace WeDeliver.Infraestrutura.Persistencia.Repositorio
{
    public class ObjetoRepositorio : BaseRepositorio<Objeto>, IObjetoRepositorio
    {
        private readonly WeDeliverDbContext _contexto;
        public ObjetoRepositorio(WeDeliverDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
