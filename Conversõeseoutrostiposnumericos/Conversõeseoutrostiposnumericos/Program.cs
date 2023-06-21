// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 4 ");

        double salario = 1200.50;

        //O int é uma variável que suporta valores ate 32 bits
        int salarioEmInteiro = (int)salario;
        
        Console.WriteLine(salarioEmInteiro);
        
        // O long é uma variável de 64 bits
        long idade = 130000000000000;
        Console.WriteLine(idade);
        
        // O short é um tipo de variável de 16 bits
        short quantidadedeProdutos = 15000;
        Console.WriteLine(quantidadedeProdutos);

        float altura = 1.80f;
        Console.WriteLine(altura);






    }
}