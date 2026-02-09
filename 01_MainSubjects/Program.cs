using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları

            //Console.WriteLine("İmleci aşağı indirerek yazar");
            //Console.Write("direk write metodu ise kaldıgı yerden");
            //Console.Write("Yazdırır.,");

            //Console.WriteLine("***** Döner Çeşitleri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Et Döner");
            //Console.WriteLine("2-Kaşarlı Et Döner");
            //Console.WriteLine("3-Hatay Usulü Tavuk Döner");
            //Console.WriteLine("");
            //Console.WriteLine("***** Döner Çeşitleri *****");

            #endregion


            #region Değişkenler
            #region String Değişkenler

            //string
            // Değişken_türü değişken_adi;

            //string name;
            //name = "Emre";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Adal";
            //customerSurname = "Güngördü";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "adalgungordu@gmail.com";
            //district = "Magusa";
            //city = "Cyprus";

            //Console.WriteLine("***** Kullancı Kimlik Karti *****");
            //Console.WriteLine();
            //Console.WriteLine("Kullanci Adi-Soyadi: " + customerName + "" + customerSurname);
            //Console.WriteLine("Kullanici Tel No: " + customerPhone);
            //Console.WriteLine("Kullanici Maili: " + customerEmail);
            //Console.WriteLine("Kullanicinin Yasadigi ilce: " + district);
            //Console.WriteLine("Kullanicinin Yasadigi il: " + city);
            //Console.WriteLine();
            //Console.WriteLine("***** Kullanici Kimlik Karti *****");

            //customerName = "Ayşegül";
            //Console.WriteLine(customerName);




            #endregion

            #region Integer Değişenler

            //int
            //int number = 24
            //Console.WriteLine(number);


            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 20;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 75;

            //Console.WriteLine("----- Restoran Menü Fiyatı -----");
            //Console.WriteLine();
            //Console.WriteLine("*** Yiyecekler ***");
            //Console.WriteLine();
            //Console.WriteLine("1-Hamburger "+hamburgerPrice+" ₺");
            //Console.WriteLine("2-Pizza " + pizzaPrice + " ₺");
            //Console.WriteLine("3-fries " + friesPrice + " ₺");
            //Console.WriteLine();
            //Console.WriteLine("*** İçecekler ***");
            //Console.WriteLine();
            //Console.WriteLine("1-Su "+ waterPrice + " ₺");
            //Console.WriteLine("2-Cola "+ cokePrice + " ₺");
            //Console.WriteLine("3-limonata "+ lemonadePrice + " ₺");
            //Console.WriteLine();
            //Console.WriteLine("----- Restoran Menü Fiyatı -----");




            //Console.WriteLine();
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //// Değişkenler - HATA 1 ÇÖZÜMÜ: Hepsine varsayılan olarak 0 atadık.
            //// Böylece if bloğuna girmese bile hesaplamada hata vermez.
            //int totalHamburgerPrice = 0;
            //int totalCokePrice = 0;
            //int totalWaterPrice = 0;
            //int totalFriesPrice = 0;
            //int totalPizzaPrice = 0;
            //int totalLemonadePrice = 0;
            //int totalPrice = 0;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //Console.WriteLine("----- Hesap Bilgisi -----");

            //// Mantık - HATA 2 ÇÖZÜMÜ: 'else if' yerine sadece 'if' kullandık.
            //// Böylece hem hamburgeri hem de kolayı aynı anda hesaplayabilir.
            //if (hamburgerCount != 0)
            //{
            //    totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            //    Console.WriteLine(hamburgerCount + "X Hamburger Fiyatı: " + totalHamburgerPrice);
            //}

            //if (cokeCount != 0) // 'else if' yerine 'if'
            //{
            //    totalCokePrice = cokePrice * cokeCount;
            //    Console.WriteLine(cokeCount + "X Cola Fiyatı: " + totalCokePrice);
            //}

            //if (waterCount != 0) // 'else if' yerine 'if'
            //{
            //    totalWaterPrice = waterPrice * waterCount;
            //    Console.WriteLine(waterCount + "X Su Fiyatı: " + totalWaterPrice);
            //}

            //if (friesCount != 0) // 'else if' yerine 'if'
            //{
            //    totalFriesPrice = friesPrice * friesCount;
            //    Console.WriteLine(friesCount + "X Kızartma Fiyatı: " + totalFriesPrice);
            //}

            //if (pizzaCount != 0) // 'else if' yerine 'if'
            //{
            //    totalPizzaPrice = pizzaPrice * pizzaCount;
            //    Console.WriteLine(pizzaCount + "X Pizza Fiyatı: " + totalPizzaPrice);
            //}

            //if (lemonadeCount != 0) // 'else if' yerine 'if'
            //{
            //    totalLemonadePrice = lemonadePrice * lemonadeCount;
            //    Console.WriteLine(lemonadeCount + "X Limonata Fiyatı: " + totalLemonadePrice);
            //}

            //Console.WriteLine("-------------------------");
            //totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalPizzaPrice + totalFriesPrice + totalLemonadePrice;
            //Console.WriteLine("Toplam Tutar: " + totalPrice + " ₺");





            #endregion






            #endregion


            Console.Read();
        }
    }
}




