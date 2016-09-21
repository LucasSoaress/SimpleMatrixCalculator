using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Matrix_Calculator
{
    class Program : matrix
    {
         public static Program p = new Program();

        static void Main(string[] args)
        {
            
            p.menu();
        }

        public void menu()
        {
            //Console.BufferWidth = Console.WindowWidth = 81;
            //Console.BufferHeight = Console.WindowHeight = 25;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("╒══════════════════════════════════════════════════════════════════════════════╕");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                     __   __  _______  __    _  __   __                       ║");
            Console.WriteLine("║                    |  |_|  ||       ||  |  | ||  | |  |                      ║");
            Console.WriteLine("║                    |       ||    ___||   |_| ||  | |  |                      ║");
            Console.WriteLine("║                    |       ||   |___ |       ||  |_|  |                      ║");
            Console.WriteLine("║                    |       ||    ___||  _    ||       |                      ║");
            Console.WriteLine("║                    | ||_|| ||   |___ | | |   ||       |                      ║");
            Console.WriteLine("║                    |_|   |_||_______||_|  |__||_______|                      ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                           CALCULADORA DE MATRIZES                            ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  S -> Matrix Subtraction                                                     ║");
            Console.WriteLine("║  A -> Matrix Additon                                                         ║");
            Console.WriteLine("║  X -> about program                                                          ║");
            Console.WriteLine("║  Q -> to quit                                                                ║");
            Console.WriteLine("║                                                                              ║");
            Console.Write("╘══════════════════════════════════════════════════════════════════════════════╛");
           // Console.SetCursorPosition(77, 23);
            ConsoleKey currentOption = Console.ReadKey().Key;
            Console.Clear();
            switch (currentOption)
            {
                case ConsoleKey.A:
                    matrix.matrixAddition();
                    Console.ReadKey();
                    break;
                case ConsoleKey.S:
                    matrix.matrixSubtraction();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Q:
                case ConsoleKey.Escape:
                    Environment.Exit(1);
                    break;
                case ConsoleKey.X:
                    credits();
                    Console.ReadKey();
                    break;
                default:
                    menu();
                    break;
            }
        }

        static private void credits()
        {
           // Console.BufferWidth = Console.WindowWidth = 81;
            //Console.BufferHeight = Console.WindowHeight = 25;
            Console.Clear();
            Console.WriteLine("╒══════════════════════════════════════════════════════════════════════════════╕");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  C -> calculator matrix                                                      ║");
            Console.WriteLine("║  H -> main menu                                                              ║");
            Console.WriteLine("║  Q -> to quit                                                                ║");
            Console.WriteLine("║                           CRIADO POR LUCAS SOARES                            ║");
            Console.Write("╘══════════════════════════════════════════════════════════════════════════════╛");
           // Console.SetCursorPosition(77, 23);
            ConsoleKey currentOption = Console.ReadKey().Key;
            Console.Clear();
            switch (currentOption)
            {
                case ConsoleKey.Q:
                case ConsoleKey.Escape:
                    Environment.Exit(1);
                    break;
                case ConsoleKey.C:
                    matrix.matrixAddition();
                    break;
                case ConsoleKey.H:
                    p.menu();
                    break;
            }
        }
    }
}
