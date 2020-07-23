using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Infraestrutura.Transversal.AutoMapper
{
    public class MapperPacote : IMapperPacote
    {
        List<PacoteDTO> pacotesDTO = new List<PacoteDTO>();

        public IEnumerable<PacoteDTO> MapperListPacotes(IEnumerable<Pacote> pacotes)
        {
            foreach (var p in pacotes)
            {
                PacoteDTO pacoteDTO = new PacoteDTO
                {
                    Id = p.Id,
                    Remetente = p.Remetente,
                    Destinatario = p.Destinatario,
                    Status = p.Status,
                    Tipo = p.Tipo
                };
                pacotesDTO.Add(pacoteDTO);
            }
            return pacotesDTO;
        }

        public PacoteDTO MapperToDTO(Pacote pacote)
        {
            PacoteDTO pacoteDTO = new PacoteDTO
            {
                Id = pacote.Id,
                Remetente = pacote.Remetente,
                Destinatario = pacote.Destinatario,
                Status = pacote.Status,
                Tipo = pacote.Tipo
            };
            return pacoteDTO;
        }

        public Pacote MapperToEntity(PacoteDTO pacoteDTO)
        {
            Pacote pacote = new Pacote
            {
                Id = pacoteDTO.Id,
                Remetente = pacoteDTO.Remetente,
                Destinatario = pacoteDTO.Destinatario,
                Status = pacoteDTO.Status,
                Tipo = pacoteDTO.Tipo
            };
            return pacote;
        }
    }
}
