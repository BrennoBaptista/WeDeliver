using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Dominio.Interfaces.Repositorios
{
    public interface IClienteRepositorio : IBaseRepositorio<Cliente>
    {
        Cliente DetalharPorNome(string busca);
    }
}
