namespace Bet
{
    using System.Windows;

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Logica.Logica logica = new Logica.Logica();
            //logica.Test();
        }
    }
}
