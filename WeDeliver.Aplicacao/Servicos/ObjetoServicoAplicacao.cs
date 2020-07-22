using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.Interfaces;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Interfaces.Servicos;

namespace WeDeliver.Aplicacao.Servicos
{
    public class ObjetoServicoAplicacao : BaseServicoAplicacao<Objeto>, IObjetoServicoAplicacao
    {
        private readonly IObjetoServicoDominio _objetoServicoDominio;

        public ObjetoServicoAplicacao(IObjetoServicoDominio objetoServicoDominio) : base(objetoServicoDominio)
        {
            _objetoServicoDominio = objetoServicoDominio;
        }



    }
}
