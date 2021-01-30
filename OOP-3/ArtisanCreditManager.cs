using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class ArtisanCreditManager : ICrediManager // Esnaf kredisi
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı");
        }
    }
}
