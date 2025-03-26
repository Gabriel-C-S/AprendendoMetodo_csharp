using System;
using projeto2;

namespace Metodo
{
    internal class program
    {
        static void Main(string[] arg) //Método
        {
            Pessoa p1 = new Pessoa();
            Aluno a1 = new Aluno();
            Professor pf1 = new Professor();
            a1.nome = "Huguinho";
            pf1.nome = "Tio Patinhas";
            pf1.mostraNome();
            a1.rm = 999;
            a1.curso = "Ciência da Computação";
            a1.periodo = "Noturno";
            a1.mostraNome();
            a1.mostraDados();
        }
    }
}

