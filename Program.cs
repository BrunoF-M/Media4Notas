using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string not1;
            Int32 note1;
            bool nota1;

            int not2;
            double note2;
            bool nota2;

            string not3;
            int note3;
            bool nota3;

            string not4;
            int note4;
            bool nota4;

            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.WriteLine("+=+=+ Media +=+=+\n");
            Console.ResetColor();

            Console.WriteLine("Digite suas notas abaixo.\n");
            
            Console.Write("Nota 1: ");
            not1 = Console.ReadLine();

            nota1 = Int32.TryParse(not1, out note1);

            Console.Write("Nota 2: ");
            not2 = Int32.Parse(Console.ReadLine());

            nota2 = double.TryParse(not2, out note2);

            Console.Write("Nota 3: ");
            not3 = Console.ReadLine();

            nota3 = Int32.TryParse(not3, out note3);

            Console.Write("Nota 4: ");
            not4 = Console.ReadLine(); 
           
            nota4 = Int32.TryParse(not4, out note4);


            if(!nota1) //se for negativo faz o 1 bloco se for positivo faz o 2 bloco
            {
                Console.WriteLine("\nDigite somente notas entre 0 e 10.");
                Environment.Exit(-1);
            }
            else
            {
                if(!nota2)
                {
                    Console.WriteLine("\nDigite somente notas entre 0 e 10.");
                    Environment.Exit(-1);

                }
                else
                {
                    if(!nota3)
                    {
                    Console.WriteLine("\nDigite somente notas entre 0 e 10.");
                    Environment.Exit(-1);
                    }
                    else
                    {
                        if(!nota4)
                        {
                            Console.WriteLine("\nDigite somente notas entre 0 e 10.");
                            Environment.Exit(-1);
                        }
                        else
                        {
                           decimal resultado = (note1 + note2 + note3 + note4 /7);

                           Console.WriteLine($"seu resultado é {resultado}.");
                        }
                    }
                }
            }
        }
    }
}