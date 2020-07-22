using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Aplicacao.DTO
{
    public class ObjetoDTO
    {
        public Guid Id { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Profundidade { get; set; }
    }
}
