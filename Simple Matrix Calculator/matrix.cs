using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Matrix_Calculator
{
    class matrix
    {
        public static void matrixAddition()
        {
            titulo("Soma de Matrizes aperte [ H ] -> Menu Principal | [ Q ] -> Fechar", "Digite o número de linhas e colunas");
            //escolha();
            try
            {
                int m, n, i, j;
                m = Convert.ToInt32(Console.ReadLine());
                n = Convert.ToInt32(Console.ReadLine());
                int[,] A = new int[m, n];

                Console.WriteLine("Enter the First Matrix : ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        A[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("First Matrix : ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(A[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                int[,] B = new int[m, n];

                Console.WriteLine("");
                Console.WriteLine("Enter the Second Matrix : ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        B[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Second Matrix : ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(B[i, j] + "\t");
                    }
                    Console.WriteLine("");
                }
                int[,] C = new int[m, n];

                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Matrix Addition :");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(C[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("");
                esperar();
            }

            catch(Exception)
            {
                error();
            }

        }

        public static void matrixSubtraction()
        {
            try
            {
                int m, n, i, j;

                Console.WriteLine("The Matrix Subtraction");
                Console.WriteLine("");
                Console.WriteLine("Enter number of rows and columns of the matrix: ");

                m = Convert.ToInt32(Console.ReadLine());
                n = Convert.ToInt32(Console.ReadLine());

                int[,] A = new int[m, n];

                Console.Clear();
                Console.WriteLine("Enter the First Matrix: ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        A[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                int[,] B = new int[m, n];

                Console.WriteLine("Enter The Second Matrix: ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        B[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.Clear();
                Console.WriteLine("First Matrix: ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(A[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("");
                Console.WriteLine("Second Matrix: ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(B[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                int[,] C = new int[m, n];

                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        C[i, j] = A[i, j] - B[i, j];
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Matrix Subtraction:");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(C[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("");
                esperar();
            }
            catch(Exception)
            {
                error();
            }
        }

        private static void esperar()
        {
            Console.WriteLine("Aperter X para fechar ou N para calcular uma nova matriz");
            ConsoleKey currentOption = Console.ReadKey().Key;
            switch (currentOption)
            {
                case ConsoleKey.X:
                    Environment.Exit(1);
                    break;
                case ConsoleKey.N:
                    matrixSubtraction();
                    break;
                default:
                    Console.Clear();
                    esperar();
                    break;
            }
        }

        private static void titulo(String primeiroTitulo, String segundoTitulo)
        {
            Console.WriteLine("\n" +primeiroTitulo + "\n" + "" + "\n" + segundoTitulo + "\n");
        }

        private static void error()
        {
            Console.Clear();
            titulo("Ocorreu um erro na sua calculadora", "Aperte H -> Menu Principal ou Q -> Fechar");
            escolha();
        }

        private static void escolha()
        {
            ConsoleKey currentOption = Console.ReadKey().Key;
            Program p = new Program();
            switch (currentOption)
            {
                case ConsoleKey.Q:
                    Environment.Exit(1);
                    break;
                case ConsoleKey.H:
                    p.menu();
                    break;
            }
        }

    }
}
