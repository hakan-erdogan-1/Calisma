using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "100";
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Çalışkan";
            musteri1.TcNo = "12345678901";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "101";
            musteri2.SirketAdi = "Kodlama";
            musteri2.VergiNo = "1010291301";

            Musteri musteri3 = new TuzelMusteri();  // musteri classından tuzel müsteri referanslı örnek oluşturulabilir.
            Musteri musteri4 = new GercekMusteri(); // musteri classından gerçek müsteri referanslı örnek oluşturulabilir.

            MusteriManager musteriManager = new MusteriManager(); // musteriManager örneği oluşturuldu.
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
