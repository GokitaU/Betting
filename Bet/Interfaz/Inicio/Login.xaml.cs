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

        private void Button_Click_Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Recuperar(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_Registrar(object sender, RoutedEventArgs e)
        {
            Registro.Registro registro = new Registro.Registro();
            registro.Show();
        }
    }
}
