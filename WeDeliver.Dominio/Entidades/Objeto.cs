using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Dominio.Entidades
{
    public class Objeto : BaseEntidade
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Profundidade { get; set; }

        public Objeto() { Iniciar(); }

        public Objeto(double peso, double altura, double largura, double profundidade)
        {
            Iniciar();
            Peso = peso;
            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;
        }
    }
}
