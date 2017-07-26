using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BibliotecaMaf.Controles.BusquedaSelect;
using MessageBox = System.Windows.Forms.MessageBox;

namespace BibliotecaMaf.Controles.BusquedaSelect
{
	/// <summary>
	/// Lógica de interacción para UserControl1.xaml
	/// </summary>
	public partial class Search : UserControl
	{
		private double mMaximoHorizontal = 1;
		private double mMinimoHorizontal = 0;
		private double mMaximoVertical = 100;
		private double mMinimoVertical = 0;
		private double mMaximoSel1 = 1;
		private double mMinimoSel1 = 0;
		private double mMaximoSel2 = 1;
		private double mMinimoSel2 = 0;
		private double mMaximoVentana = 0;
		private double mMinimoVentana = 0;
		private System.Windows.Media.SolidColorBrush mColorPlot = Brushes.Green;
		
		private sDatoPlot[] mValores = new sDatoPlot[2];

		public struct sDatoPlot
		{
			public int Valores;
			public System.Windows.Media.SolidColorBrush Color;
		}

		public enum eModoRepresentacion
		{
			PorMaximoMinimo = 0,
			PorPixel = 1
		}

		private eModoRepresentacion mModoRepresentacion = eModoRepresentacion.PorMaximoMinimo;

		public delegate void MovimientoHandler(object sender, BusquedaSelect.MovimientoEventArgument e);

		public delegate void MovimientoBuscadorHandler(object sender, BusquedaSelect.MovimientoBuscadorEventArgument e);

		public event MovimientoHandler MovimientoFlechas;
		public event MovimientoHandler MovimientoFlechasSupIzq;
		public event MovimientoHandler MovimientoFlechasSupDer;
		public event MovimientoHandler MovimientoFlechasInfIzq;
		public event MovimientoHandler MovimientoFlechasInfDer;
		public event MovimientoBuscadorHandler MovimientoBuscador;



		#region Propiedades

		public System.Windows.Media.SolidColorBrush ColorPlot
		{
			get { return mColorPlot; }
			set { mColorPlot = value; }
		}

		public double MaximoHorizontal
		{
			get { return mMaximoHorizontal; }
			set
			{
				//DONE que se actualize las flechas cuando cambio el max
				mMaximoHorizontal = value;
				CambiarArrayValores();
				MaximoSel1 = MaximoSel2 = mMaximoHorizontal;
			}
		}

		private void CambiarArrayValores()
		{
			if (ModoDeRepresentacion == eModoRepresentacion.PorMaximoMinimo)
			{
				System.Array.Resize(ref mValores, (int) (mMaximoHorizontal - mMinimoHorizontal));
			}
		}

		public double MinimoHorizontal
		{
			get { return mMinimoHorizontal; }
			set
			{
				//DONE que se actualize las flechas cuando cambio el min
				mMinimoHorizontal = value;
				CambiarArrayValores();
				MinimoSel1 = MinimoSel2 = mMinimoHorizontal;
			}
		}

		public double MaximoVertical
		{
			get { return mMaximoVertical; }
			set
			{
				//DONE que se actualize las flechas cuando cambio el max
				mMaximoVertical = value;
			}
		}

		public double MinimoVertical
		{
			get { return mMinimoVertical; }
			set
			{
				//DONE que se actualize las flechas cuando cambio el min
				mMinimoVertical = value;
			}
		}

