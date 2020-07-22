using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Interfaces.Repositorios;
using WeDeliver.Dominio.Interfaces.Servicos;

namespace WeDeliver.Dominio.Servico
{
    public class ClienteServicoDominio : BaseServicoDominio<Cliente>, IClienteServicoDominio
    {
        public readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServicoDominio(IClienteRepositorio clienteRepositorio) :base(clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public Cliente DetalharPorNome(string busca)
        {
            return _clienteRepositorio.DetalharPorNome(busca);
        }
    }
}
