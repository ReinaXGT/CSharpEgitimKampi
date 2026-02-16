using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            //Foreach(1,2,3,4) dçrt tane parametre alan bir döngüdür.
            //1: Değişken türü
            //2: Değişken adı
            //3: In 
            //4: Liste,Dizi,Koleksiyon'nin adları hangisi olacak ise.

            //string[] cities = { "Paris", "Roma", "Prag", "Pekin", "Londra" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //// fordan kolay kısmı şu burada diziyi sınırlandırmıyorsunuz, dizinin uzunluğunu bilmenize gerek yoktur.
            //// Dizinin tüm elemanlarını tek tek gezip ekrana yazdırır.

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach(int sayilar in numbers)
            //{
            //    Console.WriteLine(sayilar);
            //}


            //int[] numbers = { 211, 232, 313, 214, 537, 622, 217, 128, 219 };

            //int[] evenNumbers = new int[5];
            //int[] oddNumbers = new int[5];
            //int a = 0;
            //int b = 0;

            //foreach (int evenOdd in numbers)
            //{
            //    if (evenOdd % 2 == 0)
            //    {
            //        evenNumbers[a] = evenOdd;
            //        a++;
            //    }
            //    else
            //    {
            //        oddNumbers[b] = evenOdd;
            //        b++;
            //    }
            //}

            //foreach (int x in evenNumbers)
            //{
            //    if(x != 0)
            //    {
            //        Console.Write(x + ", ");
            //    }
            //}

            //Console.WriteLine();

            //foreach (int x in oddNumbers)
            //{
            //    if(x != 0)
            //    {
            //        Console.Write(x + ", ");
            //    }
            //}


            //int[] numbers = { 211, 232, 313, 214, 537, 622, 217, 128, 219 };

            //int sum = 0;

            //foreach(int i in numbers)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("Toplam: " + sum);


            //List<int> numbers = new List<int>();// ; yerine {}; de kullanılabilir.
            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,3,4,6,7,8,9
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //var word = "Merhaba";

            //foreach(char i in word)
            //{
            //    Console.WriteLine(i);
            //}








            #endregion


            #region örnek sınav sistemi

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısını kullanicidan alma
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            // öğrenci isimlerini ve not ortalamalarını tutacak diziler oluşturun.
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];




            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();


                //her öğrenci için 3 sınav notu alma
                double totalExamAvg = 0 ;

                for(int k = 1; k<=3; k++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {k}. sınav notunu giriniz: ");
                    double examGrade = double.Parse(Console.ReadLine());
                    totalExamAvg += examGrade;
                }
                studentExamAvg[i] = totalExamAvg / 3;
            }

            Console.WriteLine();

            for(int i = 0; i<studentCount; i++)
            {
                if (studentExamAvg[i]>= 50)
                {

                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Tebrikler {studentNames[i]} geçtin.");
                    Console.WriteLine();
                    Console.WriteLine($"işte not ortalaman: {studentExamAvg[i]}");
                    Console.WriteLine("-------------------------------------");
                }
                else
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Malesef {studentNames[i]} geçemedin :(.");
                    Console.WriteLine();
                    Console.WriteLine($" işte not ortalaman: {studentExamAvg[i]}");
                    Console.WriteLine("-------------------------------------");

                }
            }


            #endregion
            Console.Read();

        }
    }
}
