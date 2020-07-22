using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Interfaces.Repositorios;
using WeDeliver.Dominio.Interfaces.Servicos;

namespace WeDeliver.Dominio.Servico
{
    public class ObjetoServicoDominio : BaseServicoDominio<Objeto>, IObjetoServicoDominio
    {
        public readonly IObjetoRepositorio _objetoRepositorio;

        public ObjetoServicoDominio(IObjetoRepositorio objetoRepositorio) : base(objetoRepositorio)
        {
            _objetoRepositorio = objetoRepositorio;
        }

    }
}
