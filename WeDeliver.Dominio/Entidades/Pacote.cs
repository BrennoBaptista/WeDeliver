using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Dominio.Entidades.Enums;

namespace WeDeliver.Dominio.Entidades
{
    public class Pacote : BaseEntidade
    {
        public Guid RemetenteId { get; set; }
        public Cliente Remetente { get; set; }
        public Guid DestinatarioId { get; set; }
        public Cliente Destinatario { get; set; }
        public Progresso Status { get; set; }
        public Envio Tipo { get; set; }
        public List<Objeto> Objetos { get; set; }// = new List<Objeto>();

        public Pacote() { Iniciar(); }

        public Pacote(Cliente remetente, Cliente destinatario, Progresso status, Envio tipo)
        {
            Iniciar();
            Remetente = remetente;
            Destinatario = destinatario;
            Status = status;
            Tipo = tipo;
        }

        public double PesoPacote()
        {
            double pesoTotal = 0;
            foreach(Objeto objeto in Objetos)
            {
                pesoTotal += objeto.Peso;
            }
            return pesoTotal;
        }

        public double VolumePacote()
        {
            double volumeTotal = 0;
            foreach (Objeto objeto in Objetos)
            {
                volumeTotal += objeto.Altura * objeto.Largura * objeto.Profundidade;
            }
            return volumeTotal;
        }
    }
}
