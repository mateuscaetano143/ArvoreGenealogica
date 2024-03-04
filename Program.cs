using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ArvoreGenealogica
{
    using System;

    class Program
    {
        static void Main()
        {
            Pessoa Lilly = new Pessoa("Lilly");
            Pessoa Wilhelm = new Pessoa("Wilhelm");
            Pessoa Opa = new Pessoa("Opa");
            Pessoa Oma = new Pessoa("Oma");
            Lilly.Conjugue(Wilhelm);
            Opa.Conjugue(Oma);
            Lilly.AdicionarFilho(Opa);

            Pessoa Reinhold = new Pessoa("Reinhold");
            Pessoa Sonia = new Pessoa("Sonia");
            Reinhold.Conjugue(Sonia);

            Pessoa Christian = new Pessoa("Christian");
            Pessoa Monica = new Pessoa("Mônica");
            Christian.Conjugue(Monica);

            Pessoa Oscar = new Pessoa("Oscar");
            Pessoa Lorena = new Pessoa("Lorena");
            Pessoa Gabrielle = new Pessoa("Gabrielle");
            Christian.AdicionarFilho(Oscar);
            Christian.AdicionarFilho(Lorena);
            Christian.AdicionarFilho(Gabrielle);
            Reinhold.AdicionarFilho(Christian);

            Pessoa Sabine = new Pessoa("Sabine");
            Christian.AdicionarFilho(Sabine);

            Pessoa Wilma = new Pessoa("Wilma");
            Pessoa Rodolfo = new Pessoa("Rodolfo");
            Wilma.Conjugue(Rodolfo);

            Pessoa Ricardo = new Pessoa("Ricardo");
            Pessoa Debora = new Pessoa("Debora");
            Ricardo.Conjugue(Debora);
            Wilma.AdicionarFilho(Ricardo);

            Pessoa Rodrigo = new Pessoa("Rodrigo");
            Ricardo.AdicionarFilho(Rodrigo);

            Pessoa Sigrid = new Pessoa("Sigrid");
            Pessoa Peter = new Pessoa("Peter");
            Sigrid.Conjugue(Peter);

            Pessoa Martin = new Pessoa("Martin");
            Pessoa Carla = new Pessoa("Carla");
            Martin.Conjugue(Carla);

            Pessoa Nicolas = new Pessoa("Nicolas");
            Pessoa Thomas = new Pessoa("Thomas");
            Martin.AdicionarFilho(Nicolas);
            

            Pessoa Claudia = new Pessoa("Claudia");
            Sigrid.AdicionarFilho(Claudia);

            Sigrid.AdicionarFilho(Martin);
            Sigrid.AdicionarFilho(Thomas);

            Opa.AdicionarFilho(Reinhold);
            Opa.AdicionarFilho(Wilma);
            Opa.AdicionarFilho(Sigrid);

            Console.WriteLine("Árvore Genealógica:");
            Lilly.ImprimeArvore();

            Console.ReadKey();
        }
    }
}













