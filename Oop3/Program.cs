using System;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            KonutKrediManager konutKrediManager = new KonutKrediManager(); //  IKrediManager konutKrediManager = new KonutKrediManager();   bu şekilde de yapılabilir.
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager);
            basvuruManager.BasvuruYap(tasitKrediManager);
            basvuruManager.BasvuruYap(ihtiyacKrediManager);
        }
    }
}
