using System;
using System.Collections;
namespace SortingExample
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] alunos = new string[10];
            alunos[0] = "Luiz";
            alunos[1] = "Tales";
            alunos[2] = "Collato";
            alunos[3] = "Yuske";
            alunos[4] = "Palu";
            alunos[5] = "Cris";
            alunos[6] = "Jhony";
            alunos[7] = "Naruto";
            alunos[8] = "Rock Lee";
            alunos[9] = "Sasuke";


            decimal[] notasA = new decimal[10];
            notasA[0] = 100;
            notasA[1] = 60;
            notasA[2] = 60;
            notasA[3] = 70;
            notasA[4] = 60;
            notasA[5] = 60;
            notasA[6] = 30;
            notasA[7] = 60;
            notasA[8] = 60;
            notasA[9] = 10;

            decimal[] notasB = new decimal[10];
            notasB[0] = 100;
            notasB[1] = 60;
            notasB[2] = 60;
            notasB[3] = 10;
            notasB[4] = 60;
            notasB[5] = 60;
            notasB[6] = 05;
            notasB[7] = 60;
            notasB[8] = 60;
            notasB[9] = 60;

            decimal[] notasC = new decimal[10];
            notasC[0] = 50;
            notasC[1] = 30;
            notasC[2] = 60;
            notasC[3] = 60;
            notasC[4] = 60;
            notasC[5] = 100;
            notasC[6] = 20;
            notasC[7] = 60;
            notasC[8] = 60;
            notasC[9] = 100;

            decimal[] media = new decimal[10];


            bool[] passou = new bool[10];
            passou[0] = false;
            passou[1] = false;
            passou[2] = false;
            passou[3] = false;
            passou[4] = false;
            passou[5] = false;
            passou[6] = false;
            passou[7] = false;
            passou[8] = false;
            passou[9] = false;




            ChecarMedia(media, notasA, notasB, notasC, alunos, passou);



        }


        static void Sair()
        {
            System.Environment.Exit(0);
        }

        static decimal[] ChecarMedia(decimal[] media, decimal[] notasA, decimal[] notasB, decimal[] notasC, string[] alunos, bool[] passou)
        {
            for (int i = 0; i < media.Length; i++)
            {
                media[i] = (notasA[i] + notasB[i] + notasC[i]) / 3;

                Console.WriteLine($"A média do aluno {alunos[i]} é: ");

                //tostring em c# para formatar duas casas decimais
                Console.WriteLine($"{media[i].ToString("F")}");

                passou[i] = Passou(passou[i], media[i]);

                Console.WriteLine($"{passou[i]}");

                if (passou[i])
                {
                    Console.WriteLine($"O aluno atingiu nota suficiente para passar!");
                }
                else
                {
                    Console.WriteLine($"O aluno reprovou!");
                }



            }

            return media;
        }

        static bool Passou(bool passou, decimal media)
        {
            decimal notaMinima = 70;


            decimal mediaTeste = Convert.ToDecimal(media);

            if (mediaTeste > notaMinima)
            {
                passou = true;
            }
            else
            {
                passou = false;
            }


            return passou;
        }














    }
}