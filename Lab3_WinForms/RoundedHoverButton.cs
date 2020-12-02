using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab3_WinForms
{
	internal class RoundedHoverButton : HoverButton
	{
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			var graphicsPath = new GraphicsPath();
			graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
			Region = new Region(graphicsPath);
		}
	}
}