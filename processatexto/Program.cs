using System;

namespace processatexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //O nome completo

            string nome;

            Console.WriteLine("Informe seu nome completo");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Imprime o Nome: " + nome + "\n");
            Console.WriteLine("2 - Imprime o 1 Caracter: " + nome.Substring(0,1) + "\n");
            Console.WriteLine("3 - Imprime a Qtd de Caracteres: " + nome.Length + "\n");
            Console.WriteLine("4 - Imprime a ultima letra do Nome: " + nome.Substring(nome.Length -1,1) + "\n");
            Console.WriteLine("5 - Imprime ate o 3 caracter: " + nome.Substring(0,3) + "\n");
            Console.WriteLine("6 - Imprime o 4 caracter: " + nome.Substring(3,1) + "\n");
            Console.WriteLine("7 - Imprime tds os caracteres - o 1: " + nome.Substring(1) + "\n");
            Console.WriteLine("8 - Imprime os dois ultimos caracteres: " + nome.Substring(nome.Length - 2, 2) + "\n");
        }
    }
}
