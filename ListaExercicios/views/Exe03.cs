using System;

namespace ListaExercicios.Views
{
    public class Exe03
    {
        public static void Rendezizar()
        {
            int numero1, numero2;
            Console.WriteLine("Digite o primeiro numero: ");
            numero1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            numero2=Convert.ToInt32(Console.ReadLine());
            
            if( numero1 > numero2 )
            {
                Console.WriteLine($"Primeiro numero lido é o maior");
            }
            else
            {
                Console.WriteLine($"Segundo numero lido é o maior");
            }
        }
    
    }
}