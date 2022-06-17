using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercicio3
{
    class TestaArvore
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();

            Pessoa Lily = new Pessoa("Lily");
            Lily.AdicionarConjuge("Wilhelm");

            Pessoa Opa = new Pessoa().AdicionarFilho("Opa", Lily, Lily.Conjuge);
            Opa.AdicionarConjuge("Oma");

            Pessoa Reinhold = new Pessoa().AdicionarFilho("Reinhold", Opa, Opa.Conjuge);
            Reinhold.AdicionarConjuge("Sonia");
            Pessoa Christian = new Pessoa().AdicionarFilho("Christian", Reinhold, Reinhold.Conjuge);
            Pessoa Gabi = new Pessoa().AdicionarFilho("Gabi", Reinhold, Reinhold.Conjuge);
            Pessoa Sabine = new Pessoa().AdicionarFilho("Sabine", Reinhold, Reinhold.Conjuge);

            Pessoa Wilma = new Pessoa().AdicionarFilho("Wilma", Opa, Opa.Conjuge);
            Wilma.AdicionarConjuge("Rodolfo");
            Pessoa Ricardo = new Pessoa().AdicionarFilho("Ricardo", Wilma, Wilma.Conjuge);

            Pessoa Sigrid = new Pessoa().AdicionarFilho("Sigrid", Opa, Opa.Conjuge);
            Sigrid.AdicionarConjuge("Pedro");
            Pessoa Martin = new Pessoa().AdicionarFilho("Martin", Sigrid, Sigrid.Conjuge);
            Pessoa Thomas = new Pessoa().AdicionarFilho("Thomas", Sigrid, Sigrid.Conjuge);
            Pessoa Claudia = new Pessoa().AdicionarFilho("Claudia", Sigrid, Sigrid.Conjuge);

            Martin.AdicionarConjuge("Carla");
            Pessoa Nicolas = new Pessoa().AdicionarFilho("Nicolas", Martin, Martin.Conjuge);

            Ricardo.AdicionarConjuge("Debora");
            Pessoa Rodrigo = new Pessoa().AdicionarFilho("Rodrigo", Ricardo, Ricardo.Conjuge);
            Sigrid.AdicionarConjuge("Pedro");

            Christian.AdicionarConjuge("Monica");
            Pessoa Oscar = new Pessoa().AdicionarFilho("Oscar", Christian, Christian.Conjuge);
            Pessoa Lorena = new Pessoa().AdicionarFilho("Lorena", Christian, Christian.Conjuge);

            lista.Add(Lily);
            lista.Add(Opa);
            lista.Add(Reinhold);
            lista.Add(Wilma);
            lista.Add(Sigrid);
            lista.Add(Martin);
            lista.Add(Thomas);
            lista.Add(Claudia);
            lista.Add(Nicolas);
            lista.Add(Ricardo);
            lista.Add(Rodrigo);
            lista.Add(Christian);
            lista.Add(Gabi);
            lista.Add(Sabine);
            lista.Add(Oscar);
            lista.Add(Lorena);

            Pessoa.ImprimirArvore(null, lista, 0);
        }
    }
}
        
