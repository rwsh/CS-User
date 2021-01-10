using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace User
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void cmCopy(object sender, TextChangedEventArgs e)
		{
			tbText2.Text = tbText1.Text;
		}

		private void cmCheck(object sender, RoutedEventArgs e)
		{
			Background = Brushes.Gray;
		}

		private void cmUnchecked(object sender, RoutedEventArgs e)
		{
			Background = Brushes.White;
		}

		private void cmBlue(object sender, RoutedEventArgs e)
		{
			Background = Brushes.Blue;
		}

		private void cmRed(object sender, RoutedEventArgs e)
		{
			Background = Brushes.Red;
		}

		private void cmGreen(object sender, RoutedEventArgs e)
		{
			Background = Brushes.Green;
		}

		private void cmChange(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			pbScale.Value = slValue.Value;
		}

		private void cmFill(object sender, RoutedEventArgs e)
		{
			lbList.Items.Add("Мама");
			lbList.Items.Add("Папа");
			lbList.Items.Add("Я");
			lbList.Items.Add("Сестра");
			lbList.Items.Add("Брат");
		}

		private void cmSelect(object sender, SelectionChangedEventArgs e)
		{
			MessageBox.Show(lbList.Items[lbList.SelectedIndex].ToString());
		}

		private void cmGo(object sender, RoutedEventArgs e)
		{
			wbBrowser.Source = new Uri(tbURL.Text);
		}
	}
}
