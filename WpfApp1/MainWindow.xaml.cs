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
using System.IO;
using ClassLibrary1;
using ClassLibrary2;
namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1 sin = new Class1(tb1.Text);
            try
            {
                lbl.Content = sin.getClass1();
            }
            catch
            {
                MessageBox.Show("Ошибка. Проверьте правильность ввода данных.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Class2 um = new Class2(tb1.Text, tb2.Text);
            try
            {
                lbl.Content = um.getClass2();
            }
            catch
            {
                MessageBox.Show("Ошибка. Проверьте правильность ввода данных.");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string path;
            path = @"C:\Users\osolo\Desktop\result.txt";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(" " + lbl.Content);
            sw.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string path;
            path = @"C:\Users\osolo\Desktop\result.txt";
            File.Delete(path);
            lbl.Content = " ";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lbl.Content = " ";
            string path;
            path = @"C:\Users\osolo\Desktop\result.txt";
            StreamReader read = new StreamReader(path);
            lbl.Content = read.ReadToEnd();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
