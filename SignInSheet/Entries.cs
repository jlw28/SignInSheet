//Class for storing entries inputed from user on the NewWindow.xaml window

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSheet
{
    class Entries
    {
        private String title;
        private String header1;
        private String header2;
        private String header3;
        private String header4;
        private String header5;
        private String header6;
        private List<String> row1;
        private List<String> row2;
        private List<String> row3;
        private List<String> row4;
        private List<String> row5;
        private List<String> row6;

        public Entries()
        {
            title = "title";
            header1 = "1";
            header2 = "2";
            header3 = "3";
            header4 = "4";
            header5 = "5";
            header6 = "6";
            row1 = new List<string>();
            row2 = new List<string>();
            row3 = new List<string>();
            row4 = new List<string>();
            row5 = new List<string>();
            row6 = new List<string>();
        }

        public void SetTitle(String _title)
        {
            title = _title;
        }
        public void SetHeader1(String _header1)
        {
            header1 = _header1;
        }
        public void SetHeader2(String _header2)
        {
            header2 = _header2;
        }
        public void SetHeader3(String _header3)
        {
            header3 = _header3;
        }
        public void SetHeader4(String _header4)
        {
            header4 = _header4;
        }
        public void SetHeader5(String _header5)
        {
            header5 = _header5;
        }
        public void SetHeader6(String _header6)
        {
            header6 = _header6;
        }
        public void SetRow1(String[] vals)
        {
            for (int i = 0; i < 6; i++)
            {
                if (vals.Length > i)
                    row1.Add(vals[i]);
                else
                    row1.Add(" ");
            }
        }
        public void SetRow2(String[] vals)
        {
            for (int i = 0; i < 6; i++)
            {
                if (vals.Length > i)
                    row2.Add(vals[i]);
                else
                    row2.Add(" ");
            }
        }
        public void SetRow3(String[] vals)
        {
            for (int i = 0; i < 6; i++)
            {
                if (vals.Length > i)
                    row3.Add(vals[i]);
                else
                    row3.Add(" ");
            }
        }
        public void SetRow4(String[] vals)
        {
            for (int i = 0; i < 6; i++)
            {
                if (vals.Length > i)
                    row4.Add(vals[i]);
                else
                    row4.Add(" ");
            }
        }
        public void SetRow5(String[] vals)
        {
            for (int i = 0; i < 6; i++)
            {
                if (vals.Length > i)
                    row5.Add(vals[i]);
                else
                    row5.Add(" ");
            }
        }
        public void SetRow6(String[] vals)
        {
            for (int i = 0; i < 6; i++)
            {
                if (vals.Length > i)
                    row6.Add(vals[i]);
                else
                    row6.Add(" ");
            }
        }



        public String GetTitle()
        {
            return title;
        }
        public String GetHeader1()
        {
            return header1;
        }
        public String GetHeader2()
        {
            return header2;
        }
        public String GetHeader3()
        {
            return header3;
        }
        public String GetHeader4()
        {
            return header4;
        }
        public String GetHeader5()
        {
            return header5;
        }
        public String GetHeader6()
        {
            return header6;
        }
        public List<String> GetRow1()
        {
            return row1;
        }
        public List<String> GetRow2()
        {
            return row2;
        }
        public List<String> GetRow3()
        {
            return row3;
        }
        public List<String> GetRow4()
        {
            return row4;
        }
        public List<String> GetRow5()
        {
            return row5;
        }
        public List<String> GetRow6()
        {
            return row6;
        }
    }
}
