using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Entidades.Enums;
using WeDeliver.Dominio.Interfaces.Repositorios;

namespace WeDeliver.Infraestrutura.Persistencia.Repositorio
{
    public class PacoteRepositorio : BaseRepositorio<Pacote>, IPacoteRepositorio
    {
        private readonly WeDeliverDbContext _contexto;

        public PacoteRepositorio(WeDeliverDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public Pacote DetalharPorDestinatario(string busca)
        {
            return _contexto.Pacotes.FirstOrDefault(a => (a.Destinatario.Nome + " " + a.Destinatario).Contains(busca));
        }

        public Pacote DetalharPorProgresso(string busca)
        {
            return _contexto.Pacotes.FirstOrDefault(a => a.Status.ToString().Contains(busca));
        }

        public Pacote DetalharPorRemetente(string busca)
        {
            return _contexto.Pacotes.FirstOrDefault(a => (a.Remetente.Nome + " " + a.Remetente).Contains(busca));
        }

        public Pacote DetalharPorTipoEnvio(string busca)
        {
            return _contexto.Pacotes.FirstOrDefault(a => a.Tipo.ToString().Contains(busca));
        }
    }
}
