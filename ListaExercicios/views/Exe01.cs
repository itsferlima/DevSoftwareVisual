using System;

namespace ListaExercicios.Views
{
    public class Exe01
    {
        public static void Rendezizar()
        {
            Console.WriteLine("Qual é a área? ");
            int largura, altura, area;
            Console.WriteLine("Digite a largura");
            largura= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura");
            altura= Convert.ToInt32(Console.ReadLine());
            area = altura * largura;
            Console.WriteLine($"Area: { area }");
            
        }
    }
}