using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Infraestrutura.Transversal.AutoMapper
{
    public class MapperCliente : IMapperCliente
    {
        List<ClienteDTO> clientesDTO = new List<ClienteDTO>();

        public IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes)
        {
            foreach(var c in clientes)
            {
                ClienteDTO clienteDTO = new ClienteDTO
                {
                    Id = c.Id,
                    Nome = c.Nome,
                    Sobrenome = c.Sobrenome,
                    Email = c.Email
                };
                clientesDTO.Add(clienteDTO);
            }
            return clientesDTO;
        }

        public ClienteDTO MapperToDTO(Cliente cliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };
            return clienteDTO;
        }

        public Cliente MapperToEntity(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente
            {
                Id = clienteDTO.Id,
                Nome = clienteDTO.Nome,
                Sobrenome = clienteDTO.Sobrenome,
                Email = clienteDTO.Email
            };
            return cliente;
        }
    }
}