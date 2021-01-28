using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();


            musteri1.Id = 1000;
            musteri1.Name = "Mustafa";
            musteri1.LastName = "Aksoy";

            musteri2.Id = 1000;
            musteri2.Name = "Mustafa";
            musteri2.LastName = "Aksoy"; 
            
            musteri3.Id = 1000;
            musteri3.Name = "Mustafa";
            musteri3.LastName = "Aksoy";



            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Musteri[] Musteriler = new Musteri[] {musteri1, musteri2, musteri3};
            foreach (Musteri musteri in Musteriler)
            {
                musteriManager.List(musteri);
            }

            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);

        }


        
    }

}
