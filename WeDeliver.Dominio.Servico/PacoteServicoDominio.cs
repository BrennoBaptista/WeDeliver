using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Entidades.Enums;
using WeDeliver.Dominio.Interfaces.Repositorios;
using WeDeliver.Dominio.Interfaces.Servicos;

namespace WeDeliver.Dominio.Servico
{
    public class PacoteServicoDominio : BaseServicoDominio<Pacote>, IPacoteServicoDominio
    {
        public readonly IPacoteRepositorio _pacoteRepositorio;

        public PacoteServicoDominio(IPacoteRepositorio pacoteRepositorio) :base (pacoteRepositorio)
        {
            _pacoteRepositorio = pacoteRepositorio;
        }

        public Pacote DetalharPorDestinatario(string busca)
        {
            return _pacoteRepositorio.DetalharPorDestinatario(busca);
        }

        public Pacote DetalharPorProgresso(string busca)
        {
            return _pacoteRepositorio.DetalharPorProgresso(busca);
        }

        public Pacote DetalharPorRemetente(string busca)
        {
            return _pacoteRepositorio.DetalharPorRemetente(busca);
        }

        public Pacote DetalharPorTipoEnvio(string busca)
        {
            return _pacoteRepositorio.DetalharPorTipoEnvio(busca);
        }
    }
}
