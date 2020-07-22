using System;
using System.Collections.Generic;
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
        public List<Pacote> Pacotes { get; set; }

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

        public void Teste()
        {
            Documento documento = new Documento("271032765", "14424377741", DateTime.Parse("02/08/1995"));
            Endereco endereco = new Endereco("24342079", "Rua Escrivao Cezar March", "Maravista", "Niteroi", "Rio de Janeiro", "7", "quadra 92");
            Cliente cliente = new Cliente("brenno", "baptista", "email", "telefone", documento, endereco);
            Console.WriteLine(cliente.Endereco.Cep);
        }
    }
}
