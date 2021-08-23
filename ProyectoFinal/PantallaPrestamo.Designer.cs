namespace ProyectoFinal
{
    partial class PantallaPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrestamo));
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEliminarVentana = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnActualizarVentana = new System.Windows.Forms.Button();
            this.btnBTodosVentana = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCrearVentana = new System.Windows.Forms.Button();
            this.btnBIDVentana = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.imagenPrestamo = new System.Windows.Forms.PictureBox();
            this.cbLibroID = new System.Windows.Forms.ComboBox();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDBDataSet1 = new ProyectoFinal.BibliotecaDBDataSet1();
            this.libroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDBDataSet2 = new ProyectoFinal.BibliotecaDBDataSet2();
            this.cbEstudianteID = new System.Windows.Forms.ComboBox();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCrear = new System.Windows.Forms.Button();
            this.labelEstudianteID = new System.Windows.Forms.Label();
            this.labelLibroID = new System.Windows.Forms.Label();
            this.txtIDPrestamo = new System.Windows.Forms.TextBox();
            this.labelPrestamoID = new System.Windows.Forms.Label();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.labelBuscarID = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.labelEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.estudianteTableAdapter = new ProyectoFinal.BibliotecaDBDataSet1TableAdapters.EstudianteTableAdapter();
            this.libroTableAdapter = new ProyectoFinal.BibliotecaDBDataSet1TableAdapters.LibroTableAdapter();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.estudianteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter1 = new ProyectoFinal.BibliotecaDBDataSet2TableAdapters.EstudianteTableAdapter();
            this.libroTableAdapter1 = new ProyectoFinal.BibliotecaDBDataSet2TableAdapters.LibroTableAdapter();
            this.estudianteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Location = new System.Drawing.Point(200, 506);
            this.dgvPrestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.RowHeadersWidth = 51;
            this.dgvPrestamo.RowTemplate.Height = 24;
            this.dgvPrestamo.Size = new System.Drawing.Size(981, 187);
            this.dgvPrestamo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(600, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prestamo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnEliminarVentana);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnActualizarVentana);
            this.panel2.Controls.Add(this.btnBTodosVentana);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.btnCrearVentana);
            this.panel2.Controls.Add(this.btnBIDVentana);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 631);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 583);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(53, 47);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(0, 631);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(53, 47);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.CadetBlue;
            this.panel6.Location = new System.Drawing.Point(3, 460);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(11, 33);
            this.panel6.TabIndex = 9;
            // 
            // btnEliminarVentana
            // 
            this.btnEliminarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarVentana.FlatAppearance.BorderSize = 0;
            this.btnEliminarVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVentana.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarVentana.Location = new System.Drawing.Point(12, 460);
            this.btnEliminarVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarVentana.Name = "btnEliminarVentana";
            this.btnEliminarVentana.Size = new System.Drawing.Size(181, 33);
            this.btnEliminarVentana.TabIndex = 10;
            this.btnEliminarVentana.Text = "Eliminar";
            this.btnEliminarVentana.UseVisualStyleBackColor = true;
            this.btnEliminarVentana.Click += new System.EventHandler(this.btnEliminarVentana_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Location = new System.Drawing.Point(3, 399);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 33);
            this.panel5.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Location = new System.Drawing.Point(3, 274);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 33);
            this.panel3.TabIndex = 2;
            // 
            // btnActualizarVentana
            // 
            this.btnActualizarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarVentana.FlatAppearance.BorderSize = 0;
            this.btnActualizarVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnActualizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarVentana.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizarVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarVentana.Location = new System.Drawing.Point(12, 399);
            this.btnActualizarVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarVentana.Name = "btnActualizarVentana";
            this.btnActualizarVentana.Size = new System.Drawing.Size(181, 33);
            this.btnActualizarVentana.TabIndex = 8;
            this.btnActualizarVentana.Text = "Actualizar";
            this.btnActualizarVentana.UseVisualStyleBackColor = true;
            this.btnActualizarVentana.Click += new System.EventHandler(this.btnActualizarVentana_Click);
            // 
            // btnBTodosVentana
            // 
            this.btnBTodosVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBTodosVentana.FlatAppearance.BorderSize = 0;
            this.btnBTodosVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnBTodosVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBTodosVentana.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBTodosVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBTodosVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBTodosVentana.Location = new System.Drawing.Point(12, 274);
            this.btnBTodosVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBTodosVentana.Name = "btnBTodosVentana";
            this.btnBTodosVentana.Size = new System.Drawing.Size(181, 33);
            this.btnBTodosVentana.TabIndex = 3;
            this.btnBTodosVentana.Text = "Buscar Todos";
            this.btnBTodosVentana.UseVisualStyleBackColor = true;
            this.btnBTodosVentana.Click += new System.EventHandler(this.btnBTodosVentana_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Location = new System.Drawing.Point(3, 337);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 33);
            this.panel4.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.CadetBlue;
            this.panel9.Location = new System.Drawing.Point(3, 215);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(11, 33);
            this.panel9.TabIndex = 0;
            // 
            // btnCrearVentana
            // 
            this.btnCrearVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearVentana.FlatAppearance.BorderSize = 0;
            this.btnCrearVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnCrearVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearVentana.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearVentana.Location = new System.Drawing.Point(12, 215);
            this.btnCrearVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearVentana.Name = "btnCrearVentana";
            this.btnCrearVentana.Size = new System.Drawing.Size(181, 33);
            this.btnCrearVentana.TabIndex = 1;
            this.btnCrearVentana.Text = "Crear";
            this.btnCrearVentana.UseVisualStyleBackColor = true;
            this.btnCrearVentana.Click += new System.EventHandler(this.btnCrearVentana_Click);
            // 
            // btnBIDVentana
            // 
            this.btnBIDVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBIDVentana.FlatAppearance.BorderSize = 0;
            this.btnBIDVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnBIDVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBIDVentana.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBIDVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBIDVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBIDVentana.Location = new System.Drawing.Point(12, 337);
            this.btnBIDVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBIDVentana.Name = "btnBIDVentana";
            this.btnBIDVentana.Size = new System.Drawing.Size(181, 33);
            this.btnBIDVentana.TabIndex = 5;
            this.btnBIDVentana.Text = "Buscar por ID";
            this.btnBIDVentana.UseVisualStyleBackColor = true;
            this.btnBIDVentana.Click += new System.EventHandler(this.btnBIDVentana_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 34);
            this.panel1.TabIndex = 11;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.White;
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.btnmaximizar);
            this.BarraTitulo.Controls.Add(this.btnrestaurar);
            this.BarraTitulo.Controls.Add(this.btnminimizar);
            this.BarraTitulo.Controls.Add(this.btncerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1181, 28);
            this.BarraTitulo.TabIndex = 10;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(493, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Biblioteca Virtual";
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(1061, 2);
            this.btnmaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmaximizar.TabIndex = 8;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnrestaurar.Image")));
            this.btnrestaurar.Location = new System.Drawing.Point(1061, 2);
            this.btnrestaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnrestaurar.TabIndex = 9;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(1103, 2);
            this.btnminimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(25, 25);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 9;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1147, 2);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 25);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 7;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // imagenPrestamo
            // 
            this.imagenPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagenPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.imagenPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("imagenPrestamo.Image")));
            this.imagenPrestamo.Location = new System.Drawing.Point(540, 161);
            this.imagenPrestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagenPrestamo.Name = "imagenPrestamo";
            this.imagenPrestamo.Size = new System.Drawing.Size(245, 225);
            this.imagenPrestamo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPrestamo.TabIndex = 15;
            this.imagenPrestamo.TabStop = false;
            // 
            // cbLibroID
            // 
            this.cbLibroID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.libroBindingSource, "LibroId", true));
            this.cbLibroID.DataSource = this.libroBindingSource1;
            this.cbLibroID.DisplayMember = "LibroId";
            this.cbLibroID.FormattingEnabled = true;
            this.cbLibroID.Location = new System.Drawing.Point(479, 356);
            this.cbLibroID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLibroID.Name = "cbLibroID";
            this.cbLibroID.Size = new System.Drawing.Size(129, 24);
            this.cbLibroID.TabIndex = 52;
            this.cbLibroID.ValueMember = "LibroId";
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataMember = "Libro";
            this.libroBindingSource.DataSource = this.bibliotecaDBDataSet1;
            // 
            // bibliotecaDBDataSet1
            // 
            this.bibliotecaDBDataSet1.DataSetName = "BibliotecaDBDataSet1";
            this.bibliotecaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libroBindingSource1
            // 
            this.libroBindingSource1.DataMember = "Libro";
            this.libroBindingSource1.DataSource = this.bibliotecaDBDataSet2;
            // 
            // bibliotecaDBDataSet2
            // 
            this.bibliotecaDBDataSet2.DataSetName = "BibliotecaDBDataSet2";
            this.bibliotecaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbEstudianteID
            // 
            this.cbEstudianteID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estudianteBindingSource, "EstudianteId", true));
            this.cbEstudianteID.FormattingEnabled = true;
            this.cbEstudianteID.Location = new System.Drawing.Point(479, 284);
            this.cbEstudianteID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstudianteID.Name = "cbEstudianteID";
            this.cbEstudianteID.Size = new System.Drawing.Size(129, 24);
            this.cbEstudianteID.TabIndex = 51;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.bibliotecaDBDataSet1;
            // 
            // estudianteBindingSource2
            // 
            this.estudianteBindingSource2.DataMember = "Estudiante";
            this.estudianteBindingSource2.DataSource = this.bibliotecaDBDataSet2;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(921, 263);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(165, 57);
            this.btnCrear.TabIndex = 50;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // labelEstudianteID
            // 
            this.labelEstudianteID.AutoSize = true;
            this.labelEstudianteID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstudianteID.Location = new System.Drawing.Point(287, 282);
            this.labelEstudianteID.Name = "labelEstudianteID";
            this.labelEstudianteID.Size = new System.Drawing.Size(126, 23);
            this.labelEstudianteID.TabIndex = 49;
            this.labelEstudianteID.Text = "Estudiante ID";
            // 
            // labelLibroID
            // 
            this.labelLibroID.AutoSize = true;
            this.labelLibroID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibroID.Location = new System.Drawing.Point(307, 354);
            this.labelLibroID.Name = "labelLibroID";
            this.labelLibroID.Size = new System.Drawing.Size(82, 23);
            this.labelLibroID.TabIndex = 48;
            this.labelLibroID.Text = "Libro ID";
            // 
            // txtIDPrestamo
            // 
            this.txtIDPrestamo.Enabled = false;
            this.txtIDPrestamo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPrestamo.Location = new System.Drawing.Point(479, 210);
            this.txtIDPrestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDPrestamo.Name = "txtIDPrestamo";
            this.txtIDPrestamo.Size = new System.Drawing.Size(129, 30);
            this.txtIDPrestamo.TabIndex = 47;
            // 
            // labelPrestamoID
            // 
            this.labelPrestamoID.AutoSize = true;
            this.labelPrestamoID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrestamoID.Location = new System.Drawing.Point(287, 213);
            this.labelPrestamoID.Name = "labelPrestamoID";
            this.labelPrestamoID.Size = new System.Drawing.Size(116, 23);
            this.labelPrestamoID.TabIndex = 46;
            this.labelPrestamoID.Text = "Prestamo ID";
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarTodos.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnBuscarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTodos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTodos.Location = new System.Drawing.Point(581, 438);
            this.btnBuscarTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(165, 57);
            this.btnBuscarTodos.TabIndex = 53;
            this.btnBuscarTodos.Text = "Buscar Todos";
            this.btnBuscarTodos.UseVisualStyleBackColor = false;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarID.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnBuscarID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarID.Location = new System.Drawing.Point(909, 438);
            this.btnBuscarID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(165, 57);
            this.btnBuscarID.TabIndex = 55;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = false;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // labelBuscarID
            // 
            this.labelBuscarID.AutoSize = true;
            this.labelBuscarID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarID.Location = new System.Drawing.Point(276, 455);
            this.labelBuscarID.Name = "labelBuscarID";
            this.labelBuscarID.Size = new System.Drawing.Size(129, 23);
            this.labelBuscarID.TabIndex = 54;
            this.labelBuscarID.Text = "Buscar Por ID";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(921, 254);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(165, 57);
            this.btnActualizar.TabIndex = 57;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // labelEliminar
            // 
            this.labelEliminar.AutoSize = true;
            this.labelEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminar.Location = new System.Drawing.Point(276, 430);
            this.labelEliminar.Name = "labelEliminar";
            this.labelEliminar.Size = new System.Drawing.Size(142, 23);
            this.labelEliminar.TabIndex = 59;
            this.labelEliminar.Text = "Eliminar Por ID";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(909, 418);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 57);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // libroTableAdapter
            // 
            this.libroTableAdapter.ClearBeforeFill = true;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(600, 430);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(132, 22);
            this.txtEliminar.TabIndex = 61;
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(600, 462);
            this.txtBuscarId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(132, 22);
            this.txtBuscarId.TabIndex = 62;
            // 
            // estudianteBindingSource1
            // 
            this.estudianteBindingSource1.DataMember = "Estudiante";
            this.estudianteBindingSource1.DataSource = this.bibliotecaDBDataSet2;
            // 
            // estudianteTableAdapter1
            // 
            this.estudianteTableAdapter1.ClearBeforeFill = true;
            // 
            // libroTableAdapter1
            // 
            this.libroTableAdapter1.ClearBeforeFill = true;
            // 
            // estudianteBindingSource3
            // 
            this.estudianteBindingSource3.DataMember = "Estudiante";
            this.estudianteBindingSource3.DataSource = this.bibliotecaDBDataSet2;
            // 
            // PantallaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 693);
            this.Controls.Add(this.txtBuscarId);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.labelEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.labelBuscarID);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.cbLibroID);
            this.Controls.Add(this.cbEstudianteID);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.labelEstudianteID);
            this.Controls.Add(this.labelLibroID);
            this.Controls.Add(this.txtIDPrestamo);
            this.Controls.Add(this.labelPrestamoID);
            this.Controls.Add(this.imagenPrestamo);
            this.Controls.Add(this.dgvPrestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaPrestamo";
            this.Text = "PantallaPrestamo";
            this.Load += new System.EventHandler(this.PantallaPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEliminarVentana;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnActualizarVentana;
        private System.Windows.Forms.Button btnBTodosVentana;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCrearVentana;
        private System.Windows.Forms.Button btnBIDVentana;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox imagenPrestamo;
        private System.Windows.Forms.ComboBox cbLibroID;
        private System.Windows.Forms.ComboBox cbEstudianteID;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label labelEstudianteID;
        private System.Windows.Forms.Label labelLibroID;
        private System.Windows.Forms.TextBox txtIDPrestamo;
        private System.Windows.Forms.Label labelPrestamoID;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.Label labelBuscarID;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label labelEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private BibliotecaDBDataSet1 bibliotecaDBDataSet1;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private BibliotecaDBDataSet1TableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private BibliotecaDBDataSet1TableAdapters.LibroTableAdapter libroTableAdapter;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtBuscarId;
        private BibliotecaDBDataSet2 bibliotecaDBDataSet2;
        private System.Windows.Forms.BindingSource estudianteBindingSource1;
        private BibliotecaDBDataSet2TableAdapters.EstudianteTableAdapter estudianteTableAdapter1;
        private System.Windows.Forms.BindingSource libroBindingSource1;
        private BibliotecaDBDataSet2TableAdapters.LibroTableAdapter libroTableAdapter1;
        private System.Windows.Forms.BindingSource estudianteBindingSource2;
        private System.Windows.Forms.BindingSource estudianteBindingSource3;
    }
}