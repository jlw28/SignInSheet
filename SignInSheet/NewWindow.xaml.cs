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

namespace SignInSheet
{
    /// <summary>
    /// Interaction logic for NewWindow.xaml
    /// </summary>
    public partial class NewWindow : Window
    {
        public NewWindow()
        {
            InitializeComponent();
            btn_Save.Visibility = System.Windows.Visibility.Visible;
        }

        //Returns to MainWindow 
        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();

            this.Hide();
        }

        //Saves entries to Mongo database
        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            String[] row1 = new string[6] {textBox_11.Text, textBox_12.Text, textBox_13.Text,
                textBox_14.Text, textBox_15.Text, textBox_16.Text };
            String[] row2 = new string[6] {textBox_21.Text, textBox_22.Text, textBox_23.Text,
                textBox_24.Text, textBox_25.Text, textBox_26.Text };
            String[] row3 = new string[6] {textBox_31.Text, textBox_32.Text, textBox_33.Text,
                textBox_34.Text, textBox_35.Text, textBox_36.Text };
            String[] row4 = new string[6] {textBox_41.Text, textBox_42.Text, textBox_43.Text,
                textBox_44.Text, textBox_45.Text, textBox_46.Text };
            String[] row5 = new string[6] {textBox_51.Text, textBox_52.Text, textBox_53.Text,
                textBox_54.Text, textBox_55.Text, textBox_56.Text };
            String[] row6 = new string[6] {textBox_61.Text, textBox_62.Text, textBox_63.Text,
                textBox_64.Text, textBox_65.Text, textBox_66.Text };

            Entries ent = new Entries();
            ent.SetTitle(textBox_Title.Text);
            ent.SetHeader1(textBox_Header1.Text);
            ent.SetHeader2(textBox_Header2.Text);
            ent.SetHeader3(textBox_Header3.Text);
            ent.SetHeader4(textBox_Header4.Text);
            ent.SetHeader5(textBox_Header5.Text);
            ent.SetHeader6(textBox_Header6.Text);
            ent.SetRow1(row1);
            ent.SetRow2(row2);
            ent.SetRow3(row3);
            ent.SetRow4(row4);
            ent.SetRow5(row5);
            ent.SetRow6(row6);

            Mongo db = new Mongo();
            db.save_entries(ent);

            MainWindow main = new MainWindow();
            main.Show();

            this.Hide();

        }

        //Hides save and inputs entries into textboxes
        internal void show_results(Entries ent)
        {
            btn_Save.Visibility = System.Windows.Visibility.Hidden;
            textBox_Title.Text = ent.GetTitle();
            textBox_Header1.Text = ent.GetHeader1();
            textBox_Header2.Text = ent.GetHeader2();
            textBox_Header3.Text = ent.GetHeader3();
            textBox_Header4.Text = ent.GetHeader4();
            textBox_Header5.Text = ent.GetHeader5();
            textBox_Header6.Text = ent.GetHeader6();

            List<String> row1 = new List<string>();
            row1 = ent.GetRow1();
            textBox_11.Text = row1[0];
            textBox_12.Text = row1[1];
            textBox_13.Text = row1[2];
            textBox_14.Text = row1[3];
            textBox_15.Text = row1[4];
            textBox_16.Text = row1[5];

            List<String> row2 = new List<string>();
            row2 = ent.GetRow2();
            textBox_21.Text = row2[0];
            textBox_22.Text = row2[1];
            textBox_23.Text = row2[2];
            textBox_24.Text = row2[3];
            textBox_25.Text = row2[4];
            textBox_26.Text = row2[5];

            List<String> row3 = new List<string>();
            row3 = ent.GetRow3();
            textBox_31.Text = row3[0];
            textBox_32.Text = row3[1];
            textBox_33.Text = row3[2];
            textBox_34.Text = row3[3];
            textBox_35.Text = row3[4];
            textBox_36.Text = row3[5];

            List<String> row4 = new List<string>();
            row4 = ent.GetRow4();
            textBox_41.Text = row4[0];
            textBox_42.Text = row4[1];
            textBox_43.Text = row4[2];
            textBox_44.Text = row4[3];
            textBox_45.Text = row4[4];
            textBox_46.Text = row4[5];

            List<String> row5 = new List<string>();
            row5 = ent.GetRow5();
            textBox_51.Text = row5[0];
            textBox_52.Text = row5[1];
            textBox_53.Text = row5[2];
            textBox_54.Text = row5[3];
            textBox_55.Text = row5[4];
            textBox_56.Text = row5[5];

            List<String> row6 = new List<string>();
            row6 = ent.GetRow6();
            textBox_61.Text = row6[0];
            textBox_62.Text = row6[1];
            textBox_63.Text = row6[2];
            textBox_64.Text = row6[3];
            textBox_65.Text = row6[4];
            textBox_66.Text = row6[5];
        }
    }
}
