using System;
using projeto2;

namespace Metodo
{
    internal class program
    {
        static void Main(string[] arg) //Método
        {
        Pessoa aluno = new Pessoa();
        Pessoa aluno1 = new Pessoa();
        aluno.nome = "Josue Correa Pinto Lopes Junior Filho Neto";
        aluno1.nome = "Firmino Silva Menezes Santos da Costa";
        aluno.peso = 90;
        aluno1.peso = 85;

        Console.WriteLine("Aluno {0}", aluno.nome);
        //Console.WriteLine("Aluno {3}", aluno1.nome);
        }
    }
};