using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1");

            int Num1_1 = 124;
            int Num1_2 = 51;

            Console.WriteLine("Fark: " + Num1_1 + " - " + Num1_2 + " = " + (Num1_1 - Num1_2));

            Console.WriteLine("");
            Console.WriteLine("#2");

            int Num2_1 = 5;

            Console.WriteLine("Kare: " + Num2_1 + " ^ 2 = " + (Num2_1 * Num2_1));

            Console.WriteLine("");
            Console.WriteLine("#3");

            int Num3_1 = 10;

            Console.WriteLine("Kalan: " + Num3_1 + " % 3 = " + Num3_1 % 3);

            Console.WriteLine("");
            Console.WriteLine("#4");

            Console.WriteLine("Sayı 1");
            double Num4_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayı 2");
            double Num4_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayı 3");
            double Num4_3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayı 4");
            double Num4_4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Toplam: " + Num4_1 + " + " + Num4_2 + " + " + Num4_3 + " + " + Num4_4 + " = " + (Num4_1 + Num4_2 + Num4_3 + Num4_4));
            Console.WriteLine("Çarpım: " + Num4_1 + " * " + Num4_2 + " * " + Num4_3 + " * " + Num4_4 + " = " + (Num4_1 * Num4_2 * Num4_3 * Num4_4));

            Console.WriteLine("");
            Console.WriteLine("#5");

            Console.WriteLine("Bölünen Sayı");
            double Num5_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bölen Sayı");
            double Num5_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bölüm: " + Num5_1 + " / " + Num5_2 + " = " + (Num5_1 / Num5_2));

            Console.WriteLine("");
            Console.WriteLine("#6");

            Console.WriteLine("Uzunluk");
            double Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yükseklik");
            double Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Genişlik");
            double Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hacim: " + Length + " * " + Height + " * " + Width + " = " + (Length * Height * Width));
        }
    }
}
