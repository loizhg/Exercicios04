using System;
namespace SortingExample
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal[] valor = new decimal[10];
            decimal maiorAtual = 0;


            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine($"Digite um valor: ");
                valor[i] = Convert.ToDecimal(Console.ReadLine());

            }


            maiorAtual = ChecarMaior(maiorAtual, valor);
            Console.Write($"o maior numero é: {maiorAtual}");
            Console.Write($"\n");
            Console.Write($"\n");
            Console.Write($"\n");



            OrdenarArray(valor);

            //ARRAY SORTEADO SEM PULAR LINHA 
            foreach (int num in valor)
            {
                Console.Write("\t {0}", num);
            }




            //Console.Read();



            //ARRAY SORTEADO PULANDO LINHA
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine($" {valor[i]} ");
            }







        }


        static void Sair()
        {
            System.Environment.Exit(0);
        }



        static decimal[] OrdenarArray(decimal[] valor)
        {
            bool flag = true;
            decimal temp;
            int numLength = valor.Length;

            //sorting an array  
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (valor[j + 1] < valor[j])
                    {
                        temp = valor[j];
                        valor[j] = valor[j + 1];
                        valor[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            return valor;

            // Array.Sort(valor);
        }

        static decimal ChecarMaior(decimal maiorAtual, decimal[] valor)
        {
            int numLength = valor.Length;

            for (int i = 0; i < numLength; i++)
            {


                if (valor[i] > maiorAtual)
                {
                    maiorAtual = valor[i];
                }
            }

            return maiorAtual;
        }
    }
}