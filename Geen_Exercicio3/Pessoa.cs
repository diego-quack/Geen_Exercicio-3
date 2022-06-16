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
        public Pessoa Ascendente { get; set; }
        public List<Pessoa> Filho = new List<Pessoa>();

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, Pessoa ascendente) : this(nome)
        {
            Ascendente = ascendente;
        }

        public void AdicionarFilho(Pessoa nome)
        {
            Pessoa pessoa = new Pessoa(nome.Nome);
            Console.WriteLine("-->" + pessoa.Nome + " é solteiro(a)");
        }

        public void Conjuge(Pessoa nome)
        {
            Pessoa pessoa = new Pessoa(nome.Nome);
            Console.WriteLine("-->" + Nome + " é casado(a) com " + pessoa.Nome + " - Filhos: ");
        }

        public void ImprimirArvore(Pessoa pessoa, int cont)
        {
            if(cont == 0)
            {
                Console.WriteLine("Erro");
            }
            Conjuge(pessoa);
            AdicionarFilho(pessoa);
            ImprimirArvore(pessoa, cont + 1);
        }
    }
}
