using System;
using System.Collections.Generic;

namespace SibEscalas.Dominio.Models
{
    public class Escala
    {
        public Guid Id { get; set; }
        public IList<Pessoa> Pessoas { get; set; }
        public DateTime Data { get; set; }
    }
}
