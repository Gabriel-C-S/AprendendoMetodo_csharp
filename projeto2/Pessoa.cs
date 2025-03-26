using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public string email;
        public string cpf;

        public void mostraNome()
        {
            Console.WriteLine("\nNome:{0}", nome);
        }
    }
}
