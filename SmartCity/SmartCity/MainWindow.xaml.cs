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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartCity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DatabaseLinQDataContext db = new DatabaseLinQDataContext();
        LoginController login;
        public MainWindow()
        {
            login = new LoginController(db);
            InitializeComponent();
           
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string gebruikersnaam = txtGebruikersnaam.Text;
            string wachtwoord = txtPassword.Text;
            var gebruiker = login.inloggen(gebruikersnaam, wachtwoord);
            if (gebruiker == true)
            {
                MainDash dashboard = new MainDash();
                dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Onjuiste Login. Probeer het opnieuw");
            }
        }
    }
}
