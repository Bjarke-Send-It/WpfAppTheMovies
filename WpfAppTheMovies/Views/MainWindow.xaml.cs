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
using WpfAppTheMovies.Views;

namespace WpfAppTheMovies
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
        private void CinemaProgramWindow_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the SecondWindow
            CinemaProgramWindow cinemaProgramWindow = new CinemaProgramWindow();

            // Show the SecondWindow
            cinemaProgramWindow.Show();
        }
    }
}