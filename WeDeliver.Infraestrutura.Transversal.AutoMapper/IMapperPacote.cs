using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Aplicacao.DTO;
using WeDeliver.Dominio.Entidades;

namespace WeDeliver.Infraestrutura.Transversal.AutoMapper
{
    public interface IMapperPacote
    {
        Pacote MapperToEntity(PacoteDTO pacoteDTO);
        IEnumerable<PacoteDTO> MapperListPacotes(IEnumerable<Pacote> pacotes);
        PacoteDTO MapperToDTO(Pacote pacote);
    }
}
