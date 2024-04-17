using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Demo_Chizhonok
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

    }
    
    public class statuses : ObservableCollection<string>
    {
        public statuses()
        {
           Add("get       ");
           Add("in work   ");
           Add("finished  ");
        }
    }
}
