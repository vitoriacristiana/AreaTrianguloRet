using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        { 
            double b, h, area;
            Console.Beep();
            Console.Clear();
            Console.Write("Digite o valor da base:");
            b= double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura:");
            h= double.Parse(Console.ReadLine());
            area= b * h / 2;
            Console.Beep();
            Console.Write($"Área do triangulo retangulo:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(area);
            Console.ResetColor();
            }
        }
    }

