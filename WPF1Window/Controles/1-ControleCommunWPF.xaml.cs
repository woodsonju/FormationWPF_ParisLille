using System;
using System.Collections;
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
    /// Logique d'interaction pour _1_ControleCommunWPF.xaml
    /// </summary>
    public partial class _1_ControleCommunWPF : Window
    {
        public _1_ControleCommunWPF()
        {
            InitializeComponent();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            checkBox1.Content = "You agree !";
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //On récupère l'élément selectionné pour l'afficher 
            MessageBox.Show((string)((ComboBoxItem)(comboBox1.SelectedItem)).Content);

            //ou
            //MessageBox.Show((string)((ComboBoxItem)comboBox1.Items[comboBox1.SelectedIndex]).Content);
        }

        private void btnAddToListBox_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void btnSupp_Click(object sender, RoutedEventArgs e)
        {
            IList selected = new ArrayList(listBox1.SelectedItems);
            foreach (var item in selected)
            {
                listBox1.Items.Remove(item);
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label8.Content = (int) slider1.Value;
        }
    }
}
