using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Interfaces.Repositorios;

namespace WeDeliver.Infraestrutura.Persistencia.Repositorio
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        private readonly WeDeliverDbContext _contexto;

        public ClienteRepositorio(WeDeliverDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public Cliente DetalharPorNome(string busca)
        {
            return _contexto.Clientes.FirstOrDefault(a => (a.Nome + " " + a.Sobrenome).Contains(busca));
        }
    }
}
