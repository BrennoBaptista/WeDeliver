using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Aplicacao.Interfaces;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Interfaces.Servicos;
using WeDeliver.Infraestrutura.Transversal.AutoMapper;

namespace WeDeliver.Aplicacao.Servicos
{
    public class ClienteServicoAplicacao : BaseServicoAplicacao<Cliente>, IClienteServicoAplicacao
    {
        private readonly IClienteServicoDominio _clienteServicoDominio;
        private readonly IMapperCliente _mapperCliente;

        public ClienteServicoAplicacao(IClienteServicoDominio clienteServicoDominio, IMapperCliente mapperCliente) : base(clienteServicoDominio)
        {
            _clienteServicoDominio = clienteServicoDominio;
            _mapperCliente = mapperCliente;
        }

        public void Adicionar(ClienteDTO obj)
        {
            var cliente = _mapperCliente.MapperToEntity(obj);
            _clienteServicoDominio.Adicionar(cliente);
        }

        public IEnumerable<ClienteDTO> Listar()
        {
            var clientes = _clienteServicoDominio.Listar();
            return _mapperCliente.MapperListClientes(clientes);
        }

        public ClienteDTO DetalharPorNome(string busca)
        {
            var cliente = _clienteServicoDominio.DetalharPorNome(busca);
            return _mapperCliente.MapperToDTO(cliente);
        }

        public ClienteDTO DetalharId(Guid id)
        {
            var cliente = _clienteServicoDominio.DetalharId(id);
            return _mapperCliente.MapperToDTO(cliente);
        }

        public void Atualizar(ClienteDTO obj)
        {
            var cliente = _mapperCliente.MapperToEntity(obj);
            _clienteServicoDominio.Atualizar(cliente);
        }

        public void Excluir(ClienteDTO obj)
        {
            var cliente = _mapperCliente.MapperToEntity(obj);
            _clienteServicoDominio.Excluir(cliente);
        }
    }
}
