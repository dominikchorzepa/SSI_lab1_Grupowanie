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

            int k = (int)numK.Value;
            int iteracje = (int)numIteracje.Value;

            TypMetryki metryka = PobierzWybranaMetryke();

            kmeans.Uruchom(probki, k, iteracje, metryka);

            txtProbki.Clear();


        }


        private TypMetryki PobierzWybranaMetryke()
        {
            switch (comboBoxMetryka.SelectedIndex)
            {
                case 0:
                    return TypMetryki.Euklidesowa;
                case 1:
                    return TypMetryki.Manhattan;
                case 2:
                    return TypMetryki.Czebyszew;
                case 3:
                    return TypMetryki.Minkowskiego;
                default:
                    throw new ArgumentException("Wybierz metrykę.");
            }
        }
    }
}
