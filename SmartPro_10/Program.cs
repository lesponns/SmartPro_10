#region Using Libraries
using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace SmartPro_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String CP;
            Console.WriteLine("Select Calculation");
            Console.WriteLine("Pow, Sqrt, Abs, Floor, Ceiling, Max, Min, \n" +
                "Sin, Asin, Cos, Acos, Tan, Atan, PI, E");
            Console.Write("=> ");
            CP = Console.ReadLine();

            if (CP=="Pow"||CP=="Sqrt"||CP=="Abs"||CP=="Floor"||CP=="Ceiling"||CP=="Max"||CP=="Min"|CP=="Sin"||
                CP=="Asin"||CP=="Cos"||CP=="Acos"||CP=="Tan"||CP=="Atan"||CP=="PI"||CP=="E")
            {
                if (CP == "Pow")
                { 
                Console.Clear();
                Console.Write("Taban değerini giriniz: ");
                double taban = double.Parse(Console.ReadLine());
                
                Console.Clear();
                Console.Write("Üssü değerini giriniz: ");
                double ussu = double.Parse(Console.ReadLine());
                
                Console.Clear();
                Console.WriteLine(Math.Pow(taban,ussu));
                }
                else if (CP == "Sqrt")
                {
                    Console.Clear();
                    Console.Write("Karekök alınması istenen değer: ");
                    double sqrt = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Sqrt(sqrt));
                }
                else if (CP == "Abs")
                {
                    Console.Clear();
                    Console.Write("Mutlak istenen değer: ");
                    double abs = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Abs(abs));
                }
                else if (CP == "Floor")
                {
                    Console.Clear();
                    Console.Write("Alt basamağa yuvarlanacak sayı: ");
                    double floor = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Floor(floor));
                }
                else if (CP == "Ceiling")
                {
                    Console.Clear();
                    Console.Write("Üst basamağa yuvarlanacak sayı: ");
                    double ceiling = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Ceiling(ceiling));
                }
                else if (CP == "Max")
                {
                    Console.Clear();
                    Console.Write("Büyük olanı bulmak için sayı giriniz: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.Write("Büyük olanı bulmak için sayı giriniz: ");
                    double num2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Max(num1,num2));
                }
                else if (CP == "Min")
                {
                    Console.Clear();
                    Console.Write("Küçük olanı bulmak için sayı giriniz: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.Write("Küçük olanı bulmak için sayı giriniz: ");
                    double num2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Min(num1,num2));
                }
                else if (CP == "Sin")
                {
                    Console.Clear();
                    Console.Write("Sinüsü hesaplanacak değer: ");
                    double sin = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Sin(sin));
                }
                else if (CP == "Asin")
                {
                    Console.Clear();
                    Console.Write("Radyan cinsinden istenen Sinüs değeri: ");
                    double asin = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Asin(asin));
                }
                else if (CP == "Cos")
                {
                    Console.Clear();
                    Console.Write("Radyan türündeki değerin kosinüsü: ");
                    double cos = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Cos(cos));
                }
                else if (CP == "Acos")
                {
                    Console.Clear();
                    Console.Write("Kosinüs türündeki değerin Radyanı: ");
                    double acos = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Acos(acos));
                }
                else if (CP == "Tan")
                {
                    Console.Clear();
                    Console.Write("Radyan cinsinden değerin tanjant karşılığı: ");
                    double tan = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Tan(tan));
                }
                else if (CP == "Atan")
                {
                    Console.Clear();
                    Console.Write("Radyan cinsindeki değer: ");
                    double atan = double.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Atan(atan));
                }
                else if (CP == "PI")
                {
                    Console.Clear();
                    Console.Write("PI değeri: ");

                    Console.WriteLine(Math.PI);
                }
                else if (CP == "Ceiling")
                {
                    Console.Clear();
                    Console.Write("E değeri: ");

                    Console.WriteLine(Math.E);
                }
            }
            else { Console.WriteLine("Wrong way!"); }


            Console.ReadKey();
            /*
            Console.WriteLine(Math.Pow(5,4));           -
            Console.WriteLine(Math.Sqrt(64));           -
            Console.WriteLine(Math.Abs(-12));           -
            Console.WriteLine(Math.Floor(6.872));       -
            Console.WriteLine(Math.Ceiling(6.872));     -
            Console.WriteLine(Math.Max(48,35));         -
            Console.WriteLine(Math.Min(48,35));         -
            Console.WriteLine(Math.Sin(10));            -
            Console.WriteLine(Math.Asin(-10));          -
            Console.WriteLine(Math.Cos(10));            -
            Console.WriteLine(Math.Acos(10));           -
            Console.WriteLine(Math.Tan(10));            -
            Console.WriteLine(Math.Atan(-10));          -
            Console.WriteLine(Math.PI);                 -
            Console.WriteLine(Math.E);                  -
            */
        }
    }
}
