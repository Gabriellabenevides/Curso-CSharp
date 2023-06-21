// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e textos");
        
        // character
        char primeiraLetra = ' ';
        Console.WriteLine(primeiraLetra);

        primeiraLetra = (char)61;
        Console.WriteLine(primeiraLetra);

        primeiraLetra = (char)(primeiraLetra + 1);
        Console.WriteLine(primeiraLetra);

        //@ para quebrar linha
        string titulo = "Alura Cursos de tecnologia " + 2020;
        string cursosProgramacao = 
@" -.NET 
 -Java
 -Javascript";
            
        Console.WriteLine(titulo);
        Console.WriteLine(cursosProgramacao);
        
        

    }
}
