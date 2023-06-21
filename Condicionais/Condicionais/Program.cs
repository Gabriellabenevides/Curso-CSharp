// See https://aka.ms/new-console-template for more information

using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projetoo 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;
        
        if (idadeJoao >= 18)
        {
            Console.WriteLine("Joao possui mais de 18 anos de idade, pode entrar. Pode entrar");
        }
        else
        { 
            if (quantidadePessoas >= 2)
            { 
                Console.WriteLine("Joao nao possui mais de 18 anos, mas esta acompanhado");
            }
            else
            { 
                Console.WriteLine("Joao nao possui mais de 18 anos, nao pode entrar");
            }
            
        } 
    }
}