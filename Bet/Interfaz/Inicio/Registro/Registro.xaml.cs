namespace Bet.Inicio.Registro
{
    using System.Windows;

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
