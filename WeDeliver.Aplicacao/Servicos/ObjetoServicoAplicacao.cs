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
    public class ObjetoServicoAplicacao : BaseServicoAplicacao<Objeto>, IObjetoServicoAplicacao
    {
        private readonly IObjetoServicoDominio _objetoServicoDominio;
        private readonly IMapperObjeto _mapperObjeto;

        public ObjetoServicoAplicacao(IObjetoServicoDominio objetoServicoDominio, IMapperObjeto mapperObjeto) : base(objetoServicoDominio)
        {
            _objetoServicoDominio = objetoServicoDominio;
            _mapperObjeto = mapperObjeto;
        }

        public void Adicionar(ObjetoDTO obj)
        {
            var objeto = _mapperObjeto.MapperToEntity(obj);
            _objetoServicoDominio.Adicionar(objeto);
        }

        public void Atualizar(ObjetoDTO obj)
        {
            var objeto = _mapperObjeto.MapperToEntity(obj);
            _objetoServicoDominio.Atualizar(objeto);
        }

        public ObjetoDTO DetalharId(Guid id)
        {
            var objeto = _objetoServicoDominio.DetalharId(id);
            return _mapperObjeto.MapperToDTO(objeto);
        }

        public void Excluir(ObjetoDTO obj)
        {
            var objeto = _mapperObjeto.MapperToEntity(obj);
            _objetoServicoDominio.Excluir(objeto);
        }

        IEnumerable<ObjetoDTO> IObjetoServicoAplicacao.Listar()
        {
            var objetos = _objetoServicoDominio.Listar();
            return _mapperObjeto.MapperListClientes(objetos);
        }
    }
}
