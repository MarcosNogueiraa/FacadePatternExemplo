using System;
using System.Collections.Generic;

namespace FacadePatternExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> VacinasFred = new List<string>();
            List<string> MedicamentosFred = new List<string>();

            Cachorro cachorro = new Cachorro(
                "Fred",
                DateTime.Parse("05/04/2019"),
                true,
                new List<string>{
                    "Múltiplas: V8 e V10",
                    "Traqueobronquite Infecciosa Canina" +
                    "Raiva"},
                new List<string>{
                    "Vermifugo"});

            Adocao adocao = new Adocao();
            if (adocao.IsAdotavel(cachorro))
                Console.WriteLine($"{cachorro.Nome} é adotável");
            
            else
                Console.WriteLine($"{cachorro.Nome} é adotável");



        }
    }
}
