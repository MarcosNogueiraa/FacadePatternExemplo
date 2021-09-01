using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternExemplo
{
    class Medicacao
    {
        public bool VerificaMedicacao(List<string> medicamentos)
        {

            bool retorno = true;

            if (!medicamentos.Contains("Vermifugo"))
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
