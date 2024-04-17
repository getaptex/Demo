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
    /// Логика взаимодействия для details.xaml
    /// </summary>
    public partial class details : Window
    {
        public details()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            storage worker = new storage();
            bool work_id = true;
            for (int i = 0; i <= int.MaxValue & work_id; i++)
            {
                var dir = from s in Class1.context.storage
                          where s.article_id == i
                          select new
                          {
                              article_id = s.article_id,
                          };
                if (dir.Count() == 0)
                {
                    worker.article_id = i;
                    work_id = false;
                }
            }
            try
            {
                worker.article = _1.Text;
                worker.date = _2.SelectedDate;
                worker.storage_id = Int32.Parse(_3.Text);
                Class1.context.storage.Add(worker);
                MessageBox.Show("запись добавлена");
                Class1.context.SaveChanges();
            }
            catch 
            {
                MessageBox.Show("запись не добавлена");
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }

        private void reload_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
