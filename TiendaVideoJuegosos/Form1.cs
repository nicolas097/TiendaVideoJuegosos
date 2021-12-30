using VideojuegoLib;

namespace TiendaVideojuegos
{
    public partial class Form1 : Form
    {
        ArchivoCSV openCsv = new ArchivoCSV();

        List<VideoJuego> ListaVideoJuego = new List<VideoJuego>();
       

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

                ListaVideoJuego = openCsv.VideoJuegoListFromCSV(openFile.FileName);
                ReloadDataGrid();

                
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
                 openCsv.SaveCSVFromVideoJuegoList(ListaVideoJuego, saveFile.FileName);
                 
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
              VideoJuego video = new VideoJuego();
              video.nombre = txtNombre.Text;
              video.plataforma = cbPlataforma.Text;
              openCsv.AddVideoJuego(video, ListaVideoJuego);
              ReloadDataGrid();
              MessageBox.Show("Se Agregó algo");
            

        }


        private void ReloadDataGrid()
        {
            //La fuente de datos pase a tener datos
            dgVideoJuegos.DataSource = ListaVideoJuego;
        }
    }
}