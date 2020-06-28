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
using System.Windows.Shapes;

namespace TestDuoc.vistas
{
    /// <summary>
    /// Lógica de interacción para AgregarSexo.xaml
    /// </summary>
    public partial class AgregarSexo : Window
    {
        public AgregarSexo()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            CSexo controlador = new CSexo();
            if (controlador.agregarNuevoSexo(txt_descripcion_sexo.Text)>0)
            {
                MessageBox.Show("SEXO AGREGADO");
                txt_descripcion_sexo.Text = "";
            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }
    }
}
