using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 2 - Criando Variaveis");

        int idade;
        idade = 20;
        
        Console.WriteLine(idade);

        idade = 10 + 10;
        Console.WriteLine(idade);

        idade = 10 + 5 * 2;
        Console.WriteLine(idade);

        idade = (10 + 5) * 2;
        Console.WriteLine("Sua idade é " + idade + "!");
    }
}