using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class HousingCreditManager : ICrediManager // Konut Kredisi
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
