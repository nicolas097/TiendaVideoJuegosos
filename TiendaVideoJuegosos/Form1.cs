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
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            cbContCantVidPorPlat.Enabled = false;
            btnBuscar.Enabled = false;
            txtBuscar.Enabled = false;
            txtEliminar.Enabled = false;
            txtContCantVidPorCad.Enabled = false;
            cbPlataforma.Enabled = false;
            txtNombre.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            txtContCantVidPorCad.Enabled = false;
            btnContCantVid.Enabled = false;
        }


        private void DisableAndEnabled(bool EstaCargadaLaWea)
        {
            
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
                if (IsReadableCSV(openFile.FileName))
                {
                    ListaVideoJuego = openCsv.VideoJuegoListFromCSV(openFile.FileName);
                    csv = true;
                    ReloadDataGrid();
                    button1.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnAgregar.Enabled = true;
                    cbContCantVidPorPlat.Enabled = true;
                    btnBuscar.Enabled = true;
                    txtBuscar.Enabled = true;
                    txtEliminar.Enabled = true;
                    txtContCantVidPorCad.Enabled = true;
                    cbPlataforma.Enabled = true;
                    txtNombre.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    txtContCantVidPorCad.Enabled = true;
                    btnContCantVid.Enabled = true;
                }
          
            }


        }


        private bool IsReadableCSV(string csvpath)
        {
            bool validFormat = File.ReadAllLines(csvpath)[0].Contains("id,nombre,plataforma");
            bool isEmpty = File.ReadAllLines(csvpath).Length <= 1;

            if (validFormat)
            {
                if (!isEmpty)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El archivo .CSV no contiene datos, int�ntelo con otro archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("El archivo .CSV no tiene el formato correcto, int�ntelo con otro .CSV", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return false;
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
                    MessageBox.Show($"Se Agreg� el videojuego: {video.nombre}", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Cargu� el archivo csv", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (csv)
            {
                int cantidad = ListaVideoJuego.Count();
                MessageBox.Show($"Cantidad de videojuegos : {cantidad}","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Abra archivo csv", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (csv)
            {
                if (string.IsNullOrEmpty(cbContCantVidPorPlat.Text))
                {
                    MessageBox.Show("Seleccione la plataforma de videojuego", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int cantidadPorPlataforma = ListaVideoJuego.Where(s => s.plataforma == cbContCantVidPorPlat.Text).Count();
                    MessageBox.Show($"Cantidad por plataforma es : {cantidadPorPlataforma}", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Abra archivo csv", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        

        //int cantidadPorCadena = ListaVideoJuego.Where(s => s.nombre.Contains(txtContCantVidPorCad.Text)).Count();
        //MessageBox.Show("Cantidad por cadena es :" + cantidadPorCadena);

        private void btnMostHor_Click(object sender, EventArgs e)
        {
            string horaActual = DateTime.Now.ToString("F");
            MessageBox.Show($"La Fecha actual es : {horaActual}", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbContCantVidPorPlat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}