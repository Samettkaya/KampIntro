using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class ApplicationManager // Başvuru 
    {
        public void ApplicationDo(ICrediManager crediManager,List<ILoggerService> loggerServices) //  Buraya gönderdiğimiz kredi türünü hesaplar
        {
            // Başvuran bilgilerini değerlendirme
            //HousingCreditManager housingCreditManager = new HousingCreditManager();
            //housingCreditManager.Calculate();
            //// Yukardaki kod yanlış kullanımdır çünkü başvurular konut krediler üzerinden hesaplanır 

            crediManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }
        }
    }
}
