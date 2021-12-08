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
using WPF1Window.BindingTest;
using WPF1Window.Controles;
using WPF1Window.Fichier;
using WPF1Window.MiseEnForme;
using WPF1Window.MiseEnPage;

//FolderBrowserDialog : Ajouter la reference avant
//WinForm est uniquement un alias pour eviter de prefixer
using WinForm = System.Windows.Forms;

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

        private void miOuvrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialogTest openFileDialog = new OpenFileDialogTest();
            openFileDialog.ShowDialog();
        }

        private void miEnrengistrer_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialogTest saveFileDialog = new SaveFileDialogTest();
            saveFileDialog.ShowDialog();
        }

        private void miFolderBrowser_Click(object sender, RoutedEventArgs e)
        {
            WinForm.FolderBrowserDialog dialog = new WinForm.FolderBrowserDialog();
            WinForm.DialogResult res = dialog.ShowDialog();

            if(res == WinForm.DialogResult.OK)
            {
                MessageBox.Show("Repertoire sélectionné : " + dialog.SelectedPath);
            } else
            {
                MessageBox.Show("Opération annulée");
            }

        }

        private void miQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            //ou
            //Application.Current.Shutdown();
        }

        private void miModale_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.ShowDialog();
        }

        private void miNonModale_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }

        private void miBoiteSimple_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("WPF, c'est facile !");
        }

        private void miBoiteP_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Etes-vous prèt à sauter ?", "Titre", MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if(res == MessageBoxResult.Yes)
            {
                MessageBox.Show("Vous n'auriez pas dû !");
            } else
            {
                MessageBox.Show("Excellente décision !");
            }
        }

        private void miStackP_Click(object sender, RoutedEventArgs e)
        {
            StackPanelTest sp = new StackPanelTest();
            sp.ShowDialog();
        }

        private void miWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelTest wp = new WrapPanelTest();
            wp.ShowDialog();
        }

        private void miDockPanel_Click(object sender, RoutedEventArgs e)
        {
            DockPanelTest dp = new DockPanelTest();
            dp.ShowDialog();
        }

        private void miGrid_Click(object sender, RoutedEventArgs e)
        {
            GridTest grid = new GridTest();
            grid.ShowDialog();
        }

        private void miCanvas_Click(object sender, RoutedEventArgs e)
        {
            CanvasTest canvas = new CanvasTest();
            canvas.ShowDialog();
        }

        private void miControleCommunWPF_Click(object sender, RoutedEventArgs e)
        {
            _1_ControleCommunWPF controlesCommun = new _1_ControleCommunWPF();
            controlesCommun.ShowDialog();
        }

        private void miMedia_Click(object sender, RoutedEventArgs e)
        {
            MediaTest media = new MediaTest();
            media.ShowDialog();
        }

        private void miUserControl_Click(object sender, RoutedEventArgs e)
        {
            UseLoginUserControl useLoginUserControl = new UseLoginUserControl();
            useLoginUserControl.ShowDialog();
        }

        private void miIntroBinding_Click(object sender, RoutedEventArgs e)
        {
            _1_IntroBinding introBinding = new _1_IntroBinding();
            introBinding.ShowDialog();
        }

        private void miUsingDataContextBinding_Click(object sender, RoutedEventArgs e)
        {
            _2_UsingDataContext dataContext = new _2_UsingDataContext();
            dataContext.ShowDialog();
        }

        private void miBindingViaCodeBehind_Click(object sender, RoutedEventArgs e)
        {
            _4_BindingViaCodeBehind bindingViaCodeBehind = new _4_BindingViaCodeBehind();
            bindingViaCodeBehind.ShowDialog();
        }

        private void miUpdateSourceTriggerProperty_Click(object sender, RoutedEventArgs e)
        {
            _3_UpdateSourceTriggerProperty updateSourceTriggerProperty = new _3_UpdateSourceTriggerProperty();
            updateSourceTriggerProperty.ShowDialog();
        }

        private void miRespondingToChange_Click(object sender, RoutedEventArgs e)
        {
            _5_RespondingToChange respondingToChange = new _5_RespondingToChange();
            respondingToChange.ShowDialog();
        }

        private void miValueConvertionWithIValueConverter_Click(object sender, RoutedEventArgs e)
        {
            _6_ValueConversionWithIValueConverter valueConversionWithIValueConverter = new _6_ValueConversionWithIValueConverter();
            valueConversionWithIValueConverter.ShowDialog();
        }

        private void miRessourceBase_Click(object sender, RoutedEventArgs e)
        {
            WindowResource wr = new WindowResource();
            wr.ShowDialog();
        }

        private void miMiseEnForme_Click(object sender, RoutedEventArgs e)
        {
            MiseEnFormeTest miseEnForme = new MiseEnFormeTest();
            miseEnForme.ShowDialog();
        }
    }
}
