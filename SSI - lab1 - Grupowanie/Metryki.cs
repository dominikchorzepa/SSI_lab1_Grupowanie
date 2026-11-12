using System;
using System.Collections.Generic;
using System.Text;

namespace SSI___lab1___Grupowanie
{
    public enum TypMetryki
    {
        Euklidesowa,
        Manhattan,
        Czebyszew,
        Minkowskiego
    }
    public class Metryki
    {
        public static double ObliczOdleglosc(Probka a, Probka b, TypMetryki metryka)
        {
            switch (metryka)
            {
                case TypMetryki.Euklidesowa:
                    return Euklidesowa(a, b);
                case TypMetryki.Manhattan:
                    return Manhattan(a, b);
                case TypMetryki.Czebyszew:
                    return Czebyszew(a, b);
                case TypMetryki.Minkowskiego:
                    return Minkowski(a, b, 2);
                default:
                    throw new ArgumentException("Nieznana metryka: " + metryka);
            }
        }

        public static double Euklidesowa(Probka a, Probka b)
        {
            return Math.Sqrt(Math.Pow(a.X1 - b.X1, 2) + Math.Pow(a.X2 - b.X2, 2));
        }

        public static double Manhattan(Probka a, Probka b)
        {
            return Math.Abs(a.X1 - b.X1) + Math.Abs(a.X2 - b.X2);
        }

        public static double Czebyszew(Probka a, Probka b)
        {
            return Math.Max(Math.Abs(a.X1 - b.X1), Math.Abs(a.X2 - b.X2));
        }

        public static double Minkowski(Probka a, Probka b, double m)
        {
            return Math.Pow(Math.Pow(Math.Abs(a.X1 - b.X1), m) + Math.Pow(Math.Abs(a.X2 - b.X2), m), 1 / m);
        }
    }
}
