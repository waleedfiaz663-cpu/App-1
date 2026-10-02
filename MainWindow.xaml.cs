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

namespace WpfApp2

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

        private void Button_Click(object sender, RoutedEventArgs e)

        {

            if(txtPassword.Text.Equals("123") && (txtName.Text.Equals("Waleed")) )

            {

                MessageBox.Show("Login successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            }

            else

            {

                MessageBox.Show("Invalid username or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)

        {

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)

        {

        }
    }
}