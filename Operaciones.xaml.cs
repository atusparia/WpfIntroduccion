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
using System.Windows.Shapes;

namespace WpfIntroduccion
{
    /// <summary>
    /// Lógica de interacción para Operaciones.xaml
    /// </summary>
    public partial class Operaciones : Window
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, RoutedEventArgs e)
        {
            lblSuma.Content = Convert.ToInt32(txtValor1.Text) + Convert.ToInt32(txtValor2.Text);
        }

        private void btnRestar_Click(object sender, RoutedEventArgs e)
        {
            lblSuma.Content = Convert.ToInt32(txtValor1.Text) - Convert.ToInt32(txtValor2.Text);
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            lblSuma.Content = Convert.ToInt32(txtValor1.Text) * Convert.ToInt32(txtValor2.Text);
        }
    }
}
