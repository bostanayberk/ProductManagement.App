using System;
using ProductManagement.Service;

namespace ProductManagement.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductManagementService productManagementService = new ProductManagementService();
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("Ürün ekle:");
                Console.WriteLine("Listele:");
                Console.WriteLine("Sil:");
                Console.WriteLine("Çıkış:");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        productManagementService.UrunEkle();
                        break;
                    case "2":
                        productManagementService.UrunListeleme();
                        break;
                    case "3":
                        productManagementService.UrunSilme();
                        break;
                    case "4":
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;

                }
            }
        }
    }
}

