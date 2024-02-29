using System;
using System.Drawing;

namespace AbinLibs.Controls
{
	/// <summary>
	/// 像素信息
	/// </summary>
	public class PixelInfo
	{
		/// <summary>
		/// X坐标
		/// </summary>
		public int X {  get; set; }

		/// <summary>
		/// Y坐标
		/// </summary>
		public int Y { get; set; }

		/// <summary>
		/// 颜色值
		/// </summary>
		public Color Color { get; set; } = Color.Black;
	}
}
