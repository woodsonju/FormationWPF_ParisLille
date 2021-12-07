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

namespace WPF1Window.BindingTest
{
    /// <summary>
    /// Logique d'interaction pour _4_BindingViaCodeBehind.xaml
    /// </summary>
    public partial class _4_BindingViaCodeBehind : Window
    {
        public _4_BindingViaCodeBehind()
        {
            InitializeComponent();

            //On crée un instance de Binding en spécifiant le Path (la propriété 'Text' du TextBox)
            Binding binding = new Binding("Text");

            //Définit l'objet à utiliser comme source de liaison
            binding.Source = txtValue;

            //On attache une liaison lblValue (TextBlock) à la propriété du TextBox
            //La méthode SetBinding() prend deux paramètres, l'un qui indique à quelle propriété de dépendance que nous voulons nous lier
            //(ici TextBlock) et l'autre qui contient l'objet de laison que nous souhaitons utiliser
            lblValue.SetBinding(TextBlock.TextProperty, binding);
        }
    }
}
