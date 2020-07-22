using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Dominio.Interfaces.Servicos
{
    public interface IClienteServicoDominio : IBaseServicoDominio<Cliente>
    {
        Cliente DetalharPorNome(string busca);
    }
}
