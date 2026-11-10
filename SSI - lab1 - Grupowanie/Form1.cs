namespace SSI___lab1___Grupowanie
{
    public partial class Form1 : Form
    {
        private List<Probka> probki;

        public Form1()
        {
            InitializeComponent();

            probki = BazaDanych.WczytajBazeDanych("spiralka.csv");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnWyswietl_Click(object sender, EventArgs e)
        {
            Probka a = new Probka(1, 2);
            Probka b = new Probka(4, 6);

            double euklidesowa = Metryki.Euklidesowa(a, b);
            double manhattan = Metryki.Manhattan(a, b);
            double czebyszew = Metryki.Czebyszew(a, b);
            double minkowski = Metryki.Minkowski(a, b, 2);

            txtProbki.Text = $"Probka A: ({a.X1}, {a.X2})\r\nProbka B: ({b.X1}, {b.X2})\r\n\r\n" +
                $"Odległość Euklidesowa: {euklidesowa}\r\n" +
                $"Odległość Manhattan: {manhattan}\r\n" +
                $"Odległość Czebyszew: {czebyszew}\r\n" +
                $"Odległość Minkowskiego (m=2): {minkowski}";
        }
    }
}
