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
using MongoDB.Bson;

namespace SignInSheet.Menu
{
    /// <summary>
    /// Interaction logic for ListMenu.xaml
    /// </summary>
    public partial class ListMenu : UserControl, ISwitchable
    {
        public ListMenu()
        {
            this.InitializeComponent();
            Get_Sheet_Names();
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        //Gets all sheet titles and displays them in the listview
        private void Get_Sheet_Names()
        {
            try
            {
                Mongo db = new Mongo();
                List<BsonDocument> titles = db.get_titles();


                foreach (BsonDocument doc in titles)
                {
                    //able to have hidden value added for id?    
                    listBox.Items.Add(doc.GetElement("title").Value);
                }

            }
            catch (NullReferenceException e)
            {
                return;
            }

        }

        //Queries for collection based on title, then moves to NewWindow
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = listBox.SelectedItem.ToString();
            Mongo db = new Mongo();
            List<BsonDocument> results = db.get_collection(text);

            Entries ent = new Entries();
            ent.SetTitle(text);
            String h1 = results[0].GetElement("header1").ToString();
            string[] h1s = h1.Split('=');
            ent.SetHeader1(h1s[1]);

            String h2 = results[0].GetElement("header2").ToString();
            string[] h2s = h2.Split('=');
            ent.SetHeader2(h2s[1]);

            String h3 = results[0].GetElement("header3").ToString();
            string[] h3s = h3.Split('=');
            ent.SetHeader3(h3s[1]);

            String h4 = results[0].GetElement("header4").ToString();
            string[] h4s = h4.Split('=');
            ent.SetHeader4(h4s[1]);

            String h5 = results[0].GetElement("header5").ToString();
            string[] h5s = h5.Split('=');
            ent.SetHeader5(h5s[1]);

            String h6 = results[0].GetElement("header6").ToString();
            string[] h6s = h6.Split('=');
            ent.SetHeader6(h6s[1]);

            var row1 = results[0]["row1"].AsBsonArray.Select(p => p.AsString).ToArray();
            ent.SetRow1(row1);
            var row2 = results[0]["row2"].AsBsonArray.Select(p => p.AsString).ToArray();
            ent.SetRow2(row2);
            var row3 = results[0]["row3"].AsBsonArray.Select(p => p.AsString).ToArray();
            ent.SetRow3(row3);
            var row4 = results[0]["row4"].AsBsonArray.Select(p => p.AsString).ToArray();
            ent.SetRow4(row4);
            var row5 = results[0]["row5"].AsBsonArray.Select(p => p.AsString).ToArray();
            ent.SetRow5(row5);
            var row6 = results[0]["row6"].AsBsonArray.Select(p => p.AsString).ToArray();
            ent.SetRow6(row6);

            Switcher.Switch(new NewSheet());
            //NewWindow sho = new NewWindow();
            //sho.show_results(ent);
            //sho.Show();

        }

        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
