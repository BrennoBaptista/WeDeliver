using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Dominio.Entidades.Enums;

namespace WeDeliver.Aplicacao.DTO
{
    public class PacoteDTO
    {
        public Guid Id { get; set; }
        public Cliente Remetente { get; set; }
        public Cliente Destinatario { get; set; }
        public Progresso Status { get; set; }
        public Envio Tipo { get; set; }
    }
}
