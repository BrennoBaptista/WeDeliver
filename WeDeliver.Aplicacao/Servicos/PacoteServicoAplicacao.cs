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

        public Cliente DetalharPorDestinatario(string busca)
        {
            return _pacoteServicoDominio.DetalharPorDestinatario(busca);
        }

        public Progresso DetalharPorProgresso(string busca)
        {
            return _pacoteServicoDominio.DetalharPorProgresso(busca);
        }

        public Cliente DetalharPorRemetente(string busca)
        {
            return _pacoteServicoDominio.DetalharPorRemetente(busca);
        }

        public Envio DetalharPorTipoEnvio(string busca)
        {
            return _pacoteServicoDominio.DetalharPorTipoEnvio(busca);
        }
    }
}
