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

namespace WPF_RichTextControlsApp
{
    /// <summary>
    /// Interaction logic for AdvancedFlowDocWindow.xaml
    /// </summary>
    public partial class AdvancedFlowDocWindow : Window
    {
        public AdvancedFlowDocWindow()
        {
            InitializeComponent();
        }

        private void ToWindow6_Click(object sender, RoutedEventArgs e)
        {
            MoreOnAdvancedWindow more = new MoreOnAdvancedWindow();
            this.Hide();
            more.Show();
        }
    }
}
