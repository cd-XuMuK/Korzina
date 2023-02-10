using System.Windows;
using Korzina;

namespace Korzina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            
            if(Fam.Text != null && Name.Text != null && email.Text != null && pass.Password != null)
            {
                Resurce.Fam = Fam.Text;
                Resurce.Name = Name.Text;
                Resurce.Email = email.Text;
                Resurce.Pass = pass.Password;
            }
        }
    }
}
