using SibEscalas.Dominio.Models;
using System.ComponentModel;

namespace SibEscalas.Dominio.Extensions
{
    public class Store
    {
        public BindingList<Funcao> Funcoes { get; set; }
        public BindingList<Pessoa> Pessoas { get; set; }

        public void AtualizarStore(Store store)
        {
            foreach (Funcao funcao in store.Funcoes)
                Funcoes.Add(funcao);

            foreach (Pessoa pessoa in store.Pessoas)
                Pessoas.Add(pessoa);
        }
    }
}
