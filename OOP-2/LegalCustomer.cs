using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{
    class LegalCustomer:Customer // Kurumsal Müşteri
    {
      
        public string CustomerCompanyName { get; set; } // İş Adresi
        public string CustomerTaxNo { get; set; } // Vergi no 
    }
}
