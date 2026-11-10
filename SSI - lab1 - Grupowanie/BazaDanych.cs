using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace SSI___lab1___Grupowanie
{
    public class BazaDanych
    {
        public static List<Probka> WczytajBazeDanych(string sciezka)
        {
            List<Probka> probki = new List<Probka>();

            string[] linie = File.ReadAllLines(sciezka);

            foreach (string linia in linie)
            {
                string[] wartosci = linia.Split(',');
                double x1 = double.Parse(wartosci[0], CultureInfo.InvariantCulture);

                double x2 = double.Parse(wartosci[1], CultureInfo.InvariantCulture);

                probki.Add(new Probka(x1, x2));
            }

            return probki;
        }
    }
}
