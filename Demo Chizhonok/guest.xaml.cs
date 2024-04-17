using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demo_Chizhonok
{
    /// <summary>
    /// Логика взаимодействия для guest.xaml
    /// </summary>
    public partial class guest : Window
    {
        public guest()
        {
            InitializeComponent();
            var orders = demoChizhonokEntities.getContext().orders.ToList();
            ads.ItemsSource = new statuses();
            ADE.ItemsSource = orders;
        }
        private void reload_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
