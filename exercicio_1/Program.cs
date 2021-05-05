using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {


             bool respostaCorreta = false;
            while (respostaCorreta == false)
            {
                Console.WriteLine("Digite um numero de 0 a 10: ");
                int resposta = int.Parse(Console.ReadLine()) ;

                if (resposta >= 0 && resposta <= 10)
                {
                    Console.WriteLine("Este valor é valido!!");
                    respostaCorreta = true;
                }else {
                    Console.WriteLine("Este valor não é valido!");
                }
            }    

            
            //     bool resposta =false;
            // do
            // {
            //     Console.WriteLine("Digite um numero de 0 a 10: ");
            //     int numero = int.Parse(Console.ReadLine());

            //     if (numero >= 0 && numero <= 10)
            //     {
                    
            //         Console.WriteLine("Este valor é valido!!");
            //         resposta = true;

            //     }else{
                    
            //         Console.WriteLine("Este valor não é valido!");
            //     }

            // } while (resposta = false);
        }
    }
}
