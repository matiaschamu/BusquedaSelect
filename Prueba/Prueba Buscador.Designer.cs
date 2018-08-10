namespace BibliotecaMaf.Controles.BusquedaSelect
{
	partial class Prueba_Buscador
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
            this.components = new System.ComponentModel.Container();
            this.labelMax2 = new System.Windows.Forms.Label();
            this.labelMin2 = new System.Windows.Forms.Label();
            this.labelMax1 = new System.Windows.Forms.Label();
            this.labelMin1 = new System.Windows.Forms.Label();
            this.trackBarMin2 = new System.Windows.Forms.TrackBar();
            this.trackBarMax2 = new System.Windows.Forms.TrackBar();
            this.trackBarMin1 = new System.Windows.Forms.TrackBar();
            this.trackBarMax1 = new System.Windows.Forms.TrackBar();
            this.labelMinBuscador = new System.Windows.Forms.Label();
            this.labelCentralBuscador = new System.Windows.Forms.Label();
            this.labelMaxBuscador = new System.Windows.Forms.Label();
            this.trackBarBuscador = new System.Windows.Forms.TrackBar();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.buttonSetMin = new System.Windows.Forms.Button();
            this.buttonSetMax = new System.Windows.Forms.Button();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labelResolucion = new System.Windows.Forms.Label();
            this.comboBoxRepresentacion = new System.Windows.Forms.ComboBox();
            this.labelPorcentajeBuscador = new System.Windows.Forms.Label();
            this.buttonLlenar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.Search1 = new BibliotecaMaf.Controles.BusquedaSelect.Search();
            this.textBoxActualizarEstado = new System.Windows.Forms.TextBox();
            this.timerActualizarEstado = new System.Windows.Forms.Timer(this.components);
            this.trackBarUmbral = new System.Windows.Forms.TrackBar();
            this.labelUmbral = new System.Windows.Forms.Label();
            this.checkBoxUmbral = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBuscador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUmbral)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMax2
            // 
            this.labelMax2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax2.AutoSize = true;
            this.labelMax2.Location = new System.Drawing.Point(526, 9);
            this.labelMax2.Name = "labelMax2";
            this.labelMax2.Size = new System.Drawing.Size(33, 13);
            this.labelMax2.TabIndex = 1;
            this.labelMax2.Text = "Max2";
            // 
            // labelMin2
            // 
            this.labelMin2.AutoSize = true;
            this.labelMin2.Location = new System.Drawing.Point(12, 9);
            this.labelMin2.Name = "labelMin2";
            this.labelMin2.Size = new System.Drawing.Size(30, 13);
            this.labelMin2.TabIndex = 2;
            this.labelMin2.Text = "Min2";
            // 
            // labelMax1
            // 
            this.labelMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax1.AutoSize = true;
            this.labelMax1.Location = new System.Drawing.Point(526, 226);
            this.labelMax1.Name = "labelMax1";
            this.labelMax1.Size = new System.Drawing.Size(33, 13);
            this.labelMax1.TabIndex = 3;
            this.labelMax1.Text = "Max1";
            // 
            // labelMin1
            // 
            this.labelMin1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMin1.AutoSize = true;
            this.labelMin1.Location = new System.Drawing.Point(12, 226);
            this.labelMin1.Name = "labelMin1";
            this.labelMin1.Size = new System.Drawing.Size(30, 13);
            this.labelMin1.TabIndex = 4;
            this.labelMin1.Text = "Min1";
            // 
            // trackBarMin2
            // 
            this.trackBarMin2.Location = new System.Drawing.Point(12, 25);
            this.trackBarMin2.Maximum = 100;
            this.trackBarMin2.Name = "trackBarMin2";
            this.trackBarMin2.Size = new System.Drawing.Size(201, 45);
            this.trackBarMin2.TabIndex = 5;
            this.trackBarMin2.Scroll += new System.EventHandler(this.trackBarMin2_Scroll);
            // 
            // trackBarMax2
            // 
            this.trackBarMax2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarMax2.Location = new System.Drawing.Point(529, 25);
            this.trackBarMax2.Maximum = 100;
            this.trackBarMax2.Name = "trackBarMax2";
            this.trackBarMax2.Size = new System.Drawing.Size(201, 45);
            this.trackBarMax2.TabIndex = 6;
            this.trackBarMax2.Value = 100;
            this.trackBarMax2.Scroll += new System.EventHandler(this.trackBarMax2_Scroll);
            // 
            // trackBarMin1
            // 
            this.trackBarMin1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarMin1.Location = new System.Drawing.Point(15, 242);
            this.trackBarMin1.Maximum = 100;
            this.trackBarMin1.Name = "trackBarMin1";
            this.trackBarMin1.Size = new System.Drawing.Size(201, 45);
            this.trackBarMin1.TabIndex = 7;
            this.trackBarMin1.Scroll += new System.EventHandler(this.trackBarMin1_Scroll);
            // 
            // trackBarMax1
            // 
            this.trackBarMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarMax1.Location = new System.Drawing.Point(529, 242);
            this.trackBarMax1.Maximum = 100;
            this.trackBarMax1.Name = "trackBarMax1";
            this.trackBarMax1.Size = new System.Drawing.Size(201, 45);
            this.trackBarMax1.TabIndex = 8;
            this.trackBarMax1.Value = 100;
            this.trackBarMax1.Scroll += new System.EventHandler(this.trackBarMax1_Scroll);
            // 
            // labelMinBuscador
            // 
            this.labelMinBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMinBuscador.AutoSize = true;
            this.labelMinBuscador.Location = new System.Drawing.Point(224, 471);
            this.labelMinBuscador.Name = "labelMinBuscador";
            this.labelMinBuscador.Size = new System.Drawing.Size(24, 13);
            this.labelMinBuscador.TabIndex = 9;
            this.labelMinBuscador.Text = "Min";
            // 
            // labelCentralBuscador
            // 
            this.labelCentralBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCentralBuscador.AutoSize = true;
            this.labelCentralBuscador.Location = new System.Drawing.Point(224, 484);
            this.labelCentralBuscador.Name = "labelCentralBuscador";
            this.labelCentralBuscador.Size = new System.Drawing.Size(40, 13);
            this.labelCentralBuscador.TabIndex = 10;
            this.labelCentralBuscador.Text = "Central";
            // 
            // labelMaxBuscador
            // 
            this.labelMaxBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaxBuscador.AutoSize = true;
            this.labelMaxBuscador.Location = new System.Drawing.Point(224, 497);
            this.labelMaxBuscador.Name = "labelMaxBuscador";
            this.labelMaxBuscador.Size = new System.Drawing.Size(33, 13);
            this.labelMaxBuscador.TabIndex = 11;
            this.labelMaxBuscador.Text = "Max1";
            // 
            // trackBarBuscador
            // 
            this.trackBarBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarBuscador.Location = new System.Drawing.Point(227, 242);
            this.trackBarBuscador.Maximum = 100;
            this.trackBarBuscador.Name = "trackBarBuscador";
            this.trackBarBuscador.Size = new System.Drawing.Size(201, 45);
            this.trackBarBuscador.TabIndex = 12;
            this.trackBarBuscador.Scroll += new System.EventHandler(this.trackBarBuscador_Scroll);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMin.Location = new System.Drawing.Point(12, 506);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin.TabIndex = 13;
            this.textBoxMin.Text = "Min";
            // 
            // buttonSetMin
            // 
            this.buttonSetMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSetMin.Location = new System.Drawing.Point(113, 506);
            this.buttonSetMin.Name = "buttonSetMin";
            this.buttonSetMin.Size = new System.Drawing.Size(75, 23);
            this.buttonSetMin.TabIndex = 14;
            this.buttonSetMin.Text = "SetMin";
            this.buttonSetMin.UseVisualStyleBackColor = true;
            this.buttonSetMin.Click += new System.EventHandler(this.buttonSetMin_Click_1);
            // 
            // buttonSetMax
            // 
            this.buttonSetMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetMax.Location = new System.Drawing.Point(655, 503);
            this.buttonSetMax.Name = "buttonSetMax";
            this.buttonSetMax.Size = new System.Drawing.Size(75, 23);
            this.buttonSetMax.TabIndex = 16;
            this.buttonSetMax.Text = "SetMax";
            this.buttonSetMax.UseVisualStyleBackColor = true;
            this.buttonSetMax.Click += new System.EventHandler(this.buttonSetMax_Click);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMax.Location = new System.Drawing.Point(554, 503);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 15;
            this.textBoxMax.Text = "Max";
            // 
            // labelResolucion
            // 
            this.labelResolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResolucion.AutoSize = true;
            this.labelResolucion.Location = new System.Drawing.Point(551, 487);
            this.labelResolucion.Name = "labelResolucion";
            this.labelResolucion.Size = new System.Drawing.Size(60, 13);
            this.labelResolucion.TabIndex = 17;
            this.labelResolucion.Text = "Resolucion";
            // 
            // comboBoxRepresentacion
            // 
            this.comboBoxRepresentacion.FormattingEnabled = true;
            this.comboBoxRepresentacion.Items.AddRange(new object[] {
            "Representacion Entera",
            "Representacion por pixel"});
            this.comboBoxRepresentacion.Location = new System.Drawing.Point(257, 25);
            this.comboBoxRepresentacion.Name = "comboBoxRepresentacion";
            this.comboBoxRepresentacion.Size = new System.Drawing.Size(171, 21);
            this.comboBoxRepresentacion.TabIndex = 18;
            this.comboBoxRepresentacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRepresentacion_SelectedIndexChanged);
            // 
            // labelPorcentajeBuscador
            // 
            this.labelPorcentajeBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPorcentajeBuscador.AutoSize = true;
            this.labelPorcentajeBuscador.Location = new System.Drawing.Point(224, 511);
            this.labelPorcentajeBuscador.Name = "labelPorcentajeBuscador";
            this.labelPorcentajeBuscador.Size = new System.Drawing.Size(85, 13);
            this.labelPorcentajeBuscador.TabIndex = 19;
            this.labelPorcentajeBuscador.Text = "ValuePorcentaje";
            // 
            // buttonLlenar
            // 
            this.buttonLlenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLlenar.Location = new System.Drawing.Point(473, 503);
            this.buttonLlenar.Name = "buttonLlenar";
            this.buttonLlenar.Size = new System.Drawing.Size(75, 23);
            this.buttonLlenar.TabIndex = 20;
            this.buttonLlenar.Text = "Rellenar";
            this.buttonLlenar.UseVisualStyleBackColor = true;
            this.buttonLlenar.Click += new System.EventHandler(this.buttonLlenar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(12, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 26);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Location = new System.Drawing.Point(12, 76);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(718, 147);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.Search1;
            // 
            // textBoxActualizarEstado
            // 
            this.textBoxActualizarEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxActualizarEstado.Location = new System.Drawing.Point(12, 279);
            this.textBoxActualizarEstado.Multiline = true;
            this.textBoxActualizarEstado.Name = "textBoxActualizarEstado";
            this.textBoxActualizarEstado.Size = new System.Drawing.Size(350, 189);
            this.textBoxActualizarEstado.TabIndex = 22;
            // 
            // timerActualizarEstado
            // 
            this.timerActualizarEstado.Enabled = true;
            this.timerActualizarEstado.Tick += new System.EventHandler(this.timerActualizarEstado_Tick);
            // 
            // trackBarUmbral
            // 
            this.trackBarUmbral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarUmbral.Location = new System.Drawing.Point(529, 309);
            this.trackBarUmbral.Maximum = 200;
            this.trackBarUmbral.Name = "trackBarUmbral";
            this.trackBarUmbral.Size = new System.Drawing.Size(201, 45);
            this.trackBarUmbral.TabIndex = 23;
            this.trackBarUmbral.Value = 100;
            this.trackBarUmbral.Scroll += new System.EventHandler(this.trackBarUmbral_Scroll);
            // 
            // labelUmbral
            // 
            this.labelUmbral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUmbral.AutoSize = true;
            this.labelUmbral.Location = new System.Drawing.Point(526, 293);
            this.labelUmbral.Name = "labelUmbral";
            this.labelUmbral.Size = new System.Drawing.Size(67, 13);
            this.labelUmbral.TabIndex = 24;
            this.labelUmbral.Text = "Nivel Umbral";
            // 
            // checkBoxUmbral
            // 
            this.checkBoxUmbral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUmbral.AutoSize = true;
            this.checkBoxUmbral.Location = new System.Drawing.Point(599, 292);
            this.checkBoxUmbral.Name = "checkBoxUmbral";
            this.checkBoxUmbral.Size = new System.Drawing.Size(97, 17);
            this.checkBoxUmbral.TabIndex = 25;
            this.checkBoxUmbral.Text = "Mostrar Umbral";
            this.checkBoxUmbral.UseVisualStyleBackColor = true;
            this.checkBoxUmbral.CheckedChanged += new System.EventHandler(this.checkBoxUmbral_CheckedChanged);
            // 
            // Prueba_Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 538);
            this.Controls.Add(this.checkBoxUmbral);
            this.Controls.Add(this.labelUmbral);
            this.Controls.Add(this.trackBarUmbral);
            this.Controls.Add(this.textBoxActualizarEstado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLlenar);
            this.Controls.Add(this.labelPorcentajeBuscador);
            this.Controls.Add(this.comboBoxRepresentacion);
            this.Controls.Add(this.labelResolucion);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.buttonSetMax);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.buttonSetMin);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.labelMaxBuscador);
            this.Controls.Add(this.labelCentralBuscador);
            this.Controls.Add(this.labelMinBuscador);
            this.Controls.Add(this.trackBarMax1);
            this.Controls.Add(this.trackBarMin1);
            this.Controls.Add(this.trackBarMax2);
            this.Controls.Add(this.trackBarMin2);
            this.Controls.Add(this.labelMin1);
            this.Controls.Add(this.labelMax1);
            this.Controls.Add(this.labelMin2);
            this.Controls.Add(this.labelMax2);
            this.Controls.Add(this.trackBarBuscador);
            this.Name = "Prueba_Buscador";
            this.Text = "Prueba_Buscador";
            this.Load += new System.EventHandler(this.Prueba_seek1_Load);
            this.ResizeBegin += new System.EventHandler(this.Prueba_seek1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Prueba_seek1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBuscador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUmbral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private Search Search1;
		private System.Windows.Forms.Label labelMax2;
		private System.Windows.Forms.Label labelMin2;
		private System.Windows.Forms.Label labelMax1;
		private System.Windows.Forms.Label labelMin1;
		private System.Windows.Forms.TrackBar trackBarMin2;
		private System.Windows.Forms.TrackBar trackBarMax2;
		private System.Windows.Forms.TrackBar trackBarMin1;
		private System.Windows.Forms.TrackBar trackBarMax1;
		private System.Windows.Forms.Label labelMinBuscador;
		private System.Windows.Forms.Label labelCentralBuscador;
		private System.Windows.Forms.Label labelMaxBuscador;
		private System.Windows.Forms.TrackBar trackBarBuscador;
		private System.Windows.Forms.TextBox textBoxMin;
		private System.Windows.Forms.Button buttonSetMin;
		private System.Windows.Forms.Button buttonSetMax;
		private System.Windows.Forms.TextBox textBoxMax;
		private System.Windows.Forms.Label labelResolucion;
		private System.Windows.Forms.ComboBox comboBoxRepresentacion;
		private System.Windows.Forms.Label labelPorcentajeBuscador;
		private System.Windows.Forms.Button buttonLlenar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBoxActualizarEstado;
		private System.Windows.Forms.Timer timerActualizarEstado;
        private System.Windows.Forms.TrackBar trackBarUmbral;
        private System.Windows.Forms.Label labelUmbral;
        private System.Windows.Forms.CheckBox checkBoxUmbral;
    }
}