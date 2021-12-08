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

namespace WPF1Window.Controles
{
    /// <summary>
    /// Logique d'interaction pour LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        //Evenement routé : Va permettre de déclencher un événement sur la fenêtre parent à partir d'un 
        //user control.
        public event RoutedEventHandler customEvt;

        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, RoutedEventArgs e)
        {
            //sender : Source de l'evenement (le contrôle qui declenche l'évenement)
            //RoutedEventArgs : Contient les données de l'événement

            MessageBox.Show(textBox1.Text);

            if(customEvt != null)
            {
                //Déclenche l'événement du UserControl afin de l'intercepter dans la fenetre parente
                customEvt(this, new RoutedEventArgs());
            }

        }
    }
}
