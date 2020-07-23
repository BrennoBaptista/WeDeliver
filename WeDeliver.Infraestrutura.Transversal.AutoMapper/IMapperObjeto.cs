using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Infraestrutura.Transversal.AutoMapper
{
    public interface IMapperObjeto
    {
        Objeto MapperToEntity(ObjetoDTO objetoDTO);
        IEnumerable<ObjetoDTO> MapperListClientes(IEnumerable<Objeto> objetos);
        ObjetoDTO MapperToDTO(Objeto objeto);
    }
}
