using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3_WinForms
{
	internal class HoverButton : Button
	{
		private Color _color = Color.SkyBlue;

		public HoverButton()
		{
			ForeColor = Color.White;
			Font = new Font("Microsoft YaHei UI",
				16F,
				FontStyle.Bold,
				GraphicsUnit.Point,
				0);
			TextAlign = ContentAlignment.MiddleCenter;
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			// отрисовка прямоугольника

			pe.Graphics.FillRectangle(new SolidBrush(_color), ClientRectangle);
			// отрисовка текста
			pe.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			_color = Color.Blue;
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			_color = Color.SkyBlue;
		}
	}
}