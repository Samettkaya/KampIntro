using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // naming convention 
     
        public void ProductAdd(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : "+product.Name);
        }

        public void ProductAdd_2(string name,string explanation, double price,int stock)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + name);
        } 
    }
}
