using VideojuegoLib;

namespace TiendaVideojuegos
{
    public partial class Form1 : Form
    {
        ArchivoCSV openCsv = new ArchivoCSV();

        List<VideoJuego> ListaVideoJuego = new List<VideoJuego>();
       
        int contador = 0;

        bool csv = false;

        

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirCSV_Click(object sender, EventArgs e)
        {
          //Se crea un objeto de OpenFileDialog
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "csv files (*.csv)|*.csv";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ListaVideoJuego = openCsv.VideoJuegoListFromCSV(openFile.FileName);
                csv = true;
                ReloadDataGrid();
                
            }
            button1.Enabled = true;
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
            
            if (csv)
            {
                if (SePuedeAgregar())
                {
                    VideoJuego video = new VideoJuego();
                    video.nombre = txtNombre.Text;
                    video.plataforma = cbPlataforma.Text;
                    openCsv.AddVideoJuego(video, ListaVideoJuego);
                    ReloadDataGrid();
                    MessageBox.Show($"Se Agregó el videojuego: {video.nombre}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Cargué el archivo csv", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       private bool SePuedeAgregar()
       {
            if (txtNombre.Text == string.Empty && cbPlataforma.Text == string.Empty)
            {
                MessageBox.Show("No se ha selecionado el nombre ni la plataforma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Introduza un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbPlataforma.Text == string.Empty)
            {
                MessageBox.Show("Seleccione una plataforma.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                return true;
            }

            return false;
            
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
                MessageBox.Show("Ingrese el nombre del videojuego ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VideoJuego videoJu = new VideoJuego();
                videoJu.nombre = txtEliminar.Text;
                if (openCsv.DeleteVideoJuego(videoJu, ListaVideoJuego))
                {
                    MessageBox.Show($"Se eliminó el videojuego: {videoJu.nombre}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadDataGrid();
                }
                else
                {
                    MessageBox.Show($"No se ha podido elminar el videojuego: {videoJu.nombre}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnContCantVid_Click(object sender, EventArgs e)
        {
            if (csv)
            {
                int cantidad = ListaVideoJuego.Count();
                MessageBox.Show($"Cantidad de videojuegos : {cantidad}","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Abra archivo csv", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (csv)
            {
                if (string.IsNullOrEmpty(cbContCantVidPorPlat.Text))
                {
                    MessageBox.Show("Seleccione la plataforma de videojuego", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int cantidadPorPlataforma = ListaVideoJuego.Where(s => s.plataforma == cbContCantVidPorPlat.Text).Count();
                    MessageBox.Show($"Cantidad por plataforma es : {cantidadPorPlataforma}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Abra archivo csv", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        

        //int cantidadPorCadena = ListaVideoJuego.Where(s => s.nombre.Contains(txtContCantVidPorCad.Text)).Count();
        //MessageBox.Show("Cantidad por cadena es :" + cantidadPorCadena);

        private void btnMostHor_Click(object sender, EventArgs e)
        {
            string horaActual = DateTime.Now.ToString("F");
            MessageBox.Show($"La Fecha actual es : {horaActual}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       

        private void btnNoTocar10vec_Click(object sender, EventArgs e)
        {

            contador++;

            if (contador == 10)
            {
                MessageBox.Show("TE DIJE QUE NO ME PRESIONARAS MÁS DE 10 VECES, ADIÓS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            

            if (csv)
            {      

                if (string.IsNullOrEmpty(txtContCantVidPorCad.Text))
                {

                    MessageBox.Show("Ingrese una cadena", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int cantidadPorCadena = ListaVideoJuego.Where(s => s.nombre.Contains(txtContCantVidPorCad.Text)).Count();
                    MessageBox.Show("Cantidad por cadena es :" + cantidadPorCadena);
                }
            }
            else
            {
               MessageBox.Show("Cargue un archivo csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

                    MessageBox.Show($"Se encontró el videojuego : {videoJu.nombre}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                else
                {
                    MessageBox.Show($"No se encontró el videojuego : {videoJu.nombre}" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnObtNomUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tu nombre de usuario es: {Environment.UserName}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbContCantVidPorPlat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}