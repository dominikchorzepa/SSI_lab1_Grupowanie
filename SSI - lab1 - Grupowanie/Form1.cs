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

            txtProbki.Clear();

            foreach(Probka p in kmeans.PobierzSrodki())
            {
                txtProbki.AppendText($"({p.X1}, {p.X2})\r\n");
            }
        }
    }
}
