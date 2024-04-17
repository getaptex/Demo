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
using System.Data.Entity.Validation;

namespace Demo_Chizhonok
{
    /// <summary>
    /// Логика взаимодействия для registration.xaml
    /// </summary>
    public partial class registration : Window
    {
        public registration()
        {
            InitializeComponent();
        }
        private void reload_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            users con = new users()
            {
                login = login.Text,
                password = password.Password
            };
            try
            {
                Class1.context.users.Add(con);
                Class1.context.SaveChanges();
                MessageBox.Show("Регистрация успешна");
                admin admin = new admin();
                admin.Show();
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Такой логин занят или логин или пароль не введены");
            }
        }
    }
}
