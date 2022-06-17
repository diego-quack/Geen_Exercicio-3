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
        public Pessoa Pai { get; set; }
        public Pessoa Mae { get; set; }
        public Pessoa Conjuge { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, Pessoa pai, Pessoa mae) : this(nome)
        {

            Pai = pai;
            Mae = mae;
        }

        public Pessoa AdicionarFilho(String nome, Pessoa responsavel1, Pessoa responsavel2)
        {
            Pessoa pessoa = new Pessoa(nome, responsavel1, responsavel2);
            return pessoa;
        }

        public void AdicionarConjuge(String nome)
        {
            Conjuge = new Pessoa(nome);
        }

        public static void ImprimirArvore(Pessoa pessoaAtual, List<Pessoa> lista, int contador)
        {
            if (pessoaAtual is null)
            {
                foreach(Pessoa pessoa in lista)
                {
                    if (pessoa.Pai is null)
                    {
                        if (pessoa.Conjuge is null)
                        {
                            pessoaAtual = new Pessoa();
                            Console.WriteLine("-->" + pessoa.Nome + " é solteiro(a)");
                        }
                        else
                        {
                            pessoaAtual = new Pessoa();
                            Console.WriteLine("-->" + pessoa.Nome + " é casado(a) com " + pessoa.Conjuge.Nome + " - Filhos: ");
                            ImprimirArvore(pessoa, lista, contador + 2);
                        }
                    }
                }
            }
            else
            {
                Boolean existeFilhos = false;
                foreach(Pessoa pessoaAtual2 in lista)
                {
                    if(!existeFilhos)
                    {
                        if(pessoaAtual2.Pai == pessoaAtual || pessoaAtual2.Mae == pessoaAtual)
                        {
                            string mensagem = "";
                            for(int i = 0; i < contador; i++)
                            {
                                mensagem += " ";
                            }
                            if(pessoaAtual2.Conjuge is null)
                            {
                                Console.WriteLine(mensagem + "--> " + pessoaAtual2.Nome + " é solteiro(a)");
                            }
                            else
                            {
                                Console.WriteLine(mensagem + "--> " + pessoaAtual2.Nome + " é casado(a) com " + pessoaAtual2.Conjuge.Nome + " - Filhos: ");
                                ImprimirArvore(pessoaAtual2, lista, contador + 2);
                            }
                        }
                    }
                }
            }
        }
    }
}
