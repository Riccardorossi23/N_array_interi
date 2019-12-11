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

namespace N_array_interi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Random random = new Random();

        private void btnGenera_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int valore = int.Parse(txtGenera.Text);
                if (valore <= 0)
                {
                    throw new Exception("Il numero deve essere superiore a 0");
                }
                int[] array = new int[valore];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0,20);
                }
                lblArray.Content = "[";
                for (int i = 0; i< array.Length; i++)
                {
                    lblArray.Content = lblArray.Content + $"{array[i]}";
                    if (i < array.Length - 1)
                        lblArray.Content += ",";
                }
                lblArray.Content += "]";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtGenera.Text = "";
            }
        }
    }
}



