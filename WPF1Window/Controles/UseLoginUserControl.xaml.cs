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

namespace WPF1Window.Controles
{
    /// <summary>
    /// Logique d'interaction pour UseLoginUserControl.xaml
    /// </summary>
    public partial class UseLoginUserControl : Window
    {
        public UseLoginUserControl()
        {
            InitializeComponent();
        }

        private void clickOnUse(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Evenement déclenché!!");
        }
    }
}
