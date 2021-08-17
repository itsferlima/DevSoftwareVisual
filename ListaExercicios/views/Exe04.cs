using System;

namespace ListaExercicios.Views
{
    public class Exe04
    {
        public static void Rendezizar()
        {
            const int TAMANHO_VETOR = 100;
            const int LIMITE_NUMEORS = 1001;

            Random random= new Random();
            int [] numeros= new int[TAMANHO_VETOR];

            //Popular o vetor com numeros aleatorios
            for(int i = 0; i< TAMANHO_VETOR; i++)
            {
                numeros[i] = random.Next(LIMITE_NUMEORS);
            }

            //Imprimir valores do vetor
            foreach (int numero in numeros)
            {
                Console.WriteLine($"{numero }");
            }

            //Ordema o vetor utilizando bubble sort
            for(int i 0; i<numeros);
            





            //Array.Sort(numeros);//ordena automatica no c#
            //Imprimir os valoes do vetor ordenado

            Console.WriteLine("\n\n"); //pular linha
            foreach (int numero in numeros)
            {
                Console.WriteLine($"{ numero} ");
                
            }

        }
    }
}