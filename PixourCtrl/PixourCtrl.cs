﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PixourCtrl
{
	/// <summary>
	/// Called when user clicks on a pixel inside this control
	/// </summary>
	/// <param name="color">Color value of the pixel on which user clicked</param>
	public delegate void OnColorPickDelegate(Color color);

	/// <summary>
	/// Custom control for color picking
	/// </summary>
    public partial class PixourCtrl: UserControl
    {
		/// <summary>
		/// How many pixels per row will be fetched
		/// </summary>
		public const int PixelCount = 16;

		// The ubderlying bitmap size
		private static readonly Size BlockSize = new Size(PixelCount, PixelCount);

		// GDI stuff
		Bitmap m_bmp;
		Graphics m_graphics;
		SolidBrush m_brush;

		// Is currently fetching?
		private bool m_fetching = false;

		/// <summary>
		/// Default color to use when errors occurred
		/// </summary>
		public Color DefaultColor { get; set; } = Color.Gray;

		/// <summary>
		/// The callback when user clicks on a pixel inside this control
		/// </summary>
		public OnColorPickDelegate OnColorPick { get; set; }

		/// <summary>
		/// Start/stop fetching, when started, it fetches PixelCount * PixelCount pixels every 0.2s around the cursor
		/// </summary>
		public bool Fetching
		{
			get
			{
				return m_fetching;
			}

			set
			{
				if (m_fetching == value)
				{
					return;
				}

				m_fetching = value;
				timer1.Enabled = m_fetching;
			}
		}		

		public PixourCtrl()
        {
            InitializeComponent();
        }

		private void PixourCtrl_Load(object sender, EventArgs e)
		{
			BackColor = DefaultColor;
			m_bmp = new Bitmap(PixelCount, PixelCount);
			m_graphics = Graphics.FromImage(m_bmp);
			m_brush = new SolidBrush(Color.Black);
			timer1.Enabled = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			UpdatePixels();
		}		

		private void UpdatePixels()
		{
			for (int i = 0; i < PixelCount; i++)
			{
				for (int j = 0; j < PixelCount; j++)
				{
					m_bmp.SetPixel(i, j, DefaultColor);
				}
			}

			Point pt = Control.MousePosition;
			int x = pt.X - PixelCount / 2;
			int y = pt.Y - PixelCount / 2;
			m_graphics.CopyFromScreen(x, y, 0, 0, BlockSize);
			this.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			int width = ClientRectangle.Width / PixelCount;
			if (width < 1)
			{
				return;
			}
			
			for (int i = 0; i < PixelCount; i++)
			{
				for (int j = 0; j < PixelCount; j++)
				{
					m_brush.Color = m_bmp.GetPixel(i, j);					
					e.Graphics.FillRectangle(m_brush, i * width, j * width, width, width);
				}
			}
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);

			MouseEventArgs me = e as MouseEventArgs;
			int x = me.X / PixelCount;
			int y = me.Y / PixelCount;

			Color color;
			try
			{
				color = m_bmp.GetPixel(x, y);
				if (color.IsEmpty || color.Name == "0")
				{
					color = DefaultColor;
				}
			}
			catch
			{
				color = DefaultColor;
			}			

			OnColorPick?.Invoke( color);
		}		
	}
}
