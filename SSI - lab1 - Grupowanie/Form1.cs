namespace SSI___lab1___Grupowanie
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private List<Probka> probki;

        public Form1()
        {
            InitializeComponent();

            probki = BazaDanych.WczytajBazeDanych("spiralka.csv");

            comboBoxMetryka.Items.Add("Euklidesowa");
            comboBoxMetryka.Items.Add("Manhattan");
            comboBoxMetryka.Items.Add("Czebyszew");
            comboBoxMetryka.Items.Add("Minkowskiego");

            comboBoxMetryka.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUruchom_Click(object sender, EventArgs e)
        {
            Kmeans kmeans = new Kmeans();

            kmeans.Uruchom(probki, 3, 100);

            txtProbki.Clear();

            List<List<Probka>> grupy = kmeans.PobierzGrupy();

            for (int i = 0; i < grupy.Count; i++)
            {
                txtProbki.AppendText($"Grupa {i + 1}: {grupy[i].Count} próbek\r\n");
            }


        }
    }
}
