using System;

namespace WeDeliver.Aplicacao.DTO
{
    public class ClienteDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }

    }
}
