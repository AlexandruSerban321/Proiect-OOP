using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    internal class discipline
    {
        private int cod_disciplina;
        private string nume_disciplina;
        private string acronim_disciplina;
        private int nr_credite;

        public int Cod_disciplina { get { return cod_disciplina; } set { cod_disciplina = value; } }
        public string Nume_disciplina { get { return nume_disciplina; } set { nume_disciplina = value; } }
      
        public string Acronim_disciplina { get { return acronim_disciplina; } set { acronim_disciplina = value; } }
        public int Nr_credite { get { return nr_credite; } set { nr_credite = value; }  }
    }
}
