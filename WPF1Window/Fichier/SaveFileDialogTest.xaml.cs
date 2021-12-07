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
    /// Logique d'interaction pour SaveFileDialogTest.xaml
    /// </summary>
    public partial class SaveFileDialogTest : Window
    {
        public SaveFileDialogTest()
        {
            InitializeComponent();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //Définir le repertoire initial
            saveFileDialog.InitialDirectory = @"C:\Users\Admin stagiaire.DESKTOP-8967908\Desktop\C#\POEI_20092021-122021\POEI_LilleParis\Cours_WPF\Docs\";

            //Définir un filtre pour l'extension du fichier
            saveFileDialog.Filter = "Text files (*txt) | *.txt| All files (*.*) | *.*";

            if(saveFileDialog.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, true))
                {
                    sw.WriteLine(txtEditor.Text);
                }
                MessageBox.Show("Enregistrement effectué");
            } else
            {
                MessageBox.Show("Enregistrement Annulé");
            }

        }
    }
}
