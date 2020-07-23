using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Dominio.Interfaces.Servicos
{
    public interface IBaseServicoDominio<T> where T : class
    {
        void Adicionar(T obj);
        T DetalharId(Guid id);
        IEnumerable<T> Listar();
        void Atualizar(T obj);
        void Excluir(T obj);
        void Dispose();
    }
}
