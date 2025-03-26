using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2
{
    internal class Aluno : Pessoa
    {
        public int rm;
        public string curso;
        public string periodo;

        public void mostraDados()
        {
            Console.WriteLine("\nRm:{0}\nCurso:{1}\nPeriodo:{2}",
                rm,curso,periodo);
        }

    }
}
