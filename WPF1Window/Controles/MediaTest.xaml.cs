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

//Ajouter la référence avant)
//WinFom est uniquement un alias pour eviter de prefixer
using WinForms = System.Windows.Forms;


namespace WPF1Window.Controles
{
    /// <summary>
    /// Logique d'interaction pour MediaTest.xaml
    /// </summary>
    public partial class MediaTest : Window
    {
        public MediaTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.Forms
           WinForms.OpenFileDialog openPicture = new WinForms.OpenFileDialog();

            openPicture.Filter = "Image (*.png;*.jpg) | *.png;*.jpg| Tous les fichiers(*.*) | *.*";
            openPicture.InitialDirectory = Environment.CurrentDirectory;

            WinForms.DialogResult result = openPicture.ShowDialog();
            if (result == WinForms.DialogResult.Cancel)
                return;

            image1.Source = new BitmapImage(new Uri(openPicture.FileName));
        }

        //Bouton permettant de charger l'audio ou la video
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            WinForms.OpenFileDialog openDlg = new WinForms.OpenFileDialog();
            WinForms.DialogResult result = openDlg.ShowDialog();

            if (result == WinForms.DialogResult.Cancel)
                return;

            mediaElement1.Source = new Uri(openDlg.FileName);
            mediaElement1.Play();
        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            if(mediaElement1.Source == null)
            {
                MessageBox.Show("Vous devez selectionner un media");
            } else
            {
                mediaElement1.Play();
            }
        }

        private void buttonPause_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();
        }
    }
}
