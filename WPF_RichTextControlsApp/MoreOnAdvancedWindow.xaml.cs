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

namespace WPF_RichTextControlsApp
{
    /// <summary>
    /// Interaction logic for MoreOnAdvancedWindow.xaml
    /// </summary>
    public partial class MoreOnAdvancedWindow : Window
    {
        public MoreOnAdvancedWindow()
        {
            InitializeComponent();
        }

        private void ToWindow7_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
