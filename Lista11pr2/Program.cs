using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11PR2
{
    internal class Program
    {
        public static void Exercício1()
        {




            int num;

            Console.WriteLine("Escolha um exercicio: ");

            Console.WriteLine("====MENU====");
            Console.WriteLine("1 exercicio ");
            Console.WriteLine("2 exercicio ");
            Console.WriteLine("3 exercicio ");
            Console.WriteLine("4 exercicio ");
            Console.WriteLine("============");

            num = int.Parse(Console.ReadLine());
            
            
            case 1:
            
            int[] vet = new int[1000];
            int numAd;
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                vet[i] = rand.Next(100, 3000);
            }
            for (int i = 0; i < 1000; i++)
            {
                do
                {
                    Console.WriteLine("Digite um número: ");
                    numAd = int.Parse(Console.ReadLine());
                } while (numAd != vet[i]);
            }
        }

        case 2://não consegui fazer:0
        
        case 3:
        {
            int[] vet = new int[10];
            int i, num;
            float[] vet1 = new float[10];

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a posição[{0}]: ");
                num = int.Parse(Console.ReadLine());
                vet[i] = num;
            }
            for (i = 0; i < 10; i++)
            {
                if (vet1[i] % 2 == 0)
                    vet1[i] = vet[i] / 2;
                else
                    vet1[i] = vet[i] * 3;
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Posição[{0}] = {1}", i, vet[i]);
            }
        }
        case 4:
        {
            int[] vet = new int[5000];
            int i;
            Random rand = new Random();

            for (i = 0; i < 5000; i++)
            {
                vet[i] = rand.Next(100, 7000);
            }
            for (i = 0; i < 5000; i++)
            {
                if (vet[i] % vet[i] == 0)
                    Console.WriteLine("Posição[{0}] = {1}", i, vet[i]);
            }
        }
       
        {
    case 5:
            int op;

            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1- Exercício 1: Adivinhar entre 1000 números inteiros");
            Console.WriteLine("2- Exercício 2: Aparece quantas vezes em 20000");
            Console.WriteLine("3- Exercício 3: 10 elementos mais 2 vetores");
            Console.WriteLine("4- Exercício 4: Primos entre 5000");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Exercício1();
                    break;
                case 2:
                    Exercício2();
                    break;
                case 3:
                    Exercício3();
                    break;
                case 4:
                    Exercício4();
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
