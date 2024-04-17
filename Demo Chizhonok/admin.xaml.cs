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

namespace Demo_Chizhonok
{
    /// <summary>
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        public admin()
        {
            InitializeComponent(); 
            var orders = demoChizhonokEntities.getContext().orders.ToList();
            var workers = demoChizhonokEntities.getContext().workers.ToList();
            var storage = demoChizhonokEntities.getContext().storage.ToList();
            ads.ItemsSource = new statuses();
            ADE.ItemsSource = orders;
            WorkersADE.ItemsSource = workers;
            StorageADE.ItemsSource = storage;
        }
        private void reload_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Window1 mainWindow = new Window1();
            mainWindow.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ADE.ItemsSource = Class1.context.orders.ToList();
        }
    }
}
