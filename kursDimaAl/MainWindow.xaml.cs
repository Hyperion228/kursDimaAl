using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Npgsql;

namespace kursDimaAl
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        public List<int> steps = new List<int>() { };
        public List<string> dates = new List<string>() { };
        public List<string> placs = new List<string>() { };
        public int id = 1;

        public string[] seats = { "A1", "A2", "B1", "B2", "C1", "C2" };
        public string[] days = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
        public MainWindow()
        {

            InitializeComponent();
            
            foreach (string day in days)
            {
                date.Items.Add(day);
            }
           
            foreach (string seat in seats)
            {
                mesto.Items.Add(seat);
            }
            
           
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Dictionary<int, Dictionary<string,string>> datesPlaces = new Dictionary<int, Dictionary<string, string>>() { };
            
            if(steps.Contains(id))
            {
                MessageBox.Show("Такой билет уже зарезервирован.");
            }
            else
            {
                id += 1;
                steps.Add(id);
                dates.Add(date.Text);
                placs.Add(mesto.Text);
                MessageBox.Show("Вы успешно зарезервировали билет.");
            }
            
            
           
        }
    }
}
