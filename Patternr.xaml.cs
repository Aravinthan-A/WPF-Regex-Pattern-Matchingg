using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace String_Function
{
    /// <summary>
    /// Interaction logic for Patternr.xaml
    /// </summary>
    public partial class Patternr : Window
    {
        public Patternr()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int visa = 0;
            string regexvisa = "^4[0-9]{12}(?:[0-9]{3})?$";
            string visa1 = txtname.Text;
            string helo1 = "";
            int resvisa = 0;
            foreach (Match item in Regex.Matches(visa1, regexvisa.ToString()))
            {
                helo1 += item.ToString();
                resvisa++;
            }
            visa = resvisa;




        }
    }
}
