using System;
using System.Collections.Generic;
using System.Text;

namespace SSI___lab1___Grupowanie
{
    public class Kmeans
    {
        private List<Probka> srodkiGrup = new List<Probka>();

        public void LosujSrodki(List<Probka> probki, int k)
        {
            Random random = new Random();

            List<int> indeksy = new List<int>();

            while (indeksy.Count < k)
            {
                int indeks = random.Next(probki.Count);

                if (!indeksy.Contains(indeks))
                {
                    indeksy.Add(indeks);
                }
            }

            foreach (int indeks in indeksy)
            {
                Probka punkt = probki[indeks];

                srodkiGrup.Add(new Probka(punkt.X1, punkt.X2));
            }
        }

        public List<Probka> PobierzSrodki()
        {
            return srodkiGrup;
        }
    }
}
