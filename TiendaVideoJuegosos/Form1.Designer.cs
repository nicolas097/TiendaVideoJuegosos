namespace TiendaVideojuegos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgVideoJuegos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbrirCSV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbPlataforma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnNoTocar10vec = new System.Windows.Forms.Button();
            this.btnMostHor = new System.Windows.Forms.Button();
            this.btnObtNomUsuario = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtCantVidPorCad = new System.Windows.Forms.TextBox();
            this.btnContPorCadena = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtContCantVidPorCad = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbContCantVidPorPlat = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnContCantVid = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVideoJuegos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgVideoJuegos);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnAbrirCSV);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tienda";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgVideoJuegos
            // 
            this.dgVideoJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVideoJuegos.Location = new System.Drawing.Point(26, 223);
            this.dgVideoJuegos.Name = "dgVideoJuegos";
            this.dgVideoJuegos.RowTemplate.Height = 25;
            this.dgVideoJuegos.Size = new System.Drawing.Size(852, 244);
            this.dgVideoJuegos.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generar CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbrirCSV
            // 
            this.btnAbrirCSV.Location = new System.Drawing.Point(398, 42);
            this.btnAbrirCSV.Name = "btnAbrirCSV";
            this.btnAbrirCSV.Size = new System.Drawing.Size(75, 42);
            this.btnAbrirCSV.TabIndex = 4;
            this.btnAbrirCSV.Text = "Abrir CSV";
            this.btnAbrirCSV.UseVisualStyleBackColor = true;
            this.btnAbrirCSV.Click += new System.EventHandler(this.btnAbrirCSV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.cbPlataforma);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Nombre);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Location = new System.Drawing.Point(655, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 167);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 122);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbPlataforma
            // 
            this.cbPlataforma.FormattingEnabled = true;
            this.cbPlataforma.Items.AddRange(new object[] {
            "xone",
            "pc",
            "ps4"});
            this.cbPlataforma.Location = new System.Drawing.Point(28, 93);
            this.cbPlataforma.Name = "cbPlataforma";
            this.cbPlataforma.Size = new System.Drawing.Size(160, 23);
            this.cbPlataforma.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plataforma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(84, 22);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(51, 15);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.txtEliminar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar o eliminar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(28, 90);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(160, 23);
            this.txtBuscar.TabIndex = 2;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(28, 22);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(160, 23);
            this.txtEliminar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(28, 119);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 51);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 23);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnNoTocar10vec);
            this.groupBox7.Controls.Add(this.btnMostHor);
            this.groupBox7.Controls.Add(this.btnObtNomUsuario);
            this.groupBox7.Location = new System.Drawing.Point(253, 371);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(448, 106);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Otras Funciones";
            // 
            // btnNoTocar10vec
            // 
            this.btnNoTocar10vec.Location = new System.Drawing.Point(129, 61);
            this.btnNoTocar10vec.Name = "btnNoTocar10vec";
            this.btnNoTocar10vec.Size = new System.Drawing.Size(191, 23);
            this.btnNoTocar10vec.TabIndex = 2;
            this.btnNoTocar10vec.Text = "NO TOCAR MÁS DE 10 VECES";
            this.btnNoTocar10vec.UseVisualStyleBackColor = true;
            this.btnNoTocar10vec.Click += new System.EventHandler(this.btnNoTocar10vec_Click);
            // 
            // btnMostHor
            // 
            this.btnMostHor.Location = new System.Drawing.Point(251, 32);
            this.btnMostHor.Name = "btnMostHor";
            this.btnMostHor.Size = new System.Drawing.Size(191, 23);
            this.btnMostHor.TabIndex = 1;
            this.btnMostHor.Text = "Mostrar Hora Actual";
            this.btnMostHor.UseVisualStyleBackColor = true;
            this.btnMostHor.Click += new System.EventHandler(this.btnMostHor_Click);
            // 
            // btnObtNomUsuario
            // 
            this.btnObtNomUsuario.Location = new System.Drawing.Point(20, 32);
            this.btnObtNomUsuario.Name = "btnObtNomUsuario";
            this.btnObtNomUsuario.Size = new System.Drawing.Size(191, 23);
            this.btnObtNomUsuario.TabIndex = 0;
            this.btnObtNomUsuario.Text = "Obtener nombre de usuario";
            this.btnObtNomUsuario.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnContCantVid);
            this.groupBox3.Location = new System.Drawing.Point(253, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 338);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funciones Contar";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtCantVidPorCad);
            this.groupBox6.Controls.Add(this.btnContPorCadena);
            this.groupBox6.Location = new System.Drawing.Point(30, 221);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(395, 106);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Contar Por cadena";
            // 
            // txtCantVidPorCad
            // 
            this.txtCantVidPorCad.Location = new System.Drawing.Point(137, 69);
            this.txtCantVidPorCad.Name = "txtCantVidPorCad";
            this.txtCantVidPorCad.Size = new System.Drawing.Size(121, 23);
            this.txtCantVidPorCad.TabIndex = 3;
            this.txtCantVidPorCad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnContPorCadena
            // 
            this.btnContPorCadena.Location = new System.Drawing.Point(78, 22);
            this.btnContPorCadena.Name = "btnContPorCadena";
            this.btnContPorCadena.Size = new System.Drawing.Size(233, 41);
            this.btnContPorCadena.TabIndex = 2;
            this.btnContPorCadena.Text = "Contar cantidad de videojuegos por cadena";
            this.btnContPorCadena.UseVisualStyleBackColor = true;
            this.btnContPorCadena.Click += new System.EventHandler(this.btnContPorCadena_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtContCantVidPorCad);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(30, 221);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(395, 106);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contar Por cadena";
            // 
            // txtContCantVidPorCad
            // 
            this.txtContCantVidPorCad.Location = new System.Drawing.Point(149, 69);
            this.txtContCantVidPorCad.Name = "txtContCantVidPorCad";
            this.txtContCantVidPorCad.Size = new System.Drawing.Size(100, 23);
            this.txtContCantVidPorCad.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Contar cantidad de videojuegos por cadena";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbContCantVidPorPlat);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(30, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 106);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contar Por plataforma";
            // 
            // cbContCantVidPorPlat
            // 
            this.cbContCantVidPorPlat.FormattingEnabled = true;
            this.cbContCantVidPorPlat.Items.AddRange(new object[] {
            "xone",
            "pc",
            "ps4"});
            this.cbContCantVidPorPlat.Location = new System.Drawing.Point(137, 69);
            this.cbContCantVidPorPlat.Name = "cbContCantVidPorPlat";
            this.cbContCantVidPorPlat.Size = new System.Drawing.Size(121, 23);
            this.cbContCantVidPorPlat.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Contar cantidad de videojuegos por plataforma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnContCantVid
            // 
            this.btnContCantVid.Location = new System.Drawing.Point(20, 35);
            this.btnContCantVid.Name = "btnContCantVid";
            this.btnContCantVid.Size = new System.Drawing.Size(233, 23);
            this.btnContCantVid.TabIndex = 0;
            this.btnContCantVid.Text = "Contar cantidad de videojuegos";
            this.btnContCantVid.UseVisualStyleBackColor = true;
            this.btnContCantVid.Click += new System.EventHandler(this.btnContCantVid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 541);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVideoJuegos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private Label label1;
        private Label Nombre;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private TextBox txtBuscar;
        private TextBox txtEliminar;
        private Button btnBuscar;
        private Button btnEliminar;
        private TabPage tabPage2;
        private DataGridView dgVideoJuegos;
        private Button button1;
        private Button btnAbrirCSV;
        private Button btnAgregar;
        private ComboBox cbPlataforma;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox cbContCantVidPorPlat;
        private Button button2;
        private Button btnContCantVid;
        private GroupBox groupBox7;
        private Button btnNoTocar10vec;
        private Button btnMostHor;
        private Button btnObtNomUsuario;
        private GroupBox groupBox6;
        private TextBox txtCantVidPorCad;
        private Button btnContPorCadena;
        private GroupBox groupBox5;
        private TextBox txtContCantVidPorCad;
        private Button button3;
    }
}