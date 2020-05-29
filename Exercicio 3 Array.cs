using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_sobre_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 3

            string[] alunos = new string[3];//define a quantidade da lista
            double[] notas = new double[alunos.Length];
            double mediasala;

            Console.WriteLine("Cadastro de Alunos/Notas" + "\n");

            //solicita o nome dos alunos e as notas
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine("Insira o nome do aluno {0}", i+1);
                alunos[i] = Console.ReadLine();
                Console.WriteLine("insira a nota:");
                notas[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nLista Anulos \n");
            
            Array.Sort(alunos, notas);  // Organiza alunos e nota por ordem

            //imprime o nome dos alunos e as notas
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine("Aluno: {0}   Nota: {1}", alunos[i], notas[i]);

            }

            //calcular a média

            double somanotas = 0;
            for (int i = 0; i < alunos.Length; i++)
            {
                somanotas = somanotas + notas[i];
            }
            mediasala = somanotas / alunos.Length;

            //imprime media da sala

            Console.WriteLine("\nA média da sala é {0:0.00}", mediasala);


            Console.ReadKey();

        }
    }
}
