using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            Product urun_1 = new Product();

            urun_1.Name = "Elma";
            urun_1.Price = 15;
            urun_1.Explanation = "Amasya Elması";

            Product urun_2 = new Product();
            urun_2.Name = "Karpuz";
            urun_2.Price = 80;
            urun_2.Explanation = "Diyarbakır Karpuzu";

            Product[] products = new Product[]
            {
                urun_1,
                urun_2
            };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("---------------------");

            }

            Console.WriteLine("-------------Methods----------------");

            // İnstance - örnek

            // Class Çağırma yöntemi

            SepetManager sepetManager = new SepetManager();
            sepetManager.ProductAdd(urun_1);
            sepetManager.ProductAdd(urun_2);

            sepetManager.ProductAdd_2("Armut", "yeşil armut", 10,50);
            sepetManager.ProductAdd_2("Muz", "yeşil muz", 12,40);

        }
    }
}

// Dont repeat yourself - DRY - Clean Code - Best Practice

