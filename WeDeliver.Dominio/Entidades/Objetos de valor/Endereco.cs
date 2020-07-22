using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Dominio.Entidades.Objetos_de_valor
{
    public struct Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public Endereco(string cep, string logradouro, string bairro, string cidade, string estado, string numero, string complemento)
        {
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Numero = numero;
            Complemento = complemento;
        }
    }
}
