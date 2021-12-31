using VideojuegoLib;

namespace TiendaVideojuegos
{
    public partial class Form1 : Form
    {
        ArchivoCSV openCsv = new ArchivoCSV();

        List<VideoJuego> ListaVideoJuego = new List<VideoJuego>();
       
        int contador = 0;


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
              MessageBox.Show($"Se Agreg� el videojuego: {video.nombre}", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ReloadDataGrid()
        {
            dgVideoJuegos.DataSource = null;
            //La fuente de datos pase a tener datos
            dgVideoJuegos.DataSource = ListaVideoJuego;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEliminar.Text))
            {
                MessageBox.Show($"Ingrese el nombre del videojuego: ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VideoJuego videoJu = new VideoJuego();
                videoJu.nombre = txtEliminar.Text;
                if (openCsv.DeleteVideoJuego(videoJu, ListaVideoJuego))
                {
                    MessageBox.Show($"Se elimin� el videojuego: {videoJu.nombre}", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadDataGrid();
                }
                else
                {
                    MessageBox.Show($"No se ha podido elminar el videojuego: {videoJu.nombre}", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
           
        }

        private void btnContCantVid_Click(object sender, EventArgs e)
        {
            int cantidad = ListaVideoJuego.Count();
            MessageBox.Show("Cantidad de videojuegos " + cantidad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cantidadPorPlataforma = ListaVideoJuego.Where(s => s.plataforma == cbContCantVidPorPlat.Text).Count() ;
            MessageBox.Show("Cantidad por plataforma es :" + cantidadPorPlataforma);
        }

        

        //int cantidadPorCadena = ListaVideoJuego.Where(s => s.nombre.Contains(txtContCantVidPorCad.Text)).Count();
        //MessageBox.Show("Cantidad por cadena es :" + cantidadPorCadena);

        private void btnMostHor_Click(object sender, EventArgs e)
        {
            string horaActual = DateTime.Now.ToString("HH");
            MessageBox.Show("La hora actual es : " + horaActual);
        }
       

        private void btnNoTocar10vec_Click(object sender, EventArgs e)
        {

            contador++;

            if (contador == 10)
            {
                MessageBox.Show("TE DIJE QUE NO ME PRESIONARAS M�S DE 10 VECES, ADI�S", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
            
        }


      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContPorCadena_Click(object sender, EventArgs e)
        {
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cantidadPorCadena = ListaVideoJuego.Where(s => s.nombre.Contains(txtContCantVidPorCad.Text)).Count();
            MessageBox.Show("Cantidad por cadena es :" + cantidadPorCadena);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                MessageBox.Show($"Ingrese el Nombre del videojuego", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VideoJuego videoJu = new VideoJuego();
                videoJu.nombre = txtBuscar.Text;
                if (openCsv.SearchVideoJuego(videoJu, ListaVideoJuego))
                {

                    MessageBox.Show($"Se encontr� el videojuego : {videoJu.nombre}", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                else
                {
                    MessageBox.Show($"No se encontr� el videojuego : {videoJu.nombre}" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnObtNomUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tu nombre de usuario es: {Environment.UserName}", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}