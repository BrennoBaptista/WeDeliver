using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Aplicacao.Interfaces
{
    public interface IObjetoServicoAplicacao : IBaseServicoAplicacao<Objeto>
    {
        void Adicionar(ObjetoDTO obj);
        ObjetoDTO DetalharId(Guid id);
        IEnumerable<ObjetoDTO> Listar();
        void Atualizar(ObjetoDTO obj);
        void Excluir(ObjetoDTO obj);
        void Dispose();
    }
}
