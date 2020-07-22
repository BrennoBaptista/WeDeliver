using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WeDeliver.Dominio.Entidades.Objetos_de_valor
{
    public class Documento
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(9)]
        public string Identidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(11)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.DateTime)]
        public DateTime DataNascimento { get; set; }

        public Documento(string identidade, string cpf, DateTime dataNascimento)
        {
            Identidade = identidade;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }
    }
}
