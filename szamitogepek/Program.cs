using System.Text;
using szamitogepek;

namespace Szamitogepek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Szamitogep> szamitogep = new();

            using (var sr = new StreamReader(@"..\..\..\src\szamiogep.txt", Encoding.UTF8))
            {

                _ = sr.ReadLine();
                while (!sr.EndOfStream) szamitogep.Add(new Szamitogep(sr.ReadLine()));
                foreach (Szamitogep item in szamitogep) Console.WriteLine(szamitogep);

            }






            List<Szamitogep>fl10=
            Console.WriteLine("10.feladat");


            static double atlag(List<Szamitogep>k)
            {
                var fl9 = k.Average(k => k.memoria());
                return fl9;
            }

            Console.WriteLine("9.feladat:");

            Console.WriteLine(atlag(szamitogep));




            List<Szamitogep> fl8 = Lassugep(szamitogep);

            Console.WriteLine("8. feladat");

            Console.WriteLine($"Ennek a gépnek a leglassabb a sebessége a processzorja alapján:{fl8[0].Sebesseg},ennyi ilyen modell:{fl8.Count}");




            List<Szamitogep> fl7 = Win20c(szamitogep);

            Console.WriteLine($"7. feladat");

            Console.WriteLine(fl7.Count > 0 ? $"Ennyi{fl7.Count} ilyen Szamitogep van összesen:" : "Nem található ilyen fajta gep!");


        }
        static List<Szamitogep> Win20c(List<Szamitogep> k) => k.Where(k => k.Oprendszer == "Windows" && k.Kijelzomeret > 20).ToList();
        static List<Szamitogep>Lassugep(List<Szamitogep> k)=> k.Where(k => k.Sebesseg <= 2.8).ToList();



    





    }

 }