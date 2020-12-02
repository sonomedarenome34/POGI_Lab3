using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3_WinForms
{
	internal class ImageGallery : HoverButton
	{
		protected int _currentImage = -1;
		protected bool _isMouseOver;

		public ImageGallery()
		{
			ImageList = new List<Image>();
		}

		public new List<Image> ImageList { get; protected set; }

		protected override void OnPaint(PaintEventArgs pe)
		{
			if (_currentImage == -1 && ImageList.Count != 0) _currentImage = 0;
			if (_currentImage > -1) pe.Graphics.DrawImage(ImageList[_currentImage], pe.ClipRectangle);
			else return;
			if (_isMouseOver)
			{
				pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, Color.White)), pe.ClipRectangle);
				var rect = new Rectangle(ClientRectangle.X, ClientRectangle.Height - 60, ClientRectangle.Width, 60);
				pe.Graphics.FillRectangle(Brushes.Black, rect);
				if (_currentImage > -1)
					pe.Graphics.DrawString(ImageList[_currentImage].Tag?.ToString(), Font, new SolidBrush(ForeColor),
						rect);
			}
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			if (ImageList.Count == 0) return;
			if (_currentImage < ImageList.Count - 1) _currentImage++;
			else _currentImage = 0;
			Invalidate();
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			_isMouseOver = true;
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			_isMouseOver = false;
		}
	}
}