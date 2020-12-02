using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab3_WinForms
{
	internal class RoundedImageGallery : ImageGallery
	{
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			var graphicsPath = new GraphicsPath();
			graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
			Region = new Region(graphicsPath);
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			if (_currentImage == -1 && ImageList.Count != 0) _currentImage = 0;
			if (_currentImage > -1) pe.Graphics.DrawImage(ImageList[_currentImage], pe.ClipRectangle);
			else return;
			if (_isMouseOver)
			{
				pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, Color.White)), pe.ClipRectangle);
				var rect = new Rectangle(ClientRectangle.X, ClientRectangle.Height / 2 - 30, ClientRectangle.Width, 60);
				pe.Graphics.FillRectangle(Brushes.Black, rect);
				if (_currentImage > -1)
					pe.Graphics.DrawString(ImageList[_currentImage].Tag?.ToString(), Font, new SolidBrush(ForeColor),
						rect);
			}
		}
	}
}