using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Entidades.Enums;

namespace WeDeliver.Dominio.Interfaces.Servicos
{
    public interface IPacoteServicoDominio : IBaseServicoDominio<Pacote>
    {
        Pacote DetalharPorRemetente(string busca);
        Pacote DetalharPorDestinatario(string busca);
        Pacote DetalharPorProgresso(string busca);
        Pacote DetalharPorTipoEnvio(string busca);
    }
}
