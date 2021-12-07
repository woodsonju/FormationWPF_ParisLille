using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WPF1Window.BindingTest.Model;

namespace WPF1Window.BindingTest
{
    /// <summary>
    /// Logique d'interaction pour _5_RespondingToChange.xaml
    /// </summary>
    public partial class _5_RespondingToChange : Window
    {

        //Première étape
        //private List<User> users = new List<User>();

        //Deuxième étape
        private ObservableCollection<User> users = new ObservableCollection<User>();

        public _5_RespondingToChange()
        {
            InitializeComponent();

            //Notre liste contient deux utilisateur...
            users.Add(new User { Name = "Andrija DUPONT" });
            users.Add(new User { Name = "Andrijana DUPONT" });

            //...que nous ajoutons dans la listBox
            //Le itemsSource de la liste est affecté à une liste de quelques utilisateurs
            lstUsers.ItemsSource = users;
        }

        private void btnAddUser_Click_1(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "New User" });
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if(lstUsers.SelectedItem != null)
            {
                (lstUsers.SelectedItem as User).Name = "Random Name";
            }
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lstUsers.SelectedItem != null)
            {
                users.Remove(lstUsers.SelectedItem as User);
            }
        }
    }
}
