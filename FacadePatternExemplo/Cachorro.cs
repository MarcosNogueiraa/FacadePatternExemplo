using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternExemplo
{
    class Cachorro
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Reservado { get; set; }

        public List<string> Vacinas { get; set; }
        public List<string> Medicamentos { get; set; }

        public Cachorro(string nome, DateTime dataNascimento, bool reservado, List<string> vacinas, List<string> medicamentos)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Reservado = reservado;
            Vacinas = vacinas;
            Medicamentos = medicamentos;
        }



        public Cachorro()
        {
        }
    }
}
