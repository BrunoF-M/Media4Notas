using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double not1;
            double not2;
            double not3;
            double not4;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n+=-= Média =-=+\n");
            Console.ResetColor();

            Console.WriteLine("Digite as suas notas abaixo.");

            Console.Write("Nota 1: ");
            not1 = double.Parse(Console.ReadLine());
            
            Console.Write("Nota 2: ");
            not2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            not3 = double.Parse(Console.ReadLine());

            Console.Write("Nota 4: ");
            not4 = double.Parse(Console.ReadLine());

            if (not1 < 0 || not1 > 10)
            {
                Console.WriteLine("\nDigite somente notas entre 0 e 10.\n");
                Environment.Exit(-1);
            }
            if (not2 < 0 || not2 > 10)
            {
                Console.WriteLine("\nDigite somente notas entre 0 e 10.\n");
                Environment.Exit(-1);
            }
            if (not3 < 0 || not3 > 10)
            {
                Console.WriteLine("\nDigite somente notas entre 0 e 10.\n");
                Environment.Exit(-1);
            }
            if (not4 < 0 || not4 > 10)
            {
                Console.WriteLine("\nDigite somente notas entre 0 e 10.\n");
                Environment.Exit(-1);
            }
            double result;
            double resultfinal;
            
            result = (not1 + not2 + not3 + not4);
            resultfinal = (result /4);


            if (resultfinal >= 5 || resultfinal >= 6 )
            {
                Console.WriteLine($"\nVocê ficou com média {resultfinal} Resultado: Em recuperação");
            }
            if (resultfinal > 4 )
            {
                Console.WriteLine($"\nVocê ficou com média {resultfinal} Resultado: Reprovado");
            }
            if (resultfinal < 6 )
            {
                Console.WriteLine($"\nVocê ficou com média {resultfinal} Resultado: Aprovado");
            }

            Console.WriteLine();
            Console.Write("Orbigado por usar e até o ano que vem ;)... ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}