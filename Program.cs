using System;

namespace AB6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*public static double Pow(double x double y);*/
            double i = 1;
            double kubikWert;
            
            do
            {
                kubikWert = Math.Pow(i, 3);
                i = i + 1;
            } while (kubikWert < 5000);

            Console.WriteLine("Erste Methode:\ni: {0}, Kubikwert: {1}", i, kubikWert);


            /*Hier ist i nicht aus der Schleife verfuegbar...*/
            for (i = 1; i > 500; i = i + 1)
            {
                kubikWert = Math.Pow(i, 3);
            } while (kubikWert < 5000) ;
            Console.WriteLine("Zweite Methode:\ni: {0}, Kubikwert: {1}", i, kubikWert);

        }
    }
    
}
