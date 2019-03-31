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

namespace Bet.Inicio.Registro
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public Registro()
        {
            InitializeComponent();
            ViewModel.Inicial();
        }

        private void Button_Click_Registrar(object sender, RoutedEventArgs e)
        {
            string msj = ViewModel.ValidacionDatos();
            if (msj != string.Empty)
            {
                MessageBox.Show(msj, "Bet", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Registro Correcto", "Bet", MessageBoxButton.OK);
                this.Close();
            }
        }
    }
}
