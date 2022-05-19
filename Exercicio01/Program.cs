using System;
namespace Luiz
{

    public class Program
    {
        public static void Main()
        {
            decimal numeroA;
            decimal numeroB;


            int opcao = 0;

            Console.WriteLine("Digite o valor de A: ");
            numeroA = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            numeroB = Convert.ToDecimal(Console.ReadLine());





            do
            {
                Console.WriteLine("Escolha uma opção de calculo: ");
                Console.WriteLine("\t 0 - Somar");
                Console.WriteLine("\t 1 - Subtrair");
                Console.WriteLine("\t 2 - Multiplicar");
                Console.WriteLine("\t 3 - Dividir");
                Console.WriteLine("\t 4 - Sair");
                Console.Write("Sua opção? ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine($"Opção selecionada SOMA");
                        SomarNumeros(numeroA, numeroB);
                        break;
                    case 1:
                        Console.WriteLine($"Opção selecionada SUBTRAÇÃO");
                        SubtrairNumeros(numeroA, numeroB);
                        break;
                    case 2:
                        Console.WriteLine($"Opção selecionada MULTIPLICAÇÃO");
                        MultiplicarNumeros(numeroA, numeroB);
                        break;
                    case 3:
                        Console.WriteLine($"Opção selecionada DIVISÃO");
                        DividirNumeros(numeroA, numeroB);
                        break;
                    case 4:
                        Console.WriteLine($"Opção selecionada SAIR");
                        Sair();
                        break;
                }
            }
            while (opcao != 4);
            //checar se a opção foi para dar exit           





        }


        static void Sair()
        {
            System.Environment.Exit(0);
        }



        static void SomarNumeros(decimal n1, decimal n2)
        {
            decimal res = n1 + n2;
            Console.WriteLine("A Soma é " + res);
        }

        static void SubtrairNumeros(decimal n1, decimal n2)
        {
            decimal res = n1 - n2;
            Console.WriteLine("A Subtração é " + res);
        }


        static void MultiplicarNumeros(decimal n1, decimal n2)
        {
            decimal res = n1 - n2;
            Console.WriteLine("A Multiplicação é " + res);
        }

        static void DividirNumeros(decimal n1, decimal n2)
        {
            decimal res = n1 / n2;
            Console.WriteLine("A Divisão é " + res);
        }






    }
}

