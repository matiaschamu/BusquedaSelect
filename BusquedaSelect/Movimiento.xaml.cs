using System;
using System.Collections.Generic;
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

namespace BibliotecaMaf.Controles.BusquedaSelect
{
	/// <summary>
	/// Lógica de interacción para Movimiento.xaml
	/// </summary>
	public partial class Movimiento : UserControl
	{
		private double mPosicionClickX;
		private Double mPosicionMinima = 7;
		private Double mPosicionMaxima = 293;
		private ReferenciaPosicion mReferenciaAlineacion = ReferenciaPosicion.Lateral;

		private double mPorcentaje = 0.0;

		public delegate void CambioPosicionEventHandler(object sender, CambioPocisionEventArgs e);

		public event CambioPosicionEventHandler CambioPosicion;

		public enum ReferenciaPosicion
		{
			Lateral = 0,
			Central = 1,
		}

		public Movimiento()
		{
			this.InitializeComponent();
		}

		#region Control de eventos

		private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			Point MiPosicion = e.GetPosition(this);
			mPosicionClickX = MiPosicion.X;
		}

		private void UserControl_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				Point MiPosicion = e.GetPosition(this);
				this.CaptureMouse();
				double NuevaUbicacion = this.LocationX + (MiPosicion.X - mPosicionClickX);

				switch (mReferenciaAlineacion)
				{
					case ReferenciaPosicion.Lateral:
						if (NuevaUbicacion < mPosicionMinima)
						{
							NuevaUbicacion = mPosicionMinima;
						}
						else if (NuevaUbicacion + Math.Round(this.ActualWidth) > mPosicionMaxima)
						{
							NuevaUbicacion = mPosicionMaxima - Math.Round(this.ActualWidth);
						}
						break;
					case ReferenciaPosicion.Central:
						if (NuevaUbicacion < mPosicionMinima - (Math.Round(this.ActualWidth)/2))
						{
							NuevaUbicacion = mPosicionMinima - (Math.Round(this.ActualWidth)/2);
						}
						else if (NuevaUbicacion + (Math.Round(this.ActualWidth)/2) > mPosicionMaxima)
						{
							NuevaUbicacion = mPosicionMaxima - (Math.Round(this.ActualWidth)/2);
						}
						break;
				}

				this.LocationX = NuevaUbicacion;
			}
		}

		private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			this.ReleaseMouseCapture();
		}

		#endregion

		#region Propiedades

		public double LocationX
		{
			get { return this.Margin.Left; }
			set
			{
				if (value != Margin.Left)
				{
					this.Margin = new Thickness(value, this.Margin.Top, this.Margin.Right, this.Margin.Bottom);
					CalcularPorcentaje();
					OnCambioPosicion();
				}
			}
		}

		public Double PosicionMinima
		{
			get { return mPosicionMinima; }
			set { mPosicionMinima = value; }
		}

		public Double PosicionMaxima
		{
			get { return mPosicionMaxima; }
			set { mPosicionMaxima = value; }
		}

		public ReferenciaPosicion ReferenciaAlineacion
		{
			get { return mReferenciaAlineacion; }
			set { mReferenciaAlineacion = value; }
		}

		public double Porcentaje
		{
			get { return mPorcentaje; }
			set
			{
				if (double.IsNaN(value))
				{
					return;
				}

				double mPorcentajeOLD = mPorcentaje;

				mPorcentaje = value;

				double NuevaUbicacion = 0.0;
				switch (mReferenciaAlineacion)
				{
					case ReferenciaPosicion.Central:
						if (value < 0)
						{
							NuevaUbicacion = mPosicionMinima - (Math.Round(this.ActualWidth)/2);
						}
						else if (value > 100)
						{
							NuevaUbicacion = mPosicionMaxima - (Math.Round(this.ActualWidth)/2);
						}
						else
						{
							NuevaUbicacion = (value*(mPosicionMaxima - mPosicionMinima)/100) + mPosicionMinima - (Math.Round(this.ActualWidth)/2);
						}
						break;
					case ReferenciaPosicion.Lateral:
						if (value < 0)
						{
							NuevaUbicacion = mPosicionMinima;
						}
						else if (value > 100)
						{
							NuevaUbicacion = mPosicionMaxima - Math.Round(this.ActualWidth);
						}
						else
						{
							NuevaUbicacion = (value*(mPosicionMaxima - mPosicionMinima - Math.Round(this.ActualWidth))/100) + mPosicionMinima;
						}
						break;
				}

				if (NuevaUbicacion != this.LocationX)
				{
					this.Margin = new Thickness(NuevaUbicacion, this.Margin.Top, this.Margin.Right, this.Margin.Bottom);
					//OnCambioPosicion();
				}

				if (mPorcentajeOLD != value)
				{
					OnCambioPosicion();
				}
			}
		}

		#endregion

		#region Disparo de eventos

		private void OnCambioPosicion()
		{
			if (CambioPosicion != null)
			{
				CambioPocisionEventArgs mPos = new CambioPocisionEventArgs(0, mPosicionMaxima - mPosicionMinima, this.LocationX - mPosicionMinima, mReferenciaAlineacion, Math.Round(this.ActualWidth), this.Porcentaje);
				CambioPosicion(this, mPos);
			}
		}

		#endregion

		#region Rutinas

		private void CalcularPorcentaje()
		{
			switch (mReferenciaAlineacion)
			{
				case ReferenciaPosicion.Central:
					mPorcentaje = (100*(this.LocationX - (mPosicionMinima - (this.ActualWidth/2))))/(mPosicionMaxima - mPosicionMinima);
					break;
				case ReferenciaPosicion.Lateral:
					mPorcentaje = (100*(this.LocationX - mPosicionMinima))/(mPosicionMaxima - mPosicionMinima - this.ActualWidth);
					break;
			}
		}

		#endregion
	}

	public class CambioPocisionEventArgs
	{
		public double Min = 0;
		public double Max = 0;
		public double ValueWindowsMed = 0;
		public double ValueWindowsMin = 0;
		public double ValueWindowsMax = 0;
		public Movimiento.ReferenciaPosicion Alineacion = Movimiento.ReferenciaPosicion.Central;
		public double ValuePorcentaje = 0;
		public double Width = 0;
		public double PorcentajeWidth = 0;
		public double ValueWindowsMedPorcentaje = 0;
		public double ValueWindowsMinPorcentaje = 0;
		public double ValueWindowsMaxPorcentaje = 0;

		public CambioPocisionEventArgs(double mMin, double mMax, double valueWindowsMin, Movimiento.ReferenciaPosicion alineacion, double width, double porcentaje)
		{
			Min = mMin;
			Max = mMax;
			ValueWindowsMin = valueWindowsMin;
			ValueWindowsMax = valueWindowsMin + width;
			ValueWindowsMed = valueWindowsMin + (width/2);
			Alineacion = alineacion;
			ValuePorcentaje = porcentaje;
			Width = width;
			PorcentajeWidth = Width*100/(Max - Min);

			ValueWindowsMedPorcentaje = ValueWindowsMed*100/(mMax - mMin);
			ValueWindowsMinPorcentaje = ValueWindowsMin*100/(mMax - mMin);
			ValueWindowsMaxPorcentaje = ValueWindowsMax*100/(mMax - mMin);
		}
	}
}
