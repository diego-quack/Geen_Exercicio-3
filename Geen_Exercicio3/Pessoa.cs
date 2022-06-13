using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercicio3
{
    class Pessoa
    {
        public String Nome { get; set; }
        public Pessoa Pessoa1 { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, Pessoa pessoa1) : this(nome)
        {
            Pessoa1 = pessoa1;
        }

        public void AdicionarFilho(Pessoa nome)
        {
            Pessoa pessoa = new Pessoa(nome.Nome);
        }

        public void Conjuge(Pessoa nome)
        {
            Pessoa pessoa = new Pessoa(nome.Nome);
        }

        public void ImprimirArvore(Pessoa pessoa)
        {

        }
    }
}
