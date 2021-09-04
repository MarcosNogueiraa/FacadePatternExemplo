using System;

namespace FacadePatternExemplo
{
    public class Adocao
    {
        Vacinacao Vacinacao = new Vacinacao();
        Medicacao Medicacao = new Medicacao();

        public bool IsAdotavel(Cachorro cachorro)
        {          
            bool adotavel = true;

            if (!Vacinacao.VerificaVacinas(cachorro.Vacinas))
            {
                adotavel = false;
                Console.WriteLine($"A carteira de vacinas de {cachorro.Nome} está incompleta.");
            }
            else if (!Medicacao.VerificaMedicacao(cachorro.Medicamentos))
            {
                Console.WriteLine($"{cachorro.Nome} não recebeu a medicação recomendada.");

                adotavel = false;
            }
            else if (cachorro.Reservado)
            {
                Console.WriteLine($"{cachorro.Nome} está reservado.");

                adotavel = false;
            }

            return adotavel;
        }
    }
}
