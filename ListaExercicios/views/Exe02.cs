using System;

namespace ListaExercicios.Views
{
    public class Exe02
    {
        public static void Rendezizar()
        {
            double real, dolar, euro, pesoArgentino;
            Console.WriteLine("Digite o valoR em R$: ");
            real= Convert.ToDouble(Console.ReadLine());
            
            dolar = real/5.17; // valor atual do dolar 
            euro = real/6.14;
            pesoArgentino= real/0.04;

            Console.WriteLine($"Dolar: {dolar.ToString("F2")}"); // Usa f2 para q apareça apenas 2 digitos, casa decimais 
            Console.WriteLine($"Euro: {euro.ToString("F2")}");
            Console.WriteLine($"Peso Argentino: {pesoArgentino.ToString("F2")}");
        }
    }
}