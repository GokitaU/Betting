namespace Bet.Inicio
{
    using System.Windows;
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public Login()
        {
            InitializeComponent();            
        }

        private void Button_Click_Ingresar(object sender, RoutedEventArgs e)
        {
            string msj = ViewModel.ValidacionLogin();
            if (msj != string.Empty)
                MessageBox.Show(msj, "Bet", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                this.Close();
        }
    }
}
