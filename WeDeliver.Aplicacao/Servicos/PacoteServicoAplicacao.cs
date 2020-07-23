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
    public class PacoteServicoAplicacao : BaseServicoAplicacao<Pacote>, IPacoteServicoAplicacao
    {
        private readonly IPacoteServicoDominio _pacoteServicoDominio;
        private readonly IMapperPacote _mapperPacote;

        public PacoteServicoAplicacao(IPacoteServicoDominio pacoteServicoDominio, IMapperPacote mapperPacote) : base(pacoteServicoDominio)
        {
            _pacoteServicoDominio = pacoteServicoDominio;
            _mapperPacote = mapperPacote;
        }

        public void Adicionar(PacoteDTO obj)
        {
            var pacote = _mapperPacote.MapperToEntity(obj);
            _pacoteServicoDominio.Adicionar(pacote);
        }

        public void Atualizar(PacoteDTO obj)
        {
            var pacote = _mapperPacote.MapperToEntity(obj);
            _pacoteServicoDominio.Atualizar(pacote);
        }

        public PacoteDTO DetalharPorDestinatario(string busca)
        {
            var pacote = _pacoteServicoDominio.DetalharPorDestinatario(busca);
            return _mapperPacote.MapperToDTO(pacote);
        }

        public PacoteDTO DetalharPorProgresso(string busca)
        {
            var pacote = _pacoteServicoDominio.DetalharPorProgresso(busca);
            return _mapperPacote.MapperToDTO(pacote);
        }

        public PacoteDTO DetalharPorRemetente(string busca)
        {
            var pacote = _pacoteServicoDominio.DetalharPorRemetente(busca);
            return _mapperPacote.MapperToDTO(pacote);
        }

        public PacoteDTO DetalharPorTipoEnvio(string busca)
        {
            var pacote = _pacoteServicoDominio.DetalharPorTipoEnvio(busca);
            return _mapperPacote.MapperToDTO(pacote);
        }

        public void Excluir(PacoteDTO obj)
        {
            var pacote = _mapperPacote.MapperToEntity(obj);
            _pacoteServicoDominio.Excluir(pacote);
        }

        PacoteDTO IPacoteServicoAplicacao.DetalharId(Guid id)
        {
            var pacote = _pacoteServicoDominio.DetalharId(id);
            return _mapperPacote.MapperToDTO(pacote);
        }

        IEnumerable<PacoteDTO> IPacoteServicoAplicacao.Listar()
        {
            var pacotes = _pacoteServicoDominio.Listar();
            return _mapperPacote.MapperListPacotes(pacotes);
        }
    }
}
