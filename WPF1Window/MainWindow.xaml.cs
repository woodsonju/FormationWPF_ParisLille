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

namespace WPF1Window
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// C'est dans cette classe que sont placées les gestionnaires d'événement associés aux contrôleurs de la fenêtre
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Elle se charge de lancer l'initialisation graphique dans son constructeur
            InitializeComponent();
        }
    }
}
