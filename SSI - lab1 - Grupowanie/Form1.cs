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
            txtProbki.Clear();

            foreach (Probka p in probki)
            {
                txtProbki.AppendText(
                    $"X1: {p.X1}, X2: {p.X2}{Environment.NewLine}"
                    );
            }
        }
    }
}
