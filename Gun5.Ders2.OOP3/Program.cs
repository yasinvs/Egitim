using System;
using System.Collections.Generic;

namespace Gun5.Ders2.OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new TasitKrediManager(),
                new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
