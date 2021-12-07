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
    /// Logique d'interaction pour _2_UsingDataContext.xaml
    /// </summary>
    public partial class _2_UsingDataContext : Window
    {
        public _2_UsingDataContext()
        {
            InitializeComponent();
            //Nous attribuons la reference "this" au Datacontext, qui indique tout simplement à la fenêtre que nous 
            //voulons qu'elle soit elle-même le context de données
            this.DataContext = this;
        }
    }
}
