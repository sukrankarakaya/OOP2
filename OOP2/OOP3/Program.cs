using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        public static object List { get; private set; }
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasıtKrediManager = new TasıtKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dattabaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            

            BasvuruManager basvuruManager = new BasvuruManager();
             basvuruManager.BasvuruYap(tasıtKrediManager, new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasıtKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
