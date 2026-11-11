using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SSI___lab1___Grupowanie
{
    public class Kmeans
    {
        private List<Probka> srodkiGrup = new List<Probka>();
        private List<List<Probka>> grupy = new List<List<Probka>>();

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

        public void PrzypiszProbkiDoGrup(List<Probka> probki)
        {
            grupy.Clear();

            for (int i = 0; i < srodkiGrup.Count; i++)
            {
                grupy.Add(new List<Probka>());
            }

            foreach (Probka probka in probki)
            {
                double najmniejszaOdleglosc = double.MaxValue;
                int najblizszaGrupa = 0;

                for (int i = 0; i < srodkiGrup.Count; i++)
                {
                    double odleglosc = Metryki.Euklidesowa(probka, srodkiGrup[i]);

                    if (odleglosc < najmniejszaOdleglosc)
                    {
                        najmniejszaOdleglosc = odleglosc;
                        najblizszaGrupa = i;
                    }
                }

                grupy[najblizszaGrupa].Add(probka);
            }
        }

        public List<Probka> PobierzSrodki()
        {
            return srodkiGrup;
        }

        public List<List<Probka>> PobierzGrupy()
        {
            return grupy;
        }
    }
}
