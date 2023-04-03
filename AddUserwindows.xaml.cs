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
using System.Windows.Shapes;

namespace VovaBD
{
    /// <summary>
    /// Логика взаимодействия для AddUserwindows.xaml
    /// </summary>
    public partial class AddUserwindows : Window
    {
        public AddUserwindows()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Services.UserServices service = new Services.UserServices(); 
            try
            {
                service.AddUser(tbName.Text, tbLogin.Text, tbPassword.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
