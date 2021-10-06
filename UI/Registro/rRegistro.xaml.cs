using P1_ap1_josueosorio_20180938.BLL;
using P1_ap1_josueosorio_20180938.Entidades;
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

namespace P1_ap1_josueosorio_20180938.UI.Registro
{
    /// <summary>
    /// Interaction logic for rRegistro.xaml
    /// </summary>
    public partial class rRegistro : Window
    {
        private AportesEntidades aporte = new AportesEntidades();
        public rRegistro()
        {
            InitializeComponent();
            this.DataContext = aporte;
        }

        private void Buscar_Click(object sender, RoutedEventArgs e)
        {
            var encontradoo = AportesBLL.Buscar(Utilidades.ToInt(RegistroTextBox.Text));

            if (encontradoo != null)
            {
                this.aporte = encontradoo;
            }

            else
            {
                this.aporte = new AportesEntidades();
                MessageBox.Show("No se ha encontrado", "Error",
                MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            this.DataContext = this.aporte;
        }

        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;


            bool paso = AportesBLL.Guardar(this.aporte);



            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
                MessageBox.Show("Transaccion Fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (AportesBLL.Eliminar(Utilidades.ToInt(RegistroTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("No Fue Posible Eliminar el Registro! :(", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
        private void Limpiar()
        {
            this.aporte = new AportesEntidades();
            this.DataContext = this.aporte;
        }
        private bool Validar()
        {
            bool esValido = true;

            if (RegistroTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Favor de llenar todo los campo", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


            return esValido;
        }
    }
}

       

      
