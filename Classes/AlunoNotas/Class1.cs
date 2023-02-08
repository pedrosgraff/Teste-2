using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Aluno
    {
        public string Nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double mostraNota()
        {
            return nota1 + nota2 + nota3;
        }

        public double faltaPonto()
        {
            return 60 - mostraNota();
        }

    }
}
