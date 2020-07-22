using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.Interfaces;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Entidades.Enums;
using WeDeliver.Dominio.Interfaces.Servicos;

namespace WeDeliver.Aplicacao.Servicos
{
    public class PacoteServicoAplicacao : BaseServicoAplicacao<Pacote>, IPacoteServicoAplicacao
    {
        private readonly IPacoteServicoDominio _pacoteServicoDominio;

        public PacoteServicoAplicacao(IPacoteServicoDominio pacoteServicoDominio) : base(pacoteServicoDominio)
        {
            _pacoteServicoDominio = pacoteServicoDominio;
        }

        public Pacote DetalharPorDestinatario(string busca)
        {
            return _pacoteServicoDominio.DetalharPorDestinatario(busca);
        }

        public Pacote DetalharPorProgresso(string busca)
        {
            return _pacoteServicoDominio.DetalharPorProgresso(busca);
        }

        public Pacote DetalharPorRemetente(string busca)
        {
            return _pacoteServicoDominio.DetalharPorRemetente(busca);
        }

        public Pacote DetalharPorTipoEnvio(string busca)
        {
            return _pacoteServicoDominio.DetalharPorTipoEnvio(busca);
        }
    }
}
