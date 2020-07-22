﻿using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Entidades.Enums;

namespace WeDeliver.Dominio.Interfaces.Servicos
{
    public interface IPacoteServicoDominio : IBaseServicoDominio<Pacote>
    {
        Cliente DetalharPorRemetente(string busca);
        Cliente DetalharPorDestinatario(string busca);
        Progresso DetalharPorProgresso(string busca);
        Envio DetalharPorTipoEnvio(string busca);
    }
}