using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Dominio.Entidades.Objetos_de_valor
{
    public struct Documento
    {
        public string Identidade { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public Documento(string identidade, string cpf, DateTime dataNascimento)
        {
            Identidade = identidade;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }
    }
}
