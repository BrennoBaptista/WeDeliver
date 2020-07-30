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
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Documento Documento { get; set; }
        public Endereco Endereco { get; set; }
        public List<Pacote> Pacotes { get; set; }// = new List<Pacote>();

        public Cliente() { Iniciar(); }

        public Cliente(string nome, string sobrenome, string email, string telefone)
        {
            Iniciar();
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Telefone = telefone;
        }
    }
}
