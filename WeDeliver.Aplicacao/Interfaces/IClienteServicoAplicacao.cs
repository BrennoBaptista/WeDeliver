using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Aplicacao.Interfaces
{
    public interface IClienteServicoAplicacao: IBaseServicoAplicacao<Cliente>
    {
        Cliente DetalharPorNome(string busca);
    }
}
