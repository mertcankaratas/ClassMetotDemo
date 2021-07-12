using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.customerName = "Mertcan";
            musteri.customerSurName = "KARATAŞ";
            musteri.customerAccountNumber = "3434";
            musteri.customerMoneyAmount = 1234;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.customerName = "Can";
            musteri2.customerSurName = "KARATAŞ";
            musteri2.customerAccountNumber = "3422";
            musteri2.customerMoneyAmount = 5;

            List<Musteri> musteriList = new List<Musteri> { musteri, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.CustomerAdd(musteri);
            musteriManager.CustomerDelete(musteri2);
            musteriManager.CustomerList(musteriList);
        }
    }
}
