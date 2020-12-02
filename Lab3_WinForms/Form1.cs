using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3_WinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			openFileDialog.Filter =
				@"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
		}

		private void addImage_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			if (imageName.Text == string.Empty)
			{
				MessageBox.Show(@"Type in an image title.");
				return;
			}

			// получаем выбранный файл
			var img = Image.FromFile(openFileDialog.FileName);
			img.Tag = imageName.Text;
			imageGallery.ImageList.Add(img);
			imageGallery.Invalidate();
			roundedImageGallery.ImageList.Add(img);
			roundedImageGallery.Invalidate();
		}
	}
}