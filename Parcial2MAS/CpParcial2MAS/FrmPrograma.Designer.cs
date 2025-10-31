namespace CpParcial2MAS
{
    partial class FrmPrograma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrograma));
            this.lblSeries = new System.Windows.Forms.Label();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cbxIdiomaOriginal = new System.Windows.Forms.ComboBox();
            this.lblIdiomaOriginal = new System.Windows.Forms.Label();
            this.txtUrlTrailer = new System.Windows.Forms.TextBox();
            this.lblUrlTrailer = new System.Windows.Forms.Label();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.nudEpisodios = new System.Windows.Forms.NumericUpDown();
            this.lblEpisodios = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.llblSinopsis = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpSinopsis = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDirector = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpEpisodios = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpFechaEstreno = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpUrlTrailer = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpIdiomaOriginal = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUrlTrailer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpIdiomaOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeries
            // 
            this.lblSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.Location = new System.Drawing.Point(-8, 1);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(930, 51);
            this.lblSeries.TabIndex = 0;
            this.lblSeries.Text = "Programas";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxLista
            // 
            this.gbxLista.BackColor = System.Drawing.Color.Transparent;
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(4, 98);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(836, 251);
            this.gbxLista.TabIndex = 23;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Programas";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(10, 22);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(816, 223);
            this.dgvLista.TabIndex = 0;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(12, 69);
            this.txtParametro.MaxLength = 100;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(705, 22);
            this.txtParametro.TabIndex = 21;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.BackColor = System.Drawing.Color.Transparent;
            this.lblParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro.Location = new System.Drawing.Point(12, 49);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(224, 16);
            this.lblParametro.TabIndex = 20;
            this.lblParametro.Text = "Buscar por Título, Productor o Canal:";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAcciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(15, 355);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(815, 47);
            this.pnlAcciones.TabIndex = 24;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::CpParcial2MAS.Properties.Resources.Cerrar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(550, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCerrar.Size = new System.Drawing.Size(100, 40);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::CpParcial2MAS.Properties.Resources.Eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(433, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::CpParcial2MAS.Properties.Resources.Editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(320, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEditar.Size = new System.Drawing.Size(96, 40);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::CpParcial2MAS.Properties.Resources.Añadir;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(206, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnNuevo.Size = new System.Drawing.Size(96, 40);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CpParcial2MAS.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(424, 147);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::CpParcial2MAS.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(297, 147);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CpParcial2MAS.Properties.Resources.Buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(732, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBuscar.Size = new System.Drawing.Size(98, 40);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cbxIdiomaOriginal);
            this.gbxDatos.Controls.Add(this.lblIdiomaOriginal);
            this.gbxDatos.Controls.Add(this.txtUrlTrailer);
            this.gbxDatos.Controls.Add(this.lblUrlTrailer);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.dtpFechaEstreno);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.lblFechaEstreno);
            this.gbxDatos.Controls.Add(this.nudEpisodios);
            this.gbxDatos.Controls.Add(this.lblEpisodios);
            this.gbxDatos.Controls.Add(this.lblDirector);
            this.gbxDatos.Controls.Add(this.llblSinopsis);
            this.gbxDatos.Controls.Add(this.lblTitulo);
            this.gbxDatos.Controls.Add(this.txtDirector);
            this.gbxDatos.Controls.Add(this.txtSinopsis);
            this.gbxDatos.Controls.Add(this.txtTitulo);
            this.gbxDatos.Location = new System.Drawing.Point(15, 411);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(825, 195);
            this.gbxDatos.TabIndex = 73;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // cbxIdiomaOriginal
            // 
            this.cbxIdiomaOriginal.FormattingEnabled = true;
            this.cbxIdiomaOriginal.Items.AddRange(new object[] {
            "Español",
            "Inglés",
            "Chino"});
            this.cbxIdiomaOriginal.Location = new System.Drawing.Point(549, 115);
            this.cbxIdiomaOriginal.Name = "cbxIdiomaOriginal";
            this.cbxIdiomaOriginal.Size = new System.Drawing.Size(186, 24);
            this.cbxIdiomaOriginal.TabIndex = 83;
            // 
            // lblIdiomaOriginal
            // 
            this.lblIdiomaOriginal.AutoSize = true;
            this.lblIdiomaOriginal.BackColor = System.Drawing.Color.Transparent;
            this.lblIdiomaOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaOriginal.Location = new System.Drawing.Point(434, 118);
            this.lblIdiomaOriginal.Name = "lblIdiomaOriginal";
            this.lblIdiomaOriginal.Size = new System.Drawing.Size(100, 16);
            this.lblIdiomaOriginal.TabIndex = 82;
            this.lblIdiomaOriginal.Text = "Idioma Original:";
            // 
            // txtUrlTrailer
            // 
            this.txtUrlTrailer.Location = new System.Drawing.Point(549, 82);
            this.txtUrlTrailer.Name = "txtUrlTrailer";
            this.txtUrlTrailer.Size = new System.Drawing.Size(266, 22);
            this.txtUrlTrailer.TabIndex = 81;
            // 
            // lblUrlTrailer
            // 
            this.lblUrlTrailer.AutoSize = true;
            this.lblUrlTrailer.BackColor = System.Drawing.Color.Transparent;
            this.lblUrlTrailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlTrailer.Location = new System.Drawing.Point(434, 85);
            this.lblUrlTrailer.Name = "lblUrlTrailer";
            this.lblUrlTrailer.Size = new System.Drawing.Size(101, 16);
            this.lblUrlTrailer.TabIndex = 80;
            this.lblUrlTrailer.Text = "URL del Trailer:";
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Location = new System.Drawing.Point(549, 49);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(232, 22);
            this.dtpFechaEstreno.TabIndex = 79;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaEstreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEstreno.Location = new System.Drawing.Point(434, 54);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(116, 16);
            this.lblFechaEstreno.TabIndex = 78;
            this.lblFechaEstreno.Text = "Fecha de Estreno:";
            // 
            // nudEpisodios
            // 
            this.nudEpisodios.Location = new System.Drawing.Point(549, 17);
            this.nudEpisodios.Name = "nudEpisodios";
            this.nudEpisodios.Size = new System.Drawing.Size(122, 22);
            this.nudEpisodios.TabIndex = 77;
            // 
            // lblEpisodios
            // 
            this.lblEpisodios.AutoSize = true;
            this.lblEpisodios.BackColor = System.Drawing.Color.Transparent;
            this.lblEpisodios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodios.Location = new System.Drawing.Point(434, 20);
            this.lblEpisodios.Name = "lblEpisodios";
            this.lblEpisodios.Size = new System.Drawing.Size(45, 16);
            this.lblEpisodios.TabIndex = 76;
            this.lblEpisodios.Text = "Canal:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.BackColor = System.Drawing.Color.Transparent;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(11, 118);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(57, 16);
            this.lblDirector.TabIndex = 75;
            this.lblDirector.Text = "Director:";
            // 
            // llblSinopsis
            // 
            this.llblSinopsis.AutoSize = true;
            this.llblSinopsis.BackColor = System.Drawing.Color.Transparent;
            this.llblSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSinopsis.Location = new System.Drawing.Point(11, 48);
            this.llblSinopsis.Name = "llblSinopsis";
            this.llblSinopsis.Size = new System.Drawing.Size(62, 16);
            this.llblSinopsis.TabIndex = 74;
            this.llblSinopsis.Text = "Sinopsis:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(11, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 73;
            this.lblTitulo.Text = "Título:";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(75, 115);
            this.txtDirector.MaxLength = 100;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(332, 22);
            this.txtDirector.TabIndex = 72;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(75, 45);
            this.txtSinopsis.MaxLength = 5000;
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSinopsis.Size = new System.Drawing.Size(333, 62);
            this.txtSinopsis.TabIndex = 70;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(75, 16);
            this.txtTitulo.MaxLength = 250;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(333, 22);
            this.txtTitulo.TabIndex = 68;
            // 
            // erpTitulo
            // 
            this.erpTitulo.ContainerControl = this;
            // 
            // erpSinopsis
            // 
            this.erpSinopsis.ContainerControl = this;
            // 
            // erpDirector
            // 
            this.erpDirector.ContainerControl = this;
            // 
            // erpEpisodios
            // 
            this.erpEpisodios.ContainerControl = this;
            // 
            // erpFechaEstreno
            // 
            this.erpFechaEstreno.ContainerControl = this;
            // 
            // erpUrlTrailer
            // 
            this.erpUrlTrailer.ContainerControl = this;
            // 
            // erpIdiomaOriginal
            // 
            this.erpIdiomaOriginal.ContainerControl = this;
            // 
            // FrmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 613);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.gbxDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Parcial 2 - Programas :::";
            this.Load += new System.EventHandler(this.FrmPrograma_Load);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUrlTrailer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpIdiomaOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label llblSinopsis;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.NumericUpDown nudEpisodios;
        private System.Windows.Forms.Label lblEpisodios;
        private System.Windows.Forms.ErrorProvider erpTitulo;
        private System.Windows.Forms.ErrorProvider erpSinopsis;
        private System.Windows.Forms.ErrorProvider erpDirector;
        private System.Windows.Forms.ErrorProvider erpEpisodios;
        private System.Windows.Forms.ErrorProvider erpFechaEstreno;
        private System.Windows.Forms.Label lblIdiomaOriginal;
        private System.Windows.Forms.TextBox txtUrlTrailer;
        private System.Windows.Forms.Label lblUrlTrailer;
        private System.Windows.Forms.ComboBox cbxIdiomaOriginal;
        private System.Windows.Forms.ErrorProvider erpUrlTrailer;
        private System.Windows.Forms.ErrorProvider erpIdiomaOriginal;
    }
}

