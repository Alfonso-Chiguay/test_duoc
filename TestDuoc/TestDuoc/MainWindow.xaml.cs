using BaseDatos.Controlador;
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
using TestDuoc.vistas;

namespace TestDuoc
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txt_rut.Foreground = Brushes.Gray;
        }

        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            CPersona controlador = new CPersona();
            lbl_nombre.Content = controlador.obtenerNombre(Int32.Parse(txt_rut.Text));
        }

        private void txt_rut_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_rut.Text = "";
            txt_rut.Foreground = Brushes.Black;
        }

        private void btn_agregar_sexo_Click(object sender, RoutedEventArgs e)
        {
            AgregarSexo ventana = new AgregarSexo();
            ventana.ShowDialog();
        }
    }
}
