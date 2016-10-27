using System;
using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;

namespace SignInSheet
{
    /// <summary>
    /// Main Window for UserControls to switch pages
    /// Remember to connect to mongod to open connections to database
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Menu.MainMenu());
       
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void Navigate(UserControl nextPage, object state)
        {
            this.Content = nextPage;
            ISwitchable s = nextPage as ISwitchable;

            if(s != null)
            {
                s.UtilizeState(state);
            }
            else
            {
                throw new ArgumentException("Page is not Switchable: " + nextPage.Name.ToString());
            }
        }
        
        //public void SetPage(UserControl page)
        //{
        //    this.Content = page;
        //}

        //private void btn_new_Click(object sender, RoutedEventArgs e)
        //{
        //    //Shows NewWindow window
        //    NewWindow wind = new NewWindow();
        //    wind.Show();

        //    //Hides MainWindow
        //    this.Hide();
        //}

        //private void btn_open_Click(object sender, RoutedEventArgs e)
        //{
        //    //Shows ListWindow window
        //    ListWindow list = new ListWindow();
        //    list.Show();

        //    //Hides MainWindow
        //    this.Hide();
        //}
    }
}
