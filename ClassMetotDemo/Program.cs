using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { Id = 1, FirstName = "Ayşe", LastName = "İnan", AccountNumber = 54587 };
            Musteri musteri2 = new Musteri() { Id = 2, FirstName = "Anıl", LastName = "Altunyurt", AccountNumber = 85468 };
            Musteri musteri3 = new Musteri() { Id = 3, FirstName = "Özlem", LastName = "Şahin", AccountNumber = 63987 };
            Musteri musteri4 = new Musteri() { Id = 4, FirstName = "Hakan", LastName = "Kanak", AccountNumber = 12756 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.AddMusteri(musteri1);
            musteriManager.UpdateMusteri(musteri4);
            musteriManager.DeleteMusteri(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (var musteri in musteriler)
            {
                musteriManager.ListMusteri(musteri);
            }

        }
        
    }
}
