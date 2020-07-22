using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.Interfaces;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Interfaces.Servicos;

namespace WeDeliver.Aplicacao.Servicos
{
    public class ClienteServicoAplicacao : BaseServicoAplicacao<Cliente>, IClienteServicoAplicacao
    {
        private readonly IClienteServicoDominio _clienteServicoDominio;

        public ClienteServicoAplicacao(IClienteServicoDominio clienteServicoDominio) : base(clienteServicoDominio)
        {
            _clienteServicoDominio = clienteServicoDominio;
        }

        public Cliente DetalharPorNome(string busca)
        {
            return _clienteServicoDominio.DetalharPorNome(busca);
        }
    }
}
