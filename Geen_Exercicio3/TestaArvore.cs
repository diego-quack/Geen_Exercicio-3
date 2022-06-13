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
            Pessoa Lily = new Pessoa("Lily");
            Lily.Conjuge(new Pessoa("Wilhelm"));
            
            Pessoa Opa = new Pessoa("Opa", Lily);
            Opa.Conjuge(new Pessoa("Oma"));
            
            Pessoa Reinhold = new Pessoa("Reinhold", Opa);
            Pessoa Wilma = new Pessoa("Wilma", Opa);
            Pessoa Sigrid = new Pessoa("Sigrid", Opa);
            
            Reinhold.Conjuge(new Pessoa("Sonia"));
            Pessoa Christian = new Pessoa("Christian", Reinhold);
            Pessoa Gabrielle = new Pessoa("Gabrielle", Reinhold);
            Pessoa Sabine = new Pessoa("Sabine", Reinhold);

            
            Wilma.Conjuge(new Pessoa("Rodolfo"));
            Pessoa Ricardo = new Pessoa("Ricardo", Wilma);
            Pessoa Rodrigo = new Pessoa("Rodrigo", Wilma);

            Ricardo.Conjuge(new Pessoa("Debora"));

            Christian.Conjuge(new Pessoa("Mônica"));
            Pessoa Oscar = new Pessoa("Oscar", Christian);
            Pessoa Lorena = new Pessoa("Lorena", Christian);

            Sigrid.Conjuge(new Pessoa("Peter"));
            Pessoa Martin = new Pessoa("Martin", Sigrid);
            Pessoa Thomas = new Pessoa("Thomas", Sigrid);
            Pessoa Claudia = new Pessoa("Claudia", Sigrid);
            Martin.Conjuge(new Pessoa("Carla"));
            Martin.AdicionarFilho(new Pessoa("Nicolas"));
            Lily.ImprimeArvore(0);
        }
    }
}
        }
    }
}
