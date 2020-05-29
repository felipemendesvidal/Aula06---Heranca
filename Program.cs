using System;

namespace quartoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF teste = new CPF();
            teste.cpf = " vazio ";
            teste.nome = "exemplo";
            Console.WriteLine(teste.Saudacao());
            
        }
    }
}
