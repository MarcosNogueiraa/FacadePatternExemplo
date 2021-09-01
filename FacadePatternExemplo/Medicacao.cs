using System.Collections.Generic;

namespace FacadePatternExemplo
{
    public class Medicacao
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
