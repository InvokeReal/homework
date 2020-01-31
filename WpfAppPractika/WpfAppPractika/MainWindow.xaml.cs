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

namespace WpfAppPractika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string leftop = "";
            string operation = "";
            string rightop = "";
            public MainWindow()
            {
                InitializeComponent();
                foreach (UIElement c in LayoutRoot.Children)
                {
                    if (c is Button)
                    {
                        ((Button)c).Click += Button_Click;
                    }
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String s = (string)((Button)e.OriginalSourse).Content;
            textBlock.Text += s;
            int num;
            bool result = Int32.TryParse(s,)
        }
        
    }
}
