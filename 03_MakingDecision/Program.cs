using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If-Else Yapısı

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru hesabı aç");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış tekrar deneyiniz veya şifreyi unuttum yapınız");
            //}

            //string userName, password;

            //Console.Write("Kullanci adini giriniz: ");
            //userName = Console.ReadLine();

            //Console.Write("Şifrenizi giriniz: ");
            //password = Console.ReadLine();

            //if(userName == "Emre" && password == "1234" ) 
            //{
            //    Console.WriteLine("Sayfaya yönlendiriliyorsunuz... ");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanici adi veya şifreniz hatali lütfen tekrar deneyeniz. ");
            //}


            //int questionSolution;

            //Console.Write("15*5= ");
            //questionSolution = int.Parse(Console.ReadLine());

            //if(questionSolution == 75)
            //{
            //    Console.WriteLine("Tebrikler doğru sonuç. ");
            //}
            //else
            //{
            //    Console.WriteLine("Sonuç hatalı. ");
            //}


            //int examNote1, examNote2, examNote3, average;

            //Console.Write("Please enter your Math results: ");
            //examNote1 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter your Biyoloji results: ");
            //examNote2 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter your Fizik results: ");
            //examNote3 = int.Parse(Console.ReadLine());

            //average = (examNote1 + examNote2 + examNote3) / 3;

            //if (average < 30)
            //{
            //    Console.WriteLine("Notunuz Harf Notu olarak 'C' ");
            //}
            //else if (average < 50)
            //{
            //    Console.WriteLine("Notunuz Harf Notu olarak 'B' ");
            //}
            //else if (average < 85)
            //{
            //    Console.WriteLine("Notunuz Harf Notu olarak 'A' ");
            //}
            //else if (85 < average) //&& ve | veya operatörleri ile birden fazla şartı aynı anda kontrol edebiliriz.
            //{
            //    Console.WriteLine("Notunuz Harf Notu Olarak 'S' ");
            //}
            //else
            //{
            //    Console.WriteLine("Hata Sayı olarak NOTLARI GIRINIRZ!! ");
            //} 

            #endregion


            #region Mod İşlemleri


            //Console.Write("Bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int result = number % 2;
            //if (result == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı bir çift sayi");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayi bir tek sayi");
            //}


            #endregion


            #region Char değikenleri ile karar yapıları

            //Console.WriteLine("İşleme devam etmek istiyorsanız y'ye çıkmak istiyorsanız n'ye basın.");
            //char choiceOrder = char.Parse(Console.ReadLine());

            //if (choiceOrder == 'y' | choiceOrder == 'Y')
            //{
            //    Console.WriteLine("Bir sonraki işlem...");
            //}
            //else if (choiceOrder == 'n' | choiceOrder == 'N')
            //{
            //    Console.WriteLine("İşlem Durduruluyor...");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen y veya n giriniz.");
            //}

            //Console.WriteLine("***** CSharp Yemek Menüsü *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1-Ara Yemekler");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine("4-Içecekler");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();

            //Console.Write("Lütfen istediğiniz menü türünü seçiniz: ");
            //char menuType = char.Parse(Console.ReadLine());
            //Console.WriteLine();

            //if (menuType == '1')
            //{
            //    Console.WriteLine("***** Ara Yemekler Menüsü *****");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Patates kızartması");
            //    Console.WriteLine("2-Soğan halkası");
            //    Console.WriteLine("3-Yozgat yarragı");
            //    Console.WriteLine();
            //    Console.WriteLine("***** Ara Yemekler Menüsü *****");



            //}
            //else if (menuType == '2')
            //{
            //    Console.WriteLine("***** Ana Yemekler Menüsü *****");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Patates kızartması");
            //    Console.WriteLine("2-Soğan halkası");
            //    Console.WriteLine("3-Yozgat yarragı");
            //    Console.WriteLine();
            //    Console.WriteLine("***** Ara Yemekler Menüsü *****");
            //}
            //else if (menuType == '3')
            //{
            //    Console.WriteLine("***** Tatlılar *****");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Patates kızartması");
            //    Console.WriteLine("2-Soğan halkası");
            //    Console.WriteLine("3-Yozgat yarragı");
            //    Console.WriteLine();
            //    Console.WriteLine("***** Ara Yemekler Menüsü *****");
            //}
            //else if (menuType == '4')
            //{
            //    Console.WriteLine("***** Içecekler *****");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Patates kızartması");
            //    Console.WriteLine("2-Soğan halkası");
            //    Console.WriteLine("3-Yozgat yarragı");
            //    Console.WriteLine();
            //    Console.WriteLine("***** Ara Yemekler Menüsü *****");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen 1-4 arasında bir seçim yapınız.");
            //}




            #endregion


            #region Switch-Case Yapısı


            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());


            //switch (monthNumber) // parantez içine anahtar değeri giriyoruz
            //{
            //    case 1: Console.WriteLine("Seçtiğiniz Ay 'Ocak' "); break;
            //    // monthNumber == 1 ise bu durumu sağlayacak.
            //    // Dikkat edelim case'ten sonra şartı yazıp : koyup sonra yapılacak işlemi yazıyoruz.
            //    // break ifadeside bu durumun sağlanması durumunda switch-case yapısından çıkılmasını sağlar.
            //    case 2: Console.WriteLine("Seçtiğiniz Ay 'Şubat' "); break;
            //    case 3: Console.WriteLine("Seçtiğiniz Ay 'Mart' "); break;
            //    case 4: Console.WriteLine("Seçtiğiniz Ay 'Nisan' "); break;
            //    case 5: Console.WriteLine("Seçtiğiniz Ay 'Mayıs' "); break;
            //    case 6: Console.WriteLine("Seçtiğiniz Ay 'Haziran' "); break;
            //    case 7: Console.WriteLine("Seçtiğiniz Ay 'Temmuz' "); break;
            //    case 8: Console.WriteLine("Seçtiğiniz Ay 'Ağustos' "); break;
            //    case 9: Console.WriteLine("Seçtiğiniz Ay 'Eylül' "); break;
            //    case 10: Console.WriteLine("Seçtiğiniz Ay 'Ekim' "); break;
            //    case 11: Console.WriteLine("Seçtiğiniz Ay 'Kasım' "); break;
            //    case 12: Console.WriteLine("Seçtiğiniz Ay 'Aralık' "); break;
            //    // peki olduda bunlar dışında bir değer girildi if else yapısında else durumu burada ise default durumu vardır.
            //    default: Console.WriteLine("Lütfen 1-12 arasında bir sayı giriniz."); break;

            //}







            #endregion


            #region Switch Case Hesap Makinesi Örneği

            //int number1, number2, result;
            //char symbol;

            //Console.Write("İşlem uygulanmasını istediğiniz iki sayıyıda giriniz sırasıyla: ");
            //number1 = int.Parse(Console.ReadLine());
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz dört işlemden birini seçiniz: +,-,/,* ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //    default:
            //        Console.WriteLine("Lütfen dört işlem sembolünden birini seçiniz: ");
            //        break;
            //}






            #endregion


            Console.Read();

        }
    }
}
