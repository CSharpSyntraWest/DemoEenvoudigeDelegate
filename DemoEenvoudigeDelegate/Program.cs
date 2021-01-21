using System;

namespace DemoEenvoudigeDelegate
{
    public delegate void EenvoudigeDelegate(string param);
    class Program
    {
        static void TestMethode(string text)
        {
            Console.WriteLine($"TestMethode is aangeroepen met param {text}");
        }
        static void TestMethode2(string mijnTekst)
        {
            Console.WriteLine($"TestMethode is (ook) aangeroepen met param {mijnTekst}");
        }
        static void Main(string[] args)
        {
            //Aanroep op klassieke manier (zonder delegate):
            TestMethode("'Hello!'");
            //Aanroep van methode via EenvoudigeDelegate
            EenvoudigeDelegate mijnMethodVariabele = new EenvoudigeDelegate(TestMethode);
            mijnMethodVariabele("'Nog Eens Hello via Delegate'");
            EenvoudigeDelegate mijnMethodeVariabele2 = new EenvoudigeDelegate(TestMethode2);
            mijnMethodeVariabele2("'parameter voor TestMethode2'");
        }
    }
}
