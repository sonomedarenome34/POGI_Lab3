using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Lab3_WPF
{
	/// <summary>
	///     Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			card.Photo = new Image
			{
				Source = new BitmapImage(new Uri("pack://application:,,,/images/мартышка.jpg"))
			};
		}
	}
}