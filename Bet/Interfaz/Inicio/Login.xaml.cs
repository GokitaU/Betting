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

namespace Bet.Inicio
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        Vista.Inicio.Login login = new Vista.Inicio.Login();

        public Login()
        {
            InitializeComponent();            
        }

        private void Button_Click_Ingresar(object sender, RoutedEventArgs e)
        {
            var x = e;
            login.EstadoInicial();
        }
    }
}
