using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Aplicacao.Interfaces
{
    public interface IClienteServicoAplicacao: IBaseServicoAplicacao<Cliente>
    {
        void Adicionar(ClienteDTO obj);
        ClienteDTO DetalharId(Guid id);
        IEnumerable<ClienteDTO> Listar();
        void Atualizar(ClienteDTO obj);
        void Excluir(ClienteDTO obj);
        void Dispose();
        ClienteDTO DetalharPorNome(string busca);
    }
}
