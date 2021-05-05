using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool senhaCerta = false;
            do
            {
                Console.WriteLine("Digite sua nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite sua senha:");
                string senha = Console.ReadLine();

                if (senha != nome)
                {
                    Console.WriteLine("Está senha esta valida !!");
                    senhaCerta = true;
                }else{
                    Console.WriteLine("\n ERRO !!! ");
                    Console.WriteLine(" Sua senha tem que ser diferente do seu nome !! \n");
                }


                
            } while (senhaCerta == false);
        }
    }
}
