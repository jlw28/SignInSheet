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

namespace SignInSheet
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
        
        public void SetPage(UserControl page)
        {
            this.Content = page;
        }

        private void btn_new_Click(object sender, RoutedEventArgs e)
        {
            //Shows NewWindow window
            NewWindow wind = new NewWindow();
            wind.Show();

            //Hides MainWindow
            this.Hide();
        }

        private void btn_open_Click(object sender, RoutedEventArgs e)
        {
            //Shows ListWindow window
            ListWindow list = new ListWindow();
            list.Show();

            //Hides MainWindow
            this.Hide();
        }
    }
}
