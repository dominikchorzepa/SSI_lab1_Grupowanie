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
            Kmeans kmeans = new Kmeans();
            kmeans.LosujSrodki(probki, 3);

            kmeans.PrzypiszProbkiDoGrup(probki);

            kmeans.AktualizujSrodki();

            txtProbki.Clear();

            List<List<Probka>> grupy = kmeans.PobierzGrupy();

            foreach (Probka p in kmeans.PobierzSrodki())
            {
                txtProbki.AppendText($"X1: {p.X1}, X2: {p.X2}\r\n");
            }
        }
    }
}
