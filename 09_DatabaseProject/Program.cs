using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            //ile veritabanına bağlanmak için gerekli olan sınıflar System.Data.SqlClient isim alanında bulunur.


            Console.WriteLine("***** C# Veri tabanlı ürün-kategori bilgi sistemi *****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;


            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();


            SqlConnection connection = new SqlConnection("Data Source=localhost;initial Catalog=EgitimKampiDb;integrated security=true");

            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            // veri tabanından veri çekmek için kullanılan bir sınıftır. köprü görevi görür.
            // SqlCommand ile oluşturulan sorguyu çalıştırır ve sonuçları bir DataTable veya DataSet'e doldurur.

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            // burada adapter ramde bir yer ediniyor ve dataTable'ı dolduruyor.
            // adapterda Select sorgusu var ve o sorguyu çalıştırarak verileri dataTable'a dolduruyor.


            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                    
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
