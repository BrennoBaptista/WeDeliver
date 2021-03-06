﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Aplicacao.Interfaces
{
    public interface IBaseServicoAplicacao <T> where T : class
    {
        void Adicionar(T obj);
        T DetalharId(Guid id);
        IEnumerable<T> Listar();
        void Atualizar(T obj);
        void Excluir(T obj);
        void Dispose();
    }
}
