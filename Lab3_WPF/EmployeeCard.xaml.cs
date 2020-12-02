using System.Windows;
using System.Windows.Controls;

namespace Lab3_WPF
{
	/// <summary>
	///     Логика взаимодействия для EmployeeCard.xaml
	/// </summary>
	public partial class EmployeeCard : UserControl
	{
		public static readonly DependencyProperty EmployeeNameProperty = DependencyProperty.Register(
			"EmployeeName",
			typeof(string),
			typeof(EmployeeCard),
			new PropertyMetadata(string.Empty, EmployeeNameChanged));

		public static readonly DependencyProperty DepartmentProperty = DependencyProperty.Register(
			"Department",
			typeof(string),
			typeof(EmployeeCard),
			new PropertyMetadata(string.Empty, DepartmentChanged));

		public static readonly DependencyProperty PositionProperty = DependencyProperty.Register(
			"Position",
			typeof(string),
			typeof(EmployeeCard),
			new PropertyMetadata(string.Empty, PositionChanged));

		public static readonly DependencyProperty PhotoProperty = DependencyProperty.Register(
			"PhotoSource",
			typeof(Image),
			typeof(EmployeeCard),
			new PropertyMetadata(null, ImageChanged));

		public EmployeeCard()
		{
			InitializeComponent();
		}

		public string EmployeeName
		{
			get => (string) GetValue(EmployeeNameProperty);
			set => SetValue(EmployeeNameProperty, value);
		}

		public string Department
		{
			get => (string) GetValue(DepartmentProperty);
			set => SetValue(DepartmentProperty, value);
		}

		public string Position
		{
			get => (string) GetValue(PositionProperty);
			set => SetValue(PositionProperty, value);
		}

		public Image Photo
		{
			get => (Image) GetValue(PhotoProperty);
			set => SetValue(PhotoProperty, value);
		}

		private static void EmployeeNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			if (d is EmployeeCard employeeCard)
				employeeCard.EmployeeNameLabel.Content = employeeCard.EmployeeName;
		}

		private static void DepartmentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			if (d is EmployeeCard employeeCard)
				employeeCard.DepartmentLabel.Content = employeeCard.Department;
		}

		private static void PositionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			if (d is EmployeeCard employeeCard)
				employeeCard.PositionLabel.Content = employeeCard.Position;
		}

		private static void ImageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			if (d is EmployeeCard employeeCard)
				employeeCard.PhotoImage.Source = employeeCard.Photo.Source;
		}
	}
}