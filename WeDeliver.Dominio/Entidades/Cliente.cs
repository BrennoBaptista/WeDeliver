using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WeDeliver.Dominio.Entidades.Objetos_de_valor;

namespace WeDeliver.Dominio.Entidades
{
    public class Cliente : BaseEntidade
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(20)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(20)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(20)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Text)]
        [MinLength(3), MaxLength(12)]
        public string Telefone { get; set; }

        public Documento Documento { get; set; }
        public Endereco Endereco { get; set; }

        public ICollection<Pacote> Pacotes { get; set; }

        public Cliente() { Iniciar(); }

        public Cliente(string nome, string sobrenome, string email, string telefone, Documento documento, Endereco endereco)
        {
            Iniciar();
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Telefone = telefone;
            Documento = documento;
            Endereco = endereco;
        }
    }
}
