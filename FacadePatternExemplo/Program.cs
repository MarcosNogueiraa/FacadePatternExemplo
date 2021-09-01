using System;
using System.Collections.Generic;

namespace FacadePatternExemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Adocao adocao = new Adocao();
            string resultado = "";

            Cachorro cachorro = new Cachorro(
                "Fred",
                DateTime.Parse("05/04/2019"),
                false,
                new List<string>
                {
                    "Múltiplas: V8 e V10",
                    "Traqueobronquite Infecciosa Canina",
                    "Raiva"
                },
                new List<string>
                {
                    "Vermifugo"
                }
            );

            Cachorro cachorro2 = new Cachorro(
                "Dog",
                DateTime.Parse("01/11/2020"),
                false,
                new List<string>
                {
                    "Múltiplas: V8 e V10",
                    "Traqueobronquite Infecciosa Canina"
                },
                new List<string>
                {
                    "Vermifugo"
                }
            );

            resultado = adocao.IsAdotavel(cachorro) ? $"{cachorro.Nome} é adotável" : $"{cachorro.Nome} não é adotável" ;
            Console.WriteLine(resultado);

            resultado = adocao.IsAdotavel(cachorro2) ? $"{cachorro2.Nome} é adotável" : $"{cachorro2.Nome} não é adotável";
            Console.WriteLine(resultado);
        }
    }
}
