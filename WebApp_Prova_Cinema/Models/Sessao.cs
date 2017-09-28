using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_Prova_Cinema.Models
{
    public class Sessao
    {
        public int SessaoId { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public decimal ValorInteira { get; set; }
        public decimal ValorMeia { get; set; }
        public bool Encerrada { get; set; }
        public List<Filme> Filmes { get; set; }
        public List<Ingresso> Ingressos { get; set; }
        public Sala Salas { get; set; }
    }
}