using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Entidades.Enums;

namespace WeDeliver.Aplicacao.Interfaces
{
    public interface IPacoteServicoAplicacao : IBaseServicoAplicacao<Pacote>
    {
        void Adicionar(PacoteDTO obj);
        PacoteDTO DetalharId(Guid id);
        IEnumerable<PacoteDTO> Listar();
        void Atualizar(PacoteDTO obj);
        void Excluir(PacoteDTO obj);
        void Dispose();

        PacoteDTO DetalharPorRemetente(string busca);
        PacoteDTO DetalharPorDestinatario(string busca);
        PacoteDTO DetalharPorProgresso(string busca);
        PacoteDTO DetalharPorTipoEnvio(string busca);
    }
}
