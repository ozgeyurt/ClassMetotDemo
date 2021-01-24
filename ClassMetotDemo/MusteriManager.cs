using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void AddMusteri (Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" "+ musteri.FirstName+" "+musteri.LastName+" "+"isimli müşteri"+
                " "+musteri.AccountNumber+ " "+"hesap numarasıyla eklendi");
            Console.WriteLine("********");
        }
        public void UpdateMusteri(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.FirstName + " " + musteri.LastName + " " + "isimli müşteri" + 
                " " + musteri.AccountNumber + " " + "hesap numarasıyla güncellendi");
            Console.WriteLine("********");

        }
        public void DeleteMusteri(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.FirstName + " " + musteri.LastName + " " + "isimli müşteri" +
               " " + musteri.AccountNumber + " " + "hesap numarasıyla silindi");
            Console.WriteLine("********");

        }
        public void ListMusteri(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.FirstName + " " + musteri.LastName + " " + "isimli müşteri" +
              " " + musteri.AccountNumber + " " + "hesap numarasıyla listeye eklendi");

        }
    }
}
