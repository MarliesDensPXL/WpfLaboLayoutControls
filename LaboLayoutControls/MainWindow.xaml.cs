using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LaboLayoutControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ClearInput()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            emailTextBox.Clear();
        }

        private void onClearButtonClicked(object sender, RoutedEventArgs e)
        {
            ClearInput();
        }

        private void OnSaveButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Registratie student succesvol");
            ClearInput();
        }

        private void OnCancelButtonClicked(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}