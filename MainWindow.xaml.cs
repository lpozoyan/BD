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

namespace VovaBD
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

        private void tbnGo_Click(object sender, RoutedEventArgs e)
        {
            Services.UserServices services = new Services.UserServices();
            try
            {
                string name = services.Auth (tblogin.Text, tbpassword.Text);
                MessageBox.Show("Привет " + name);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        
        }

        private void tbnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddUserwindows addUser = new AddUserwindows();
            addUser.ShowDialog();
        }
    }
}
