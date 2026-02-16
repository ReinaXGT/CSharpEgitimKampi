using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //sar,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[Boyut veya Eleman Sayısı];

            //string[] colors = new string[5];
            //colors[0] = "Sarı";
            //colors[1] = "Kırmızı";
            //colors[2] = "Mavi";
            //colors[3] = "Beyaz";
            //colors[4] = "Mor";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Lüksemburg";
            //cities[2] = "Washington";
            //cities[3] = "Moskova";
            //cities[4] = "Ankara";

            //Console.WriteLine(cities[3]);


            //int[] evenNumbers = new int[10];

            //evenNumbers[0] = 12;
            //evenNumbers[1] = 6772;
            //evenNumbers[2] = 214;
            //evenNumbers[3] = 6;
            //evenNumbers[4] = 438;

            //Console.WriteLine(evenNumbers[7]); // hata vermez ama 0 döndürür çünkü int default değeri 0'dır.


            //string[] cities = { "Paris", "Roma", "Prag", "Pekin", "Londra" };

            //Console.WriteLine(cities[2]);

            #endregion


            #region Dizideki Tüm elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Beyaz", "Mor","Pembe","Turkuaz","Ela","Green" };

            //for(int i =0; i<=8; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 12, 6772, 214, 6, 438, 23, 45, 67, 89 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //char[] symbols = { '!', '?', '*', '&', '^', '%', '$', '#', '@' };

            //for(int i =0; i<symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] numbers = { 12, 6772, 214, 6, 438, 23, 45, 21367, 89 };

            //int maxNumber = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (maxNumber < numbers[i])
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine("Dizi içerisindeki en büyük sayı: " + maxNumber);

            //int[] number0 = { 12, 6772, 214, 6, 438, 23, 45, 21367, 89 };

            //Array.Sort(number0); // Diziyi küçükten büyüğe sıralar. 
            //Array.Reverse(number0); // Diziyi tersten sıralar. 89,21367, ... gibi gider.
            ////eğer önce sort sonra reverse yaparsak büyükten küçüğe sıralamış oluruz.

            //for (int i = 0; i<number0.Length; i++)
            //{
            //    Console.Write(number0[i] + ", ");
            //}

            #endregion


            #region Dizi Metotları

            //string[] customers = { "Ahmet", "Mehmet", "Ayşe", "Fatma", "Ali" };
            //int index = Array.IndexOf(customers, "Mehmet"); //debuglarda işine yarar. Mehmet'in indexini verir. Eğer dizi içerisinde yoksa -1 döndürür.
            //Console.WriteLine(index);

            //int[] numbers = { 12, 6772, 214, 6, 438, 23, 45, 21367, 89 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min());
            #endregion

            #region Kullanicidan değer almak ve dizide aramak

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri giriniz: "); //$ işaretinin amacı string içerisinde değişken kullanmamızı sağlar. i+1 yazdık çünkü kullanıcıya 1. şehir, 2. şehir gibi bir ifade sunmak istiyoruz. Eğer i yazsaydık 0. şehir, 1. şehir gibi bir ifade sunardı ki bu kullanıcı açısından kafa karıştırıcı olurdu.
            //    cities[i] = Console.ReadLine();

            //}

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    if (i == cities.Length - 1)
            //    {
            //        Console.Write(cities[i]);
            //    }
            //    else
            //    {
            //        Console.Write(cities[i] + ", ");
            //    }
            //}

            //int[] numbers = { 12, 6772, 214, 6, 438, 23, 45, 21367, 89 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine("Toplam: " + sum);

            //int[] numbers = { 12, 15, 214, 7, 438, 23, 44, 21367, 88 };
            //int[] evenNumbers = new int[numbers.Length + 1];
            //int[] oddNumbers = new int[numbers.Length + 1];

            //int a = 0;
            //int b = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {

            //        evenNumbers[a] = numbers[i];
            //        a++;
            //    }
            //    else
            //    {
            //        oddNumbers[b] = numbers[i];
            //        b++;
            //    }
            //}



            //for (int i = 0; i < b; i++)
            //{
            //    Console.Write(oddNumbers[i] + ", ");
            //}
            //Console.WriteLine();

            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write(evenNumbers[i] + ", ");
            //}


            #endregion

            Console.Read();
        }
    }
}
