using System;

namespace SibEscalas.Dominio.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Funcao Funcao { get; set; }
    }
}
