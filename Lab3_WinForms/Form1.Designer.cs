
namespace Lab3_WinForms
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.imageName = new System.Windows.Forms.TextBox();
			this.addImage = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.imageGallery = new Lab3_WinForms.ImageGallery();
			this.roundedImageGallery = new Lab3_WinForms.RoundedImageGallery();
			this.SuspendLayout();
			// 
			// imageName
			// 
			this.imageName.Location = new System.Drawing.Point(12, 532);
			this.imageName.Name = "imageName";
			this.imageName.Size = new System.Drawing.Size(786, 22);
			this.imageName.TabIndex = 2;
			// 
			// addImage
			// 
			this.addImage.Location = new System.Drawing.Point(824, 527);
			this.addImage.Name = "addImage";
			this.addImage.Size = new System.Drawing.Size(238, 33);
			this.addImage.TabIndex = 1;
			this.addImage.Text = "Add Image";
			this.addImage.UseVisualStyleBackColor = true;
			this.addImage.Click += new System.EventHandler(this.addImage_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// imageGallery
			// 
			this.imageGallery.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
			this.imageGallery.ForeColor = System.Drawing.Color.White;
			this.imageGallery.Location = new System.Drawing.Point(12, 12);
			this.imageGallery.Name = "imageGallery";
			this.imageGallery.Size = new System.Drawing.Size(500, 500);
			this.imageGallery.TabIndex = 0;
			this.imageGallery.Text = "imageGallery1";
			this.imageGallery.UseVisualStyleBackColor = true;
			// 
			// roundedImageGallery
			// 
			this.roundedImageGallery.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
			this.roundedImageGallery.ForeColor = System.Drawing.Color.White;
			this.roundedImageGallery.Location = new System.Drawing.Point(562, 12);
			this.roundedImageGallery.Name = "roundedImageGallery";
			this.roundedImageGallery.Size = new System.Drawing.Size(500, 500);
			this.roundedImageGallery.TabIndex = 3;
			this.roundedImageGallery.Text = "roundedImageGallery1";
			this.roundedImageGallery.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1079, 579);
			this.Controls.Add(this.roundedImageGallery);
			this.Controls.Add(this.imageName);
			this.Controls.Add(this.addImage);
			this.Controls.Add(this.imageGallery);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Image Gallery";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ImageGallery imageGallery;
		private System.Windows.Forms.TextBox imageName;
		private System.Windows.Forms.Button addImage;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private RoundedImageGallery roundedImageGallery;
	}
}

