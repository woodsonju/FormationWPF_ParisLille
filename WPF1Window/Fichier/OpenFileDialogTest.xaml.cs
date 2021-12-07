using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF1Window.Fichier
{
    /// <summary>
    /// Logique d'interaction pour OpenFileDialogTest.xaml
    /// </summary>
    public partial class OpenFileDialogTest : Window
    {
        public OpenFileDialogTest()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Définir le repertoire initial
            openFileDialog.InitialDirectory = @"C:\Users\Admin stagiaire.DESKTOP-8967908\Desktop\C#\POEI_20092021-122021\POEI_LilleParis\Cours_WPF\Docs\";

            //Définir un filtre pour l'extension du fichier
            openFileDialog.Filter = "Text files (*txt) | *.txt| All files (*.*) | *.*";

            if(openFileDialog.ShowDialog() == true)
            {
                //Contient le chemin du fichier
                FileNameTextBox.Text = openFileDialog.FileName;

                //iso-8859-1: couvre presque tout l'alphabet latin
                TextBlock1.Text = File.ReadAllText(openFileDialog.FileName, Encoding.GetEncoding("iso-8859-1"));
            } else
            {
                MessageBox.Show("Import fichier txt Annulé");
            }
        }
    }
}
