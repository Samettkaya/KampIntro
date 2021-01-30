using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class ProductManager // ürünle ilgili operasyonların bulunduğu yerdir
    {

        public void Add(Product product) // Add ekleme
        {
            Console.WriteLine(product.ProductName+" eklendi");
        }

        public void Update(Product product) // güncelleme
        {
            Console.WriteLine(product.ProductName+ " güncelendi");
        }

        //public int Topla (int sayi1, int sayi2)   //  burda topla değişkenini istediğimiz zaman kullanırız ama int yerine void olsa hiç bir yerde kullanmayız
        //{
        //    return sayi1 + sayi2;
        //} 

        //public void Topla2(int sayi1, int sayi2)  //
        //{
        //    Console.WriteLine(sayi1+sayi2);
            
        //}

        //public void Add1(Product product)
        //{
        //    product.ProductName = "kamera";
        //}

        //public void BirseyYap (int sayi)
        //{
        //    sayi = 99;
        //    Console.WriteLine(sayi);
        //}
    }
}
