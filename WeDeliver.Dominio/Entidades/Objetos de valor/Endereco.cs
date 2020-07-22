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
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(8), MaxLength(8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(50)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(25)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(25)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(25)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(10)]
        public string Numero { get; set; }

        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(25)]
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
