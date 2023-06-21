// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13");
        
        // *
        // **
        // ***
        // ****
        // *****
        // ******
        // *******
        // ********
        
        // Escrevendo asteriscos com o BREAK
        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinha)
                    break;
            }
            Console.WriteLine();
        }    
        
        
        // Uma forma diferente de fazer os desenhos de asteriscos
        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna <=  contadorLinha; contadorColuna++)
            
                Console.Write("*");
            
            Console.WriteLine();
        }    


    }
}