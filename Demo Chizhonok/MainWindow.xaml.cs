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

namespace Demo_Chizhonok
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

        private void reload_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            guest guest = new guest();
            guest.Show();
            this.Close();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            registration registration = new registration();
            registration.Show();
            this.Close();
        }

        private void Authorisation_Click(object sender, RoutedEventArgs e)
        {
            var dir = from s in Class1.context.users
                      where s.login == login.Text && s.password == password.Password
                      select new
                      {
                          login = s.login,
                          password = s.password,
                      };
            if (dir.Count() != 0) 
            {
                /*
                We're no strangers to love
                You know the rules and so do I (do I)
                A full commitment's what I'm thinking of
                You wouldn't get this from any other guy

                I just wanna tell you how I'm feeling
                Gotta make you understand

                Never gonna give you up
                Never gonna let you down
                Never gonna run around 
                and desert you

                Never gonna make you cry
                Never gonna say goodbye
                Never gonna tell a lie 
                and hurt you

                We've known each other for so long
                Your heart's been aching, but you're too shy to say it (say it)
                Inside, we both know what's been going on (going on)
                We know the game and we're gonna play it

                And if you ask me how I'm feeling
                Don't tell me you're too blind to see

                Never gonna give you up
                Never gonna let you down
                Never gonna run around 
                and desert you

                Never gonna make you cry
                Never gonna say goodbye
                Never gonna tell a lie 
                and hurt you

                Never gonna give you up
                Never gonna let you down
                Never gonna run around 
                and desert you

                Never gonna make you cry
                Never gonna say goodbye
                Never gonna tell a lie 
                and hurt you

                We've known each other for so long
                Your heart's been aching, but you're too shy to say it (to say it)
                Inside, we both know what's been going on (going on)
                We know the game and we're gonna play it

                I just wanna tell you how I'm feeling
                Gotta make you understand

                Never gonna give you up
                Never gonna let you down
                Never gonna run around 
                and desert you

                Never gonna make you cry
                Never gonna say goodbye
                Never gonna tell a lie 
                and hurt you

                Never gonna give you up
                Never gonna let you down
                Never gonna run around 
                and desert you

                Never gonna make you cry
                Never gonna say goodbye
                Never gonna tell a lie 
                and hurt you

                Never gonna give you up
                Never gonna let you down
                Never gonna run around 
                and desert you

                Never gonna make you cry
                Never gonna say goodbye
                Never gonna tell a lie 
                and hurt you
                */
                admin admin = new admin();
                admin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
