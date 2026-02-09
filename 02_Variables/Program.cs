using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);


            //Console.WriteLine("----- Fiyat Listesi -----");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 17.54;
            //strawberryPrice = 45;
            //potatoPrice = 13.33;
            //tomatoPrice = 12.54;

            //Console.WriteLine("Elma Birim Fiyatı:" + applePrice);
            //Console.WriteLine("Portakal Birim Fiyatı:" + orangePrice);
            //Console.WriteLine("Çilek Birim Fiyatı:" + strawberryPrice);
            //Console.WriteLine("Patates Birim Fiyatı:" + potatoPrice);
            //Console.WriteLine("Domates Birim Fiyatı:" + tomatoPrice);

            //Console.WriteLine();
            //Console.WriteLine("----- Fiyat Listesi -----");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 3.324;
            //potatoGram = 4.532;
            //tomatoGram = 2.432;

            //double totalPrice = appleGram * applePrice + orangeGram * orangePrice + strawberryGram * strawberryPrice + potatoGram * potatoPrice + tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutae:" + totalPrice + "TL");

            #endregion

            #region Char Değişkenleri

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20.00'DE
            //" '

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);










            #endregion

            #region Klavyeden Veri Girişleri Input String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerCountry, passengerIdentityNumber ,passengerAge;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Yaşadığı Ülke: ");
            //passengerCountry = Console.ReadLine();

            //Console.Write("Yaşadığı il: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaşadığı ilçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------Yolcu Kimlik Kartı------------");
            //Console.WriteLine("Yolcu Adı-Soyadı: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yolcunun Yaşı ve TC'si Yaşı: " + passengerAge + " TC:  " + passengerIdentityNumber);
            //Console.WriteLine("Yolcunun İkametgahı: " +passengerCountry + "/" +  passengerCity + "/" + passengerDistrict);
            //Console.WriteLine("------------Yolcu Kimlik Kartı------------");






            #endregion

            #region Klavyeden Veri Girişleri Input Integer (INT) Değişkenler

            //int shoesPrice = 1000;
            //int computerPrice = 2000;
            //int chairPrice = 3213;
            //int tvPrice = 12353;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine()); 
            //// parse metodu 32 bitlik bir şekilde sayıyı yazıya döker

            //Console.Write("Lütfen Aldığınız Bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lüften 1.Sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lüften 2.Sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lüften 2.Sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 +  exam3) / 3 ;
            //Console.WriteLine();
            //Console.WriteLine("Not Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();


        }
    }
}
