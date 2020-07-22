using System;
using System.Collections;
using System.Collections.Generic;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Infraestrutura.Transversal.AutoMapper
{
    public interface IMapperCliente
    {
        Cliente MapperToEntity(ClienteDTO clienteDTO);
        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);
        ClienteDTO MapperToDTO(Cliente cliente);
    }
}
