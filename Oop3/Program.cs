using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            KonutKrediManager konutKrediManager = new KonutKrediManager(); //  IKrediManager konutKrediManager = new KonutKrediManager();   bu şekilde de yapılabilir.
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
             basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);
             basvuruManager.BasvuruYap(tasitKrediManager,fileLoggerService);
             basvuruManager.BasvuruYap(new EsnafKrediManager() , databaseLoggerService); // bu şekilde de örnekleme yapılabilir.
             basvuruManager.BasvuruYap(ihtiyacKrediManager, new SmsLoggerService());
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,konutKrediManager,tasitKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
