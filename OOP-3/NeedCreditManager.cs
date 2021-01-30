using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class NeedCreditManager : ICrediManager  // ihtiyaç Kredisi
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("ihtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
