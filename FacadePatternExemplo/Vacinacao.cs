using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternExemplo
{
    public class Vacinacao
    {
        public bool VerificaVacinas(List<string> vacinas) {

            bool retorno = true;

            if( !vacinas.Contains("Múltiplas: V8 e V10") ||
                !vacinas.Contains("Traqueobronquite Infecciosa Canina") ||
                !vacinas.Contains("Raiva")
            )
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
