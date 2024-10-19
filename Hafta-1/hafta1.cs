Console.WriteLine("#1 Fark");
Console.WriteLine("-------");

int Num1_1 = 124;
int Num1_2 = 51;

Console.WriteLine(Num1_1 + " - " + Num1_2 + " = " + (Num1_1 - Num1_2));

Console.WriteLine("");
Console.WriteLine("#2 Kare");
Console.WriteLine("-------");

int Num2_1 = 5;

Console.WriteLine(Num2_1 + " ^ 2 = " + Math.Pow(Num2_1, 2));

Console.WriteLine("");
Console.WriteLine("#3 Kalan");
Console.WriteLine("--------");

int Num3_1 = 10;

Console.WriteLine(Num3_1 + " % 3 = " + Num3_1 % 3);

Console.WriteLine("");
Console.WriteLine("#4 Toplam ve Çarpım");
Console.WriteLine("-------------------");

Console.Write("Sayı 1 Giriniz: ");
double Num4_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Sayı 2 Giriniz: ");
double Num4_2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Sayı 3 Giriniz: ");
double Num4_3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Sayı 4 Giriniz: ");
double Num4_4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine(Num4_1 + " + " + Num4_2 + " + " + Num4_3 + " + " + Num4_4 + " = " + (Num4_1 + Num4_2 + Num4_3 + Num4_4));
Console.WriteLine(Num4_1 + " * " + Num4_2 + " * " + Num4_3 + " * " + Num4_4 + " = " + (Num4_1 * Num4_2 * Num4_3 * Num4_4));

Console.WriteLine("");
Console.WriteLine("#5 Bölüm");
Console.WriteLine("--------");

Console.Write("Bölünen Sayı: ");
double Num5_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Bölen Sayı: ");
double Num5_2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Num5_1 + " / " + Num5_2 + " = " + (Num5_1 / Num5_2));

Console.WriteLine("");
Console.WriteLine("#6 Dikdörtgen Prizma Hacmi");
Console.WriteLine("--------------------------");

Console.Write("Uzunluk: ");
double Length = Convert.ToDouble(Console.ReadLine());
Console.Write("Yükseklik: ");
double Height = Convert.ToDouble(Console.ReadLine());
Console.Write("Genişlik: ");
double Width = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Length + " * " + Height + " * " + Width + " = " + (Length * Height * Width));
