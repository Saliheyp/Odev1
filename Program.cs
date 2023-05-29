using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   

        //     // 1. Soru
        //     Console.WriteLine("Bir adet pozitif sayı giriniz");
        //     int n =int.Parse(Console.ReadLine());
        //     int[] sayilar = new int[n];
        //     for (int i = 0; i < n; i++)
        //     {
        //         Console.Write("lütfen {0}. sayısını giriniz .", i+1);
        //         sayilar[i] = int.Parse(Console.ReadLine());
        //     }

        //     foreach (var sayi in sayilar)
        //     {
        //         if (sayi%2==0)
        //         {
        //             Console.Write(sayi+" ");
        //         }
        //     }
        //     //2.Soru
        //     Console.WriteLine("*******2.Soru*******");
        //     Console.WriteLine("iki adet pozitif sayı giriniz");
        //     Console.Write("Birinci Sayi :");

        //     int y =int.Parse(Console.ReadLine());
        //     Console.Write("ikinci Sayi :");
        //     int z =int.Parse(Console.ReadLine());
            
        //     int[] sayilar2 = new int[y];
        //     for (int j = 0; j < y; j++)
        //     {
        //         Console.Write("lütfen {0}. sayısını giriniz .", j+1);
        //         sayilar2[j] = int.Parse(Console.ReadLine());
        //     }
        //     foreach (var sayi2 in sayilar2)
        //     {
        //         if(sayi2 == z || sayi2%z == 0)
        //         {
        //             Console.WriteLine(sayi2);
        //         }
        //     }
        //     //3. Soru
        //     Console.WriteLine("*******3.Soru*******");
        //     Console.WriteLine("Bir adet pozitif sayı giriniz");
        //     int nn =int.Parse(Console.ReadLine());
        //     string[] kelimeler = new string[nn];
        //     for (int i = 0; i < nn; i++)
        //     {
        //         Console.Write("lütfen {0}. kelimeyi giriniz .", i+1);
        //         kelimeler[i] = Console.ReadLine();
        //     }
        //     Array.Reverse(kelimeler);
        //     foreach (var kelime in kelimeler)
        //     {
        //         Console.WriteLine(kelime);
        //     }

            //4. Soru
            Console.WriteLine("*******4.Soru*******");
            Console.WriteLine("Bir cümle giriniz:");
            string cumle = Console.ReadLine();
            string[] kelimeSayisi = cumle.Split(' ');
            Console.WriteLine(kelimeSayisi.Length);
            int yy = cumle.Length;
            int zzz = cumle.Split(' ').Length;
            Console.WriteLine(yy-zzz+1);
            
            
        }
    }
}