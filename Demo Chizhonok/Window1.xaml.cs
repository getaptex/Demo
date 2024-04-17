using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            var workers = from s in Class1.context.workers
                          select s.worker_id;
            var storage = from s in Class1.context.storage
                          select s.article_id;
            _4.ItemsSource = workers.ToList();
            _5.ItemsSource = storage.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            orders order = new orders();
            order.date = DateTime.Now;
            order.status = "get";
            order.client = this._3.Text;
            order.problem = this._2.Text;
            order.equpment_to_repair = this._1.Text;
            try
            {
                order.worker_id = Int32.Parse(this._4.Text);
                order.sparepart_id = Int32.Parse(this._5.Text);
            }
            catch { }

            bool ord_Id = true; 
            for (int i = 0; i <= int.MaxValue & ord_Id; i++)
            {
                var dir = from s in Class1.context.orders
                          where s.order_ID == i
                          select new
                          {
                              order_id = s.order_ID,
                          };
                if (dir.Count() == 0)
                {
                    order.order_ID = i;
                    ord_Id = false;
                }
            }
            try
            {
                Class1.context.orders.Add(order);
                Class1.context.SaveChanges();
                MessageBox.Show("запись добавлена");
                admin admin = new admin();
                admin.Show();
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("ошибка добавления записи");
            }
        }

        private void reload_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            workers_window win = new workers_window();
            win.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            details win = new details();
            win.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Close();
        }
    }
}
