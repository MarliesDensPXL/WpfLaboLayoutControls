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
using static System.Net.WebRequestMethods;

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

        private void OnClearButtonClicked(object sender, RoutedEventArgs e)
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

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            DateTime now = DateTime.Now;
            dateLabel.Content = now.ToLongDateString();
            timeLabel.Content = now.ToLongTimeString();
            pxlImage.Source = new BitmapImage(new Uri("https://pxl-digital.pxl.be/web/image/1811-b4b5a8f4/logo_pxl_digital.png", UriKind.Absolute));
            pxlImage.Stretch = Stretch.Uniform;
        }

        private void OnChecked(object sender, RoutedEventArgs e)
        {
            if (sender.GetType() == typeof(RadioButton))
            {
                 {
                    RadioButton rb = (RadioButton)sender;

                    if (rb.IsChecked == true)
                    {
                        rb.FontWeight = FontWeights.Bold;
                    }
                    else
                    {
                        rb.FontWeight = FontWeights.Normal;
                    }
                }
            }
            else if (sender.GetType() == typeof(CheckBox))
            {
                CheckBox cb = (CheckBox)sender;

                if (cb.IsChecked == true)
                {
                    cb.FontWeight = FontWeights.Bold;
                }
                else
                {
                    cb.FontWeight = FontWeights.Normal;
                }
            }
        }
    }
}