using System;
using System.Threading;

namespace exercicioExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");
            int numero ;
            int numeroAnterior  = 0;
            int numeroAtual  = 1 ;

            for (int i = 0; i < 16; i++)
            {
                numero = numeroAnterior + numeroAtual ;
                numeroAnterior = numeroAtual ;
                numeroAtual = numero ;


                Console.WriteLine(numeroAnterior);
                Thread.Sleep(300);
                
            }
        }
    }
}
