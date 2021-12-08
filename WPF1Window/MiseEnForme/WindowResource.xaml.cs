﻿using System;
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

namespace WPF1Window.MiseEnForme
{
    /// <summary>
    /// Logique d'interaction pour WindowResource.xaml
    /// </summary>
    public partial class WindowResource : Window
    {
        public WindowResource()
        {
            InitializeComponent();
        }

        private void btnDynamicRessource_Click(object sender, RoutedEventArgs e)
        {
            Resources["BackgroundBrushDyn"] = new SolidColorBrush(Colors.LightYellow);
        }
    }
}