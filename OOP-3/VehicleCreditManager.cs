using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class VehicleCreditManager : ICrediManager // Taşıt Kredisi
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");        
        }
    }
}
