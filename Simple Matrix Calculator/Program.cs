using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Matrix_Calculator
{
    class Program : matrix
    {
        /// <summary>
        /// Instanciando a própria classe para se usar os métodos 
        /// </summary>
         public static Program p = new Program();

        /// <summary>
        /// Chama o método do menu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            p.menu();
        }

        /// <summary>
        /// Desenha o menu no console
        /// </summary>
        public void menu()
        {
            Console.BufferWidth = Console.WindowWidth = 81;
            Console.BufferHeight = Console.WindowHeight = 25;
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
            Console.WriteLine("║  X -> About program                                                          ║");
            Console.WriteLine("║  Q -> Quit                                                                   ║");
            Console.WriteLine("║                                                                              ║");
            Console.Write("╘══════════════════════════════════════════════════════════════════════════════╛");
            Console.SetCursorPosition(77, 23);
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

        /// <summary>
        /// Desenha tela de créditos no console
        /// </summary>
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
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  H -> Main Menu                                                              ║");
            Console.WriteLine("║  Q -> Quit                                                                   ║");
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
