// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projetoo 9 - Escopo");

        int idadeJoao = 18;
        bool acompanhado = true;
        string mensagemadicional;
        
        if (acompanhado == true)
        {
            mensagemadicional = "João está acompanhado!";
            Console.WriteLine(mensagemadicional);
        }
        else
        {
            mensagemadicional = "João NÃO está acompanhado";
            Console.WriteLine(mensagemadicional);
        }
       
        if (idadeJoao >= 18 || acompanhado == true)
        {
            Console.WriteLine("Pode entrar");
            Console.WriteLine(mensagemadicional);
        }
        else
        {
            Console.WriteLine("Nao pode entrar");
        }
            
    } 
}
