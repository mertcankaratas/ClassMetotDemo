using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       public void CustomerAdd(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi "+ musteri.customerName);
        }

        public void CustomerDelete(Musteri musteri)
        {
            Console.WriteLine(musteri.customerName + " silindi");
        }

        public void CustomerList(List<Musteri> musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine($"Id {musteri.Id} Müsteri adı {musteri.customerName} Soyadı {musteri.customerSurName} Hesap No {musteri.customerAccountNumber} Birikim {musteri.customerMoneyAmount} ");
            }
            
        }
        
    }
}
