using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string nome = "";
            bool correta1 = false;
            do
            {
                Console.WriteLine("Qual seu nome?");
                nome = Console.ReadLine().ToLower();
                

                if (nome == "")
                {
                    Console.WriteLine("Campo obrigatorio");
                }else{
                    Console.WriteLine("Que belo nome!");
                    correta1 = true;
                }
                
            } while (correta1 == false);
                
            
                
                
            int idade ;
            bool correta2 = false;
            do
            {
                Console.WriteLine("Qual sua idade?");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 0 && idade <=150)
                {
                    Console.WriteLine("Pensava que vc era mais novo");
                    correta2 = true;
                }else{
                    Console.WriteLine("Parabens,você esta na beira da morte!!");
                }
                
            } while (correta2 == false);


            string salario = "";
            bool correta3 = false;
            do
            {
                Console.WriteLine("Qual o valor do seu salario?");
                salario = Console.ReadLine();

                if (salario == "")
                {
                    salario = "0";
                }
                
                float salario1 = float.Parse(salario);

                if (salario1 > 0)
                {
                    
                    correta3 = true;
                }else{
                    Console.WriteLine("Salario Invalido! Tente novamente!");
                }
                
            } while (correta3 == false);



            string estadoCivil = "";
            bool correta4 = false;
            do
            {
                Console.WriteLine("Digite seu estado civil ('s'(solteiro(a)); ('c'(casado(a)); ('v'(viuvo(a));('d'(divorciado(a)) ");
                estadoCivil = Console.ReadLine().ToLower();

                if (estadoCivil == "s" || estadoCivil == "c" || estadoCivil == "v" || estadoCivil == "d")
                {
                    Console.WriteLine("informação valida!!");
                    correta4 = true;
                }else{
                    Console.WriteLine("informação invalida!!");
                }
                
            } while (correta4 == false);
            
            Console.WriteLine("Os valores atribuidos foram:");
            Console.WriteLine("Seu nome: " + nome);
            Console.WriteLine("Sua idade: " + idade + " anos");
            Console.WriteLine("Seu Salario: " + "R$"  +salario);
            Console.WriteLine("Estado Civil: " + estadoCivil );

            
           
           
           

           
           
        }
    }
}
