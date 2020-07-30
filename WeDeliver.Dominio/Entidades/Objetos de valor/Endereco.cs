using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WeDeliver.Dominio.Entidades.Objetos_de_valor
{
    public class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Lote { get; set; }
        public string Complemento { get; set; }

        public Endereco(string cep, string logradouro, string bairro, string cidade, string estado, string lote, string complemento)
        {
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Lote = lote;
            Complemento = complemento;
        }
    }
}
