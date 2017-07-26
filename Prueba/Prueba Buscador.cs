using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaMaf.Controles.BusquedaSelect
{
	public partial class Prueba_Buscador : Form
	{
		public Prueba_Buscador ()
		{
			InitializeComponent ();
		}

		private void Prueba_seek1_Load(object sender, EventArgs e)
		{
			this.Search1.MovimientoFlechas += new Search.MovimientoHandler(Seek1_Movimiento);
			this.Search1.MovimientoBuscador += new Search.MovimientoBuscadorHandler(Seek1_MovimientoBuscador);
			Search1.MinimoHorizontal = 0;
			Search1.MaximoHorizontal = 100;
			Search1.MinimoVertical = 0;
			Search1.MaximoVertical = 200;
			Search1.ColorPlot = System.Windows.Media.Brushes.Green;
			pictureBox1.BackColor = System.Drawing.Color.FromArgb(System.Windows.Media.Brushes.Green.Color.A, System.Windows.Media.Brushes.Green.Color.R, System.Windows.Media.Brushes.Green.Color.G, System.Windows.Media.Brushes.Green.Color.B);
			textBoxMin.Text = Search1.MinimoHorizontal.ToString();
			textBoxMax.Text = Search1.MaximoHorizontal.ToString();
			comboBoxRepresentacion.SelectedIndex = 0;
			

		}

		private void Seek1_Movimiento(object sender, BusquedaSelect.MovimientoEventArgument e)
		{
			switch (e.Movimiento)
			{
				case MovimientoEventArgument.TipoMovimiento.FlechaVerdeIzq:
					labelMin2.Text = e.Valor.ToString();
                    trackBarMin2.Value =(int) e.Valor;
					break;
				case MovimientoEventArgument.TipoMovimiento.FlechaVerdeDer:
					labelMax2.Text = e.Valor.ToString();
                    trackBarMax2.Value = (int)e.Valor;
					break;
				case MovimientoEventArgument.TipoMovimiento.FlechaRojaIzq:
					labelMin1.Text = e.Valor.ToString();
                    trackBarMin1.Value = (int)e.Valor;
					break;
				case MovimientoEventArgument.TipoMovimiento.FlechaRojaDer:
					labelMax1.Text = e.Valor.ToString();
                    trackBarMax1.Value = (int)e.Valor;
					break;
			}
		}
		private void Seek1_MovimientoBuscador(object sender, BusquedaSelect.MovimientoBuscadorEventArgument e)
		{
			labelMinBuscador.Text = e.Min.ToString();
            labelCentralBuscador.Text = e.Central.ToString();
			labelMaxBuscador.Text = e.Max.ToString();
			labelPorcentajeBuscador.Text = Search1.PorcentajeBuscador.ToString();
			trackBarBuscador.Value = (int)Search1.PorcentajeBuscador;
		}

		private void buttonSetMin_Click_1(object sender, EventArgs e)
		{
			trackBarMin1.Minimum = int.Parse(textBoxMin.Text) - 10;
			trackBarMax1.Minimum = int.Parse(textBoxMin.Text) - 10;
			trackBarMin2.Minimum = int.Parse(textBoxMin.Text) - 10;
			trackBarMax2.Minimum = int.Parse(textBoxMin.Text) - 10;
			trackBarBuscador.Minimum = int.Parse(textBoxMin.Text) - 10;
			Search1.MinimoHorizontal = double.Parse(textBoxMin.Text);
		}
		private void buttonSetMax_Click(object sender, EventArgs e)
		{
			trackBarMin1.Maximum = int.Parse(textBoxMax.Text) + 10;
			trackBarMax1.Maximum = int.Parse(textBoxMax.Text) + 10;
			trackBarMin2.Maximum = int.Parse(textBoxMax.Text) + 10;
			trackBarMax2.Maximum = int.Parse(textBoxMax.Text) + 10;
			trackBarBuscador.Maximum = int.Parse(textBoxMax.Text) + 10;
			Search1.MaximoHorizontal = double.Parse(textBoxMax.Text);
		}

		private void trackBarMin1_Scroll(object sender, EventArgs e)
		{
			Search1.MinimoSel1 = trackBarMin1.Value;
			labelMin1.Text = Search1.MinimoSel1.ToString();
		}
		private void trackBarMax1_Scroll(object sender, EventArgs e)
		{
			Search1.MaximoSel1 = trackBarMax1.Value;
			labelMax1.Text = Search1.MaximoSel1.ToString();
		}
		private void trackBarMin2_Scroll(object sender, EventArgs e)
		{
			Search1.MinimoSel2 = trackBarMin2.Value;
			labelMin2.Text = Search1.MinimoSel2.ToString();
		}
		private void trackBarMax2_Scroll(object sender, EventArgs e)
		{
			Search1.MaximoSel2 = trackBarMax2.Value;
			labelMax2.Text = Search1.MaximoSel2.ToString();
		}

		private void Prueba_seek1_ResizeBegin(object sender, EventArgs e)
		{
			//this.SuspendLayout();
			elementHost1.Visible = false;
		}
		private void Prueba_seek1_ResizeEnd(object sender, EventArgs e)
		{
			//this.ResumeLayout();
			elementHost1.Visible = true;
			labelResolucion.Text = Search1.ResolucionPorPixelHorizontal.ToString();
		}

		private void trackBarBuscador_Scroll(object sender, EventArgs e)
		{
			Search1.PorcentajeBuscador = trackBarBuscador.Value;
			labelPorcentajeBuscador.Text = Search1.PorcentajeBuscador.ToString();
		}

		private void buttonLlenar_Click(object sender, EventArgs e)
		{
			int k = 0;
			int i = 0;
			for (i = 0 ; i < Search1.Valores.Length ; i++)
			{
				Search1.Valores[i].Valores = k;
				Search1.Valores[i].Color = Search1.ColorPlot;
				k++;
				if (k > 200)
				{
					k = 0;

					if (Search1.ColorPlot == System.Windows.Media.Brushes.Red)
					{
						Search1.ColorPlot = System.Windows.Media.Brushes.Yellow;
					}
					else
					{
						if (Search1.ColorPlot == System.Windows.Media.Brushes.Yellow)
						{
							Search1.ColorPlot = System.Windows.Media.Brushes.Green;
						}
						else
						{
							Search1.ColorPlot = System.Windows.Media.Brushes.Red;
						}
					}
				}
			}
			buttonLlenar.Text = i.ToString();
			Search1.Escribir();
		}

		private void comboBoxRepresentacion_SelectedIndexChanged(object sender, EventArgs e)
		{
			Search1.ModoDeRepresentacion = ((Search.eModoRepresentacion)(comboBoxRepresentacion.SelectedIndex));
		}


		private void pictureBox1_DoubleClick(object sender, EventArgs e)
		{
			ColorDialog C = new ColorDialog();
			if (C.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Search1.ColorPlot = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(C.Color.A, C.Color.R, C.Color.G, C.Color.B));
				pictureBox1.BackColor = C.Color;
			}
		}

		private void timerActualizarEstado_Tick(object sender, EventArgs e)
		{
			textBoxActualizarEstado.Text = "Min " + Search1.MinimoHorizontal + "\r\n";
			textBoxActualizarEstado.Text =textBoxActualizarEstado.Text + "Max " + Search1.MaximoHorizontal + "\r\n";
			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Sel1Min " + Search1.MinimoSel1 + "\r\n";
			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Sel1Max " + Search1.MaximoSel1 + "\r\n";
			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Sel2Min " + Search1.MinimoSel2 + "\r\n";
			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Sel2Max " + Search1.MaximoSel2 + "\r\n";

			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Min Vertical " + Search1.MinimoVertical + "\r\n";
			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Max Vertical " + Search1.MaximoVertical + "\r\n";

			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "% Buscador " + Search1.PorcentajeBuscador + "\r\n";
			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Resolucion Horizontal " + Search1.ResolucionHorizontal + "\r\n";
			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Resolucion pixel horizontal " + Search1.ResolucionPorPixelHorizontal + "\r\n";
			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Resolucion Vertical " + Search1.ResolucionVertical + "\r\n";

			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Modo Representacion " + Search1.ModoDeRepresentacion.ToString() + "\r\n";

			textBoxActualizarEstado.Text = textBoxActualizarEstado.Text + "Color " + Search1.ColorPlot.ToString() + "\r\n";
		}
	}
}
