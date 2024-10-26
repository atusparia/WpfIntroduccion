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
    /// Lógica de interacción para RegistroProducto.xaml
    /// </summary>
    public partial class RegistroProducto : Window
    {
        List<Producto> productos = new List<Producto>();
        public RegistroProducto()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            productos.Add(new Producto { Nombre=txtNombre.Text, Precio=Convert.ToInt32(txtPrecio.Text), Descripcion=txtDescripcion.Text});

            this.dgProductos.ItemsSource = productos;

            dgProductos.Items.Refresh();

            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
        }

    }

}
