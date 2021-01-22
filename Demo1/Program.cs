using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 100;
            musteri1.FirstName = "ahmet";
            musteri1.LastName = "çakar";
            musteri1.MusteriNo = 1;

            Musteri musteri2 = new Musteri();
            musteri2.FirstName = "Zengin";
            musteri2.LastName = "Paralı";
            musteri2.Id = 101;
            musteri2.MusteriNo = 2;

            Musteri musteri3 = new Musteri();
            musteri3.FirstName = "Yusuf";
            musteri3.LastName = "Günay";
            musteri3.Id = 102;
            musteri3.MusteriNo = 3;



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.AddNewCustomer(musteri1);
            musteriManager.DeleteCustomer(musteri2);
            musteriManager.list(musteri3);

        }
    }
}
