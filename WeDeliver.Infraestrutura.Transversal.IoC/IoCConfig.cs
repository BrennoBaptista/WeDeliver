using System;
using Autofac;
using WeDeliver.Aplicacao.Interfaces;
using WeDeliver.Aplicacao.Servicos;
using WeDeliver.Dominio.Interfaces.Repositorios;
using WeDeliver.Dominio.Interfaces.Servicos;
using WeDeliver.Dominio.Servico;
using WeDeliver.Infraestrutura.Persistencia.Repositorio;

namespace WeDeliver.Infraestrutura.Transversal.IoC
{
    public class IoCConfig
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClienteServicoAplicacao>().As<IClienteServicoAplicacao>();
            builder.RegisterType<PacoteServicoAplicacao>().As<IPacoteServicoAplicacao>();
            builder.RegisterType<ObjetoServicoAplicacao>().As<IObjetoServicoAplicacao>();

            builder.RegisterType<ClienteServicoDominio>().As<IClienteServicoDominio>();
            builder.RegisterType<PacoteServicoDominio>().As<IPacoteServicoDominio>();
            builder.RegisterType<ObjetoServicoDominio>().As<IObjetoServicoDominio>();

            builder.RegisterType<ClienteRepositorio>().As<IClienteRepositorio>();
            builder.RegisterType<PacoteRepositorio>().As<IPacoteRepositorio>();
            builder.RegisterType<ObjetoRepositorio>().As<IObjetoRepositorio>();


        }

    }
}
