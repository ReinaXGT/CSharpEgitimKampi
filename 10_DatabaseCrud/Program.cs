using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete dört işlemden oluşan bir işlemdir.

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();


            Console.WriteLine("--------------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();


            //SqlConnection connection = new SqlConnection("Data Source=localhost;initial catalog=EgitimKampiDb;integrated security=true");
            //// bağlantımızı oluşturduk veri tabanıyla

            //connection.Open();// bağlantımızı açtık

            ////SqlCommand sınıfı, SQL sorgularını çalıştırmak için kullanılır. sorguyu burada vereceğiz.

            //SqlCommand command = new SqlCommand("insert into TblCategory (categoryName) values (@p1)",connection);

            //command.Parameters.AddWithValue("@p1",categoryName);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi.");


            #endregion

            #region Ürün Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz ürün adını giriniz: ");
            //string productName = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write($"{productName} Adlı Ürünün Fiyatı Ne Olsun: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.Write($"{productName} Bu Ürün Elimizde Mevcut mu? (True/False): ");
            //bool productStatus = bool.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=localhost;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand komut = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)",connection);

            //komut.Parameters.AddWithValue("@p1",productName);
            //komut.Parameters.AddWithValue("@p2",productPrice);
            //komut.Parameters.AddWithValue("@p3",productStatus);
            //komut.ExecuteNonQuery();

            //connection.Close();

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=localhost;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); // köprü görevi görür. SqlCommand ile oluşturulan sorguyu çalıştırır ve sonuçları bir DataTable veya DataSet'e doldurur.

            //DataTable dataTable = new DataTable();

            //// Ramde DataTable için bir yer açtık ve adapter ile dolduracağız. 
            ////ki adapterda bizim sqle verdiğimiz sorguyu yani commandi içeriyor.

            //adapter.Fill(dataTable); //dataTable'ı adapterla doldur demek.


            //foreach (DataRow row in dataTable.Rows) // DataRow bir sınıf,row bizim döngümüzdeki i,in ile dataTable'ın satırlarının içine giriyor.
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write($"{item.ToString()} ");
            //    }
            //    Console.WriteLine();
            //}



            //connection.Close();



            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinmesini istediğiniz ürünün ID sini giriniz: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=localhost;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand silmeKomudu = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);

            //silmeKomudu.Parameters.AddWithValue("@productId", productId);
            //silmeKomudu.ExecuteNonQuery();



            //connection.Close();

            //Console.WriteLine("Silme İşlemi Tamamlandı!");




            #endregion

            #region Ürün Güncelleme İşlemi


            //Console.Write("Güncellemek istediğiniz ürünün ID'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Güncelleyeceğiniz ürünün yeni ismi: ");
            //string productName= Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Güncelleyeceğiniz yeni ürnünün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            

            //SqlConnection connection = new SqlConnection("Data Source=localhost;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();


            //SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@productName,ProductPrice=@productPrice,ProductStatus=@p3 " +
            //    "Where ProductId=@productId",connection);

            //command.Parameters.AddWithValue("@productId", productId);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();

            //connection.Close();


            #endregion






            Console.Read();
        }
    }
}
