using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Infraestrutura.Transversal.AutoMapper
{
    public class MapperObjeto : IMapperObjeto
    {
        List<ObjetoDTO> objetosDTO = new List<ObjetoDTO>();

        public IEnumerable<ObjetoDTO> MapperListClientes(IEnumerable<Objeto> objetos)
        {
            foreach (var o in objetos)
            {
                ObjetoDTO objetoDTO = new ObjetoDTO
                {
                    Id = o.Id,
                    Peso = o.Peso,
                    Altura = o.Altura,
                    Largura = o.Largura,
                    Profundidade = o.Profundidade
                };
                objetosDTO.Add(objetoDTO);
            }
            return objetosDTO;
        }

        public ObjetoDTO MapperToDTO(Objeto objeto)
        {
            ObjetoDTO objetoDTO = new ObjetoDTO
            {
                Id = objeto.Id,
                Peso = objeto.Peso,
                Altura = objeto.Altura,
                Largura = objeto.Largura,
                Profundidade = objeto.Profundidade
            };
            return objetoDTO;
        }

        public Objeto MapperToEntity(ObjetoDTO objetoDTO)
        {
            Objeto objeto = new Objeto
            {
                Id = objetoDTO.Id,
                Peso = objetoDTO.Peso,
                Altura = objetoDTO.Altura,
                Largura = objetoDTO.Largura,
                Profundidade = objetoDTO.Profundidade
            };
            return objeto;
        }
    }
}
