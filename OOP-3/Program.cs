using System;
using System.Collections.Generic;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //NeedCreditManager needCreditManager = new NeedCreditManager();
            //needCreditManager.Calculate();

            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //needCreditManager.Calculate();

            //HousingCreditManager housingCreditManager = new HousingCreditManager();
            //housingCreditManager.Calculate();

            ICrediManager needCreditManager = new NeedCreditManager();
            ICrediManager vehicleCreditManager = new VehicleCreditManager();
            ICrediManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>
            {
                new SmsLoggerService(),
                new FileLoggerService()
            };


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.ApplicationDo(new ArtisanCreditManager(), loggers);

            
            List<ICrediManager> krediler = new List<ICrediManager>()
            {
                needCreditManager,
                housingCreditManager

            };
            //applicationManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
