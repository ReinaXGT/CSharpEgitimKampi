using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            ////Döngüler
            ////insanlar toplama işlemini 1+2+3+4+5 şeklinde yaparken
            ////bilgisayar 1+2=3 3+3=6 6+4 = 10 şeklinde yapar.
            ////Yani bilgisayar işlemi yaparken bir önceki sonucu kullanır. Döngülerde de aynı mantık geçerlidir.
            ////Döngülerde de bir önceki sonucu kullanarak işlemi yaparız.

            ////for(x; y; z) 3 tane parametre alır.
            ////x başlangıç değeri, y koşul, z ise artış miktarıdır.

            ////x:başlangıç
            ////y:bitiş 
            ////z:artış-azalış


            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim kampı");
            //}

            //for (int i =0; i<=19;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Yazılmasını istediğiniz kadar bir sayı giriniz: ");
            //int finishCount = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishCount; i++)
            //{
            //    Console.WriteLine("Seni Seviyoruz Emre");
            //}



            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    //totalValue += i;

            //    //if (i == 10)
            //    //{
            //    //    totalValue = (i + 1) * i / 2;
            //    //    Console.WriteLine(totalValue);
            //    //}
            //}

            //int totalValue = 0;
            //int evenValue = 0;
            //int oddValue = 0;

            //Console.Write("Kaçıncı sayıya kadar toplansın: ");
            //int lenght = int.Parse(Console.ReadLine());


            //for (int i = 0; i <=lenght; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        evenValue += i;

            //    }
            //    else
            //    {
            //        oddValue += i;
            //    }
            //}
            //Console.WriteLine();
            //totalValue = evenValue + oddValue;
            //Console.Write(lenght+". Sayıya kadar çift olan sayıların toplamı: ");
            //Console.WriteLine(evenValue);
            //Console.WriteLine();
            //Console.Write(lenght + ". Sayıya kadar tek olan sayıların toplamı: ");
            //Console.WriteLine(oddValue);
            //Console.WriteLine();
            //Console.Write(lenght + ". Sayıya kadar sayıların toplamı: ");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i = 1; i<=50; i++)
            //{
            //    if(i % 7 == 0 )
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine("bu kadar 50 nin içinde 7 ye bölünebilcek sayı var: " + count);




            //int bacteriumCount = 1;
            //int hourCount;

            //Console.Write("Kaçıncı saat sonucunda oluşan bakteri sayısını görmek istiyorsunuz: ");
            //hourCount = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= hourCount; i++)
            //{
            //    bacteriumCount *= 2;
            //    Console.WriteLine(hourCount + ". Saatte oluşan bakteri sayısı: " + bacteriumCount);
            //}

            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //işlemler
            //}

            //int i = 1;

            //while(i<=10)
            //{
            //    Console.WriteLine("Merhaba Dünya "+i);
            //    i++; // bunu unutma yoksa sonsuz döngüye girebiliriz.
            //}

            //int i = 1;

            //while(i<=30)
            //{
            //    if (i % 3 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;

            //Console.Write("Kaçıncı sayıya kadar toplansın: ");
            //int lenght = int.Parse(Console.ReadLine());

            //while(i<= lenght)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Cevap: " + sum);


            #endregion


            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı bir satının basamaklardaki rakamları toplayıp hesaplayan kodu yazınız.

            //456 ==> 4 + 5 + 6 = 15 gibi


            Console.Write("Lütfen hesaplanmasını istediğiniz üç basamaklı sayıyı giriniz: ");
            int inputValue = int.Parse(Console.ReadLine());
            int abc;
            int sum= 0;

            abc = inputValue;

            if (abc > 999)
            {
                Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz.");
                return;
            }

            for (int i = 100; i <= 999; i++)
            {
                if (abc % i == 0)
                {
                    int c = abc % 10;
                    int bc = abc % 100;
                    int b = (bc - c) / 10;
                    int a = (abc - bc) / 100;
                    sum = a + b + c;
                }

            }

            Console.WriteLine("Cevap: " + sum);



            #endregion



            Console.Read();







        }
    }
}
