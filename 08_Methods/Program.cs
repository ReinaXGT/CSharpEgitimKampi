using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void methods

            //()
            //Geriye değer döndürmeyen metotlar
            //Customer--> listele, ekle, sil, güncelle
            //void--> geriye değer döndürmeyen metotlarda kullanılır.

            //void CustomerList()
            //{
            //    Console.WriteLine("a");
            //    Console.WriteLine("a");
            //    Console.WriteLine("a");
            //    Console.WriteLine("a");
            //}


            //CustomerList();






            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar


            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("a"); //kendi metodunu yaratıyon yani, parametre olarak istediğin değeri verebilirsin. Metodun içine istediğin kadar parametre verebilirsin.


            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surname}");
            //}

            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşegül","Kaya");



            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void sum(int number1, int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //sum(1,3,4);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerCard()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerCard();



            //string StudentCard()
            //{
            //    string name = "Buse";
            //    string surname = "Yıldız";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());




            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = $"Ülke: {countryName} Başkent: {capital} Bayrak Rengi: {flagColor}";

            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülkenizi giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int sum(int a, int b, int c)
            //{
            //    int result = a + b + c;
            //    return result;
            //}

            //Console.WriteLine(sum(5,4,7));
            //Console.WriteLine(sum(5,412,7));
            //Console.WriteLine(sum(125,4,7));


            #endregion

            #region Örnek Uygulama


            int ExamResultAvg(string student,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                return result;
            }

            Console.Write("Öğrencinin ismi: ");
            string name = Console.ReadLine();

            Console.Write("Sırasıyla 1. 2. 3. sınav notlarını gir: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int y = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int z = int.Parse(Console.ReadLine());


            Console.WriteLine(ExamResultAvg(name,x,y,z));

            #endregion





            Console.Read();
        }
    }
}
