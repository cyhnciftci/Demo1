using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    class MusteriManager
    {
        public void AddNewCustomer(Musteri musteri)
        {
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Hoşgeldin " + musteri.FirstName + " " + musteri.LastName + "!");
            System.Console.WriteLine("--------------------");
        }
        public void DeleteCustomer(Musteri musteri)
        {
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Hoşçakal " + musteri.FirstName + " " + musteri.LastName + "  ");
            System.Console.WriteLine("--------------------");
        }
        public void list(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + " " + musteri.LastName + " " + "Listelendi.");
        }
    }
}
