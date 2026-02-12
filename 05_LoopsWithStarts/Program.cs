using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStarts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Alt alta 10 tane yıldız oluşturma

            //for (int i =0; i<=10; i++)
            //{
            //    Console.WriteLine("*");
            //}


            #endregion

            #region yan yana 10 tane yıldız oluşturma

            //for (int i =0; i<=10; i++)
            //{
            //    Console.Write(" * ");
            //}


            #endregion

            #region Alt alta 10 tane yıldız oluşturma not her satırda 10 tane yıldız olsun

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(" * * * * * * * * * * * ");
            //}


            #endregion

            #region Yıldızlarla dik üçgen oluşturma + değişik bir şey

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}

            //for(int k = 4; k>=1; k--)
            //{
            //    for(int l=1;l<=k; l++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}


            //Console.Write("Kaç satır kodun tekrar etmesini istersin: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("Özel olarak yazılmasını istediğin bir sayıyı gir: ");
            //int b= int.Parse(Console.ReadLine());

            //for (int i = 1; i<=a; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        if(i % 2 == 0 && i % b != 0)
            //        {
            //            Console.Write("#");
            //        }
            //        else if(i % 2 !=0 && i % b !=0)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(b);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("kaç satırlıok bir ters üçgen olsun: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = a; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write("#");
            //        }
            //    }
            //    Console.WriteLine();
            //}







            #endregion

            #region Baklava Dilimi

            //Console.Write("Baklavanın Yüksekliğini giriniz: ");
            //int h = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= h; i++)
            //{
            //    for (int j = h - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = h-1; i>=1; i--)
            //{
            //    for(int j=h-1; j>0; j-- )
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}





            //for(int i= 1; i<=3; i++)
            //{
            //    for (int l = 3; l >= i; l--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j=1; j<=2*i-1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}







            #endregion

            #region sola yatık dik üçgen



            //int h = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 1; i <= h; i++)
            //{
            //    for (int k = h; k>=i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int l = 1; l<=i; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region piramit

            //Console.Write("piramit yükselikliği kaç olsun: ");
            //int h = int.Parse(Console.ReadLine());
            //Console.WriteLine();



            //for (int i = 1; i <= h; i++)
            //{
            //    for (int k = h; k >= i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int l = 1; l <= 2 * i - 1; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}





            #endregion

            #region Ters Piramit

            //Console.Write("Ters piramitin Tek sayı olan yükseklik belirle: ");
            //int h = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= h; i++)
            //{
            //    //boşuklar
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int l = h; l >= 2 * i - 1; l--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion



            Console.Read();
        }
    }
}
