using VideojuegoLib;

namespace TiendaVideojuegosos
{
    public partial class Form1 : Form
    {
        ArchivoCSV openCsv = new ArchivoCSV();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "csv files (*.csv)|*.csv";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                dgVideoJuegos.DataSource = openCsv.VideoJuegoListFromCSV(openFile.FileName);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.AddExtension = true;
            saveFile.DefaultExt = "csv";
            saveFile.Filter = "csv files (*.csv)|*.csv";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                openCsv.SaveCSVFromVideoJuegoList((List<VideoJuego>)dgVideoJuegos.DataSource, saveFile.FileName);
            }
        }
    }
}