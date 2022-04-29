using SibEscalas.Dominio.Models;
using System.Collections.Generic;

namespace SibEscalas.Dominio.Extensions
{
    public static class Store
    {
        public static IList<Funcao> Funcoes { get; set; }
        public static IList<Pessoa> Pessoas { get; set; }

        public static void Iniciar()
        {
            Funcoes = new List<Funcao>();
            Pessoas = new List<Pessoa>();
        }
    }
}
