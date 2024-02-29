using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AbinLibs.Controls
{	
    public partial class PixelBoard: UserControl
    {
		/// <summary>
		/// 图像
		/// </summary>
		[Description("Image to draw"), Category("Data")]
		public Bitmap Image
		{ 
			get
			{
				return m_image;
			}

			set
			{
				if (m_image == value)
				{
					return;
				}

				m_image = value;

				bool changed = UpdateSelectedPixel();
				Invalidate();

				if (changed)
				{
					SelectedPixelChanged?.Invoke(this, EventArgs.Empty);
				}				
			}
		}

		/// <summary>
		/// 像素尺寸
		/// </summary>
		[Description("Pixel size"), Category("Appearance")]
		public int PixelSize
		{
			get
			{ 
				return m_pixelSize;
			}
			
			set
			{ 
				if (m_pixelSize != value)
				{
					m_pixelSize = value;
					Invalidate();
				}
			}
		}

		/// <summary>
		/// 选择框颜色
		/// </summary>
		[Description("Selection color"), Category("Appearance")]
		public Color SelectionColor
		{
			get
			{
				return m_selectionColor;
			}

			set
			{
				if (value != m_selectionColor)
				{
					m_selectionColor = value;
					m_pen.Color = m_selectionColor;
					InvalidatePixelRect(m_selectedPixel);
				}
			}
		}

		/// <summary>
		/// 当前选中的像素
		/// </summary>
		public PixelInfo SelectedPixel
		{
			get
			{
				return m_selectedPixel;
			}

			set
			{
				if (value != m_selectedPixel)
				{
					m_selectedPixel = value;
					Invalidate();
					SelectedPixelChanged?.Invoke(this, EventArgs.Empty);
				}
			}
		}

		/// <summary>
		/// 选择像素改变事件
		/// </summary>
		[Description("Selected pixel changed"), Category("Action")]
		public event EventHandler SelectedPixelChanged;		
		

		PixelInfo m_selectedPixel = null;
		Color m_selectionColor = Color.Yellow;
		int m_pixelSize = 10;
		Bitmap m_image = null;
		SolidBrush m_brush = new SolidBrush(Color.Black);
		Pen m_pen = new Pen(Color.Yellow);

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public PixelBoard()
        {
            InitializeComponent();
			m_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			m_pen.Width = 2;			
		}		

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (Image == null)
			{
				return;
			}

			int countX = Math.Min(Width / m_pixelSize, m_image.Width);
			int countY = Math.Min(Height / m_pixelSize, m_image.Height);
			if (countX < 1 || countY < 1)
			{
				return;
			}
		
			for (int x = 0; x < countX; x++)
			{
				for (int y = 0; y < countY; y++)
				{
					m_brush.Color = m_image.GetPixel(x, y);
					var rect = GetPixelRect(x, y);
					e.Graphics.FillRectangle(m_brush, rect);
				}
			}

			if (m_selectedPixel != null)
			{				
				var rect = GetPixelRect(m_selectedPixel.X, m_selectedPixel.Y);
				m_pen.Color = m_selectionColor;
				e.Graphics.DrawRectangle(m_pen, rect);
			}			
		}

		private bool UpdateSelectedPixel()
		{
			if (m_selectedPixel == null)
			{ 
				return false;
			}

			if (m_selectedPixel.X >= m_image.Width || m_selectedPixel.Y >= m_image.Height)
			{
				m_selectedPixel = null;
				return true;
			}

			var oldColor = m_selectedPixel.Color;
			var newColor = m_image.GetPixel(m_selectedPixel.X, m_selectedPixel.Y);
			if (oldColor.R == newColor.R && oldColor.G == newColor.G && oldColor.B == newColor.B)
			{
				return false;
			}

			m_selectedPixel = new PixelInfo()
			{
				X = m_selectedPixel.X,
				Y = m_selectedPixel.Y,
				Color = newColor,
			};

			return true;
		}

		private Rectangle GetPixelRect(int x, int y)
		{
			return new Rectangle(x * m_pixelSize, y * m_pixelSize, m_pixelSize, m_pixelSize);
		}

		private void InvalidatePixelRect(PixelInfo data)
		{
			if (data == null)
			{
				return;
			}

			var rect = GetPixelRect(data.X, data.Y);
			rect.Inflate(1, 1);
			Invalidate(rect);
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);

			var ev = e as MouseEventArgs;
            if (ev.Button != MouseButtons.Left)
            {
				return;
            }

            if (m_image == null)
			{
				return;
			}

			MouseEventArgs arg = e as MouseEventArgs;
			int x = arg.X / PixelSize;
			int y = arg.Y / PixelSize;

			if (x >= m_image.Width || y >= m_image.Height)
			{
				return;
			}

			PixelInfo pixel = new PixelInfo()
			{
				X = x,
				Y = y,
				Color = m_image.GetPixel(x, y),
			};

			InvalidatePixelRect(m_selectedPixel);
			InvalidatePixelRect(pixel);
			m_selectedPixel = pixel;
			SelectedPixelChanged?.Invoke(this, EventArgs.Empty);
		}		
	}
}
