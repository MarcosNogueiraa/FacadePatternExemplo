using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternExemplo
{
    class Adocao
    {
        Vacinacao vacinacao = new Vacinacao();
        Medicacao medicacao= new Medicacao();
        public bool IsAdotavel(Cachorro cachorro)
        {          
            bool adotavel = true;
            // Check creditworthyness of applicant
            if (!vacinacao.VerificaVacinas(cachorro.Vacinas))
            {
                adotavel = false;
                Console.WriteLine($"A carteira de vacinas de {cachorro.Nome} está incompleta.");
            }
            else if (!medicacao.VerificaMedicacao(cachorro.Medicamentos))
            {
                adotavel = false;
                Console.WriteLine($"{cachorro.Nome} não recebeu a medicação recomendada.");

            }
            else if (cachorro.Reservado)
            {
                adotavel = false;
                Console.WriteLine($"{cachorro.Nome} está reservado.");

            }
            return adotavel;
        }
    }
}