		public bool MostrarSelectorSuperiorDerecho
		{
			get
			{
				if (FlechaArribaDer.Visibility == Visibility.Visible)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			set
			{
				if (value == false)
				{
					FlechaArribaDer.Visibility = System.Windows.Visibility.Hidden;
				}
				else
				{
					FlechaArribaDer.Visibility = System.Windows.Visibility.Visible;
				}
			}
		}

		public bool MostrarSelectorSuperiorIzquierdo
		{
			get
			{
				if (FlechaArribaIzq.Visibility == Visibility.Visible)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			set
			{
				if (value == false)
				{
					FlechaArribaIzq.Visibility = System.Windows.Visibility.Hidden;
				}
				else
				{
					FlechaArribaIzq.Visibility = System.Windows.Visibility.Visible;
				}
			}
		}

		public bool MostrarSelectorInferiorDerecho
		{
			get
			{
				if (FlechaAbajoDer.Visibility == Visibility.Visible)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			set
			{
				if (value == false)
				{
					FlechaAbajoDer.Visibility = System.Windows.Visibility.Hidden;
				}
				else
				{
					FlechaAbajoDer.Visibility = System.Windows.Visibility.Visible;
				}
			}
		}

		public bool MostrarSelectorInferiorIzquierdo
		{
			get
			{
				if (FlechaAbajoIzq.Visibility == Visibility.Visible)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			set
			{
				if (value == false)
				{
					FlechaAbajoIzq.Visibility = System.Windows.Visibility.Hidden;
				}
				else
				{
					FlechaAbajoIzq.Visibility = System.Windows.Visibility.Visible;
				}
			}
		}

		public bool MostrarBuscador
		{
			get
			{
				if (Buscador.Visibility == Visibility.Visible)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			set
			{
				if (value == false)
				{
					Buscador.Visibility = System.Windows.Visibility.Hidden;
				}
				else
				{
					Buscador.Visibility = System.Windows.Visibility.Visible;
				}
			}
		}

		public double MaximoSel1
		{
			get { return mMaximoSel1; }
			set
			{
				mMaximoSel1 = LimitarValoresPropiedad(value);
				FlechaAbajoDer.Porcentaje = (value - mMinimoHorizontal)*100/(mMaximoHorizontal - mMinimoHorizontal);
				VerificarFlechaAbajoDer();
			}
		}

		public double MinimoSel1
		{
			get { return mMinimoSel1; }
			set
			{
				mMinimoSel1 = LimitarValoresPropiedad(value);
				FlechaAbajoIzq.Porcentaje = (value - mMinimoHorizontal)*100/(mMaximoHorizontal - mMinimoHorizontal);
				VerificarFlechaAbajoIzq();
			}
		}

		public double MaximoSel2
		{
			get { return mMaximoSel2; }
			set
			{
				mMaximoSel2 = LimitarValoresPropiedad(value);
				FlechaArribaDer.Porcentaje = (value - mMinimoHorizontal)*100/(mMaximoHorizontal - mMinimoHorizontal);
				VerificarFlechaArribaDer();
			}
		}

		public double MinimoSel2
		{
			get { return mMinimoSel2; }
			set
			{
				mMinimoSel2 = LimitarValoresPropiedad(value);
				FlechaArribaIzq.Porcentaje = (value - mMinimoHorizontal)*100/(mMaximoHorizontal - mMinimoHorizontal);
				VerificarFlechaArribaIzq();
			}
		}

		public double PorcentajeBuscador
		{
			get { return Buscador.Porcentaje; }
			set
			{
				//if (Buscador.Porcentaje != value)
				//{
					Buscador.Porcentaje = value;
				//}
			}
		}

		public sDatoPlot[] Valores
		{
			get { return mValores; }
		}

		public void SetLengthValores(int length)
		{
			mValores = new sDatoPlot[length];
		}

		public void SetValores(int[] Valores, int StartIndex, System.Windows.Media.SolidColorBrush Color)
		{
			if (Valores != null)
			{
				for (int i = 0; i < Valores.Length; i++)
				{
					if (mValores.Length > StartIndex + i)
					{
						mValores[i].Valores = Valores[i];
						mValores[i].Color = Color;
					}
				}
				Escribir();
			}
		}

		public int ResolucionHorizontal
		{
			get { return (int) GrillaAudio.ActualWidth; }
		}

		public int ResolucionVertical
		{
			get { return (int) GrillaAudio.ActualHeight; }
		}

		public double ResolucionPorPixelHorizontal
		{
			get { return ((mMaximoHorizontal - mMinimoHorizontal)/GrillaAudio.ActualWidth); }
		}

		public eModoRepresentacion ModoDeRepresentacion
		{
			get { return (mModoRepresentacion); }
			set
			{
				mModoRepresentacion = value;
				switch (value)
				{
					case eModoRepresentacion.PorMaximoMinimo:
						Array.Resize(ref mValores, (int) (mMaximoHorizontal - mMinimoHorizontal));
						break;
					case eModoRepresentacion.PorPixel:
						Array.Resize(ref mValores, ResolucionHorizontal);
						break;
				}
			}
		}

		#endregion

		#region Rutinas

		public Search()
		{
			try
			{
				InitializeComponent();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message.ToString() + e.Source.ToString() + e.StackTrace.ToString());
				throw;
			}
		}

		public void Clear()
		{
			GrillaAudio.Children.Clear();
		}

		private double LimitarValoresPropiedad(double valor)
		{
			if (valor > mMaximoHorizontal)
			{
				return mMaximoHorizontal;
			}
			else if (valor < mMinimoHorizontal)
			{
				return mMinimoHorizontal;
			}
			else
			{
				return valor;
			}
		}

		public void Escribir()
		{
			GrillaAudio.Children.Clear();
			//return;
			for (int i = 0; i < ResolucionHorizontal; i++)
			{
				Path myPath;
				myPath = new Path();
				myPath.Stroke = System.Windows.Media.Brushes.Black;
				myPath.Fill = mColorPlot;
				myPath.StrokeThickness = 0;
				myPath.HorizontalAlignment = HorizontalAlignment.Left;
				myPath.Height = double.NaN;
				myPath.VerticalAlignment = VerticalAlignment.Center;
				myPath.Margin = new Thickness(0, 5, 0, 5);
				try
				{
					if (GrillaAudio.ActualHeight > 12)
					{
						int k = 0;
						switch (mModoRepresentacion)
						{
							case eModoRepresentacion.PorMaximoMinimo:
								k = (int) ((i*(MaximoHorizontal - MinimoHorizontal)/ResolucionHorizontal));
								break;
							case eModoRepresentacion.PorPixel:
								k = (int)((i * (mValores.Length) / ResolucionHorizontal));
								//k = i;
								break;
						}


						if (mValores[k].Color != null)
						{
							myPath.Fill = mValores[k].Color;
						}

						int ValorVertical = (int) ((mValores[k].Valores - (mMinimoVertical))*(GrillaAudio.ActualHeight - 12)/(mMaximoVertical - mMinimoVertical));

						if (ValorVertical == 0)
						{
							//if (mValores[k].Valores > 0)
							//{
								ValorVertical = 1;
							//}
						}


						RectangleGeometry Rectangulo = new RectangleGeometry(new Rect(i, 0, 1, ValorVertical));
						myPath.Data = Rectangulo;
						GrillaAudio.Children.Add(myPath);
					}
				}
				catch
				{

				}
			}
			Canvas.SetZIndex(Buscador, 1);
		}

		private double AjustarValores(CambioPocisionEventArgs e)
		{
			return ((mMaximoHorizontal - mMinimoHorizontal)*e.ValuePorcentaje/100) + mMinimoHorizontal;
		}

		private void InicializarFlechas()
		{
			FlechaArribaIzq.PosicionMaxima = GrillaAudio.ActualWidth + 7;
			FlechaArribaDer.PosicionMaxima = GrillaAudio.ActualWidth + 7;
			FlechaAbajoIzq.PosicionMaxima = GrillaAudio.ActualWidth + 7;
			FlechaAbajoDer.PosicionMaxima = GrillaAudio.ActualWidth + 7;
			Buscador.PosicionMaxima = GrillaAudio.ActualWidth + 7;
		}

		private void VerificarFlechaArribaIzq()
		{
			if (FlechaArribaDer.LocationX < FlechaArribaIzq.LocationX)
			{
				CambiarPosicionFlechaArribaDer(FlechaArribaIzq.LocationX, mMinimoSel2);
			}
			if (FlechaAbajoIzq.LocationX > FlechaArribaIzq.LocationX)
			{
				CambiarPosicionFlechaAbajoIzq(FlechaArribaIzq.LocationX, mMinimoSel2);
			}
			if (FlechaAbajoDer.LocationX < FlechaArribaIzq.LocationX)
			{
				CambiarPosicionFlechaAbajoDer(FlechaArribaIzq.LocationX, mMinimoSel2);
			}
		}

		private void VerificarFlechaArribaDer()
		{
			if (FlechaArribaIzq.LocationX > FlechaArribaDer.LocationX)
			{
				CambiarPosicionFlechaArribaIzq(FlechaArribaDer.LocationX, mMaximoSel2);
			}
			if (FlechaAbajoDer.LocationX < FlechaArribaDer.LocationX)
			{
				CambiarPosicionFlechaAbajoDer(FlechaArribaDer.LocationX, mMaximoSel2);
			}
			if (FlechaAbajoIzq.LocationX > FlechaArribaDer.LocationX)
			{
				CambiarPosicionFlechaAbajoIzq(FlechaArribaDer.LocationX, mMaximoSel2);
			}
		}

		private void VerificarFlechaAbajoIzq()
		{
			if (FlechaArribaIzq.LocationX < FlechaAbajoIzq.LocationX)
			{
				CambiarPosicionFlechaArribaIzq(FlechaAbajoIzq.LocationX, mMinimoSel1);
			}
			if (FlechaArribaDer.LocationX < FlechaAbajoIzq.LocationX)
			{
				CambiarPosicionFlechaArribaDer(FlechaAbajoIzq.LocationX, mMinimoSel1);
			}
			if (FlechaAbajoDer.LocationX < FlechaAbajoIzq.LocationX)
			{
				CambiarPosicionFlechaAbajoDer(FlechaAbajoIzq.LocationX, mMinimoSel1);
			}
		}

		private void VerificarFlechaAbajoDer()
		{
			if (FlechaArribaDer.LocationX > FlechaAbajoDer.LocationX)
			{
				CambiarPosicionFlechaArribaDer(FlechaAbajoDer.LocationX, mMaximoSel1);
			}
			if (FlechaArribaIzq.LocationX > FlechaAbajoDer.LocationX)
			{
				CambiarPosicionFlechaArribaIzq(FlechaAbajoDer.LocationX, mMaximoSel1);
			}
			if (FlechaAbajoIzq.LocationX > FlechaAbajoDer.LocationX)
			{
				CambiarPosicionFlechaAbajoIzq(FlechaAbajoDer.LocationX, mMaximoSel1);
			}
		}

		private void CambiarPosicionFlechaAbajoIzq(double posicionFlecha, double valorRelativo)
		{
			FlechaAbajoIzq.LocationX = posicionFlecha;
			mMinimoSel1 = valorRelativo;
			onMovimientoFlechas(MovimientoEventArgument.TipoMovimiento.FlechaRojaIzq, valorRelativo);
		}

		private void CambiarPosicionFlechaAbajoDer(double posicionFlecha, double valorRelativo)
		{
			FlechaAbajoDer.LocationX = posicionFlecha;
			mMaximoSel1 = valorRelativo;
			onMovimientoFlechas(MovimientoEventArgument.TipoMovimiento.FlechaRojaDer, valorRelativo);
		}

		private void CambiarPosicionFlechaArribaIzq(double posicionFlecha, double valorRelativo)
		{
			FlechaArribaIzq.LocationX = posicionFlecha;
			mMinimoSel2 = valorRelativo;
			onMovimientoFlechas(MovimientoEventArgument.TipoMovimiento.FlechaVerdeIzq, valorRelativo);
		}

		private void CambiarPosicionFlechaArribaDer(double posicionFlecha, double valorRelativo)
		{
			FlechaArribaDer.LocationX = posicionFlecha;
			mMaximoSel2 = valorRelativo;
			onMovimientoFlechas(MovimientoEventArgument.TipoMovimiento.FlechaVerdeDer, valorRelativo);
		}

		#endregion

		#region Control Eventos

		private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
		{
			InicializarFlechas();
			Escribir();
		}

		private void Buscador_CambioPosicion(object sender, CambioPocisionEventArgs e)
		{
			mMinimoVentana = (e.ValueWindowsMinPorcentaje * (MaximoHorizontal - MinimoHorizontal) / 100) + MinimoHorizontal;
			mMaximoVentana = (e.ValueWindowsMaxPorcentaje * (MaximoHorizontal - MinimoHorizontal) / 100) + MinimoHorizontal;
			onMovimientoBuscador(mMinimoVentana, mMaximoVentana);
		}

		private void FlechaArribaIzq_CambioPosicion(object sender, CambioPocisionEventArgs e)
		{
			mMinimoSel2 = AjustarValores(e);
			onMovimientoFlechas(MovimientoEventArgument.TipoMovimiento.FlechaVerdeIzq, mMinimoSel2);
			onMovimientoFlechaSupIzq(mMinimoSel2);
			VerificarFlechaArribaIzq();
		}

		private void FlechaArribaDer_CambioPosicion(object sender, CambioPocisionEventArgs e)
		{
			mMaximoSel2 = AjustarValores(e);
			onMovimientoFlechas(MovimientoEventArgument.TipoMovimiento.FlechaVerdeDer, mMaximoSel2);
			onMovimientoFlechaSupDer(mMaximoSel2);
			VerificarFlechaArribaDer();
		}

		private void FlechaAbajoIzq_CambioPosicion(object sender, CambioPocisionEventArgs e)
		{
			mMinimoSel1 = AjustarValores(e);
			onMovimientoFlechas(MovimientoEventArgument.TipoMovimiento.FlechaRojaIzq, mMinimoSel1);
			onMovimientoFlechaInfIzq(mMinimoSel1);
			VerificarFlechaAbajoIzq();
		}

		private void FlechaAbajoDer_CambioPosicion(object sender, CambioPocisionEventArgs e)
		{
			mMaximoSel1 = AjustarValores(e);
			onMovimientoFlechas(MovimientoEventArgument.TipoMovimiento.FlechaRojaDer, mMaximoSel1);
			onMovimientoFlechaInfDer(mMaximoSel1);
			VerificarFlechaAbajoDer();
		}

		private void Grilla_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			InicializarFlechas();
			if (e.PreviousSize.Width < e.NewSize.Width)
			{
				MaximoSel1 = MaximoSel1;
				MaximoSel2 = MaximoSel2;
				MinimoSel2 = MinimoSel2;
				MinimoSel1 = MinimoSel1;
			}
			else
			{
				MinimoSel1 = MinimoSel1;
				MinimoSel2 = MinimoSel2;
				MaximoSel2 = MaximoSel2;
				MaximoSel1 = MaximoSel1;
			}
			PorcentajeBuscador = PorcentajeBuscador;
			if (mModoRepresentacion == eModoRepresentacion.PorPixel)
			{
				//sDatoPlot[] Temp = mValores;
				//Array.Resize(ref mValores, ResolucionHorizontal);

				//for (int i = 0 ; i < mValores.Length ; i++)
				//{
				//	mValores[i] = Temp[i * Temp.Length / mValores.Length];
				//}
			}
			Escribir();
		}

		#endregion

		#region Disparo Eventos

		private void onMovimientoBuscador(double ValorMin, double ValorMax)
		{
			if (MovimientoBuscador != null)
			{
				MovimientoBuscador(this, new BusquedaSelect.MovimientoBuscadorEventArgument(ValorMin, ValorMax));
			}
		}

		private void onMovimientoFlechas(BusquedaSelect.MovimientoEventArgument.TipoMovimiento TiposMovimientos, double Valor)
		{
			if (MovimientoFlechas != null)
			{
				MovimientoFlechas(this, new BusquedaSelect.MovimientoEventArgument(TiposMovimientos, Valor));
			}
		}

		private void onMovimientoFlechaSupIzq(double Valor)
		{
			if (MovimientoFlechasSupIzq != null)
			{
				MovimientoFlechasSupIzq(this, new BusquedaSelect.MovimientoEventArgument(MovimientoEventArgument.TipoMovimiento.FlechaVerdeIzq, Valor));
			}
		}

		private void onMovimientoFlechaSupDer(double Valor)
		{
			if (MovimientoFlechasSupDer != null)
			{
				MovimientoFlechasSupDer(this, new BusquedaSelect.MovimientoEventArgument(MovimientoEventArgument.TipoMovimiento.FlechaVerdeDer, Valor));
			}
		}

		private void onMovimientoFlechaInfIzq(double Valor)
		{
			if (MovimientoFlechasInfIzq != null)
			{
				MovimientoFlechasInfIzq(this, new BusquedaSelect.MovimientoEventArgument(MovimientoEventArgument.TipoMovimiento.FlechaRojaIzq, Valor));
			}
		}

		private void onMovimientoFlechaInfDer(double Valor)
		{
			if (MovimientoFlechasInfDer != null)
			{
				MovimientoFlechasInfDer(this, new BusquedaSelect.MovimientoEventArgument(MovimientoEventArgument.TipoMovimiento.FlechaRojaDer, Valor));
			}
		}

		#endregion
	}

	#region Clases de eventos

	public class MovimientoEventArgument : System.EventArgs
	{
		public enum TipoMovimiento
		{
			FlechaVerdeIzq = 0,
			FlechaVerdeDer = 1,
			FlechaRojaIzq = 2,
			FlechaRojaDer = 3
		}

		public TipoMovimiento Movimiento;
		public double Valor;

		public MovimientoEventArgument(TipoMovimiento Mov, double Valor)
		{
			Movimiento = Mov;
			this.Valor = Valor;
		}
	}

	public class MovimientoBuscadorEventArgument : System.EventArgs
	{

		public double Max;
		public double Central;
		public double Min;

		public MovimientoBuscadorEventArgument(double ValorMin, double ValorMax)
		{
			Max = ValorMax;
			Central = ((ValorMax - ValorMin)/2) + ValorMin;
			Min = ValorMin;
		}
	}

	#endregion
}