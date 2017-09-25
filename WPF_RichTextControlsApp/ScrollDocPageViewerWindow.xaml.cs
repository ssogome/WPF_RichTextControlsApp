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
    /// Interaction logic for ScrollDocPageViewerWindow.xaml
    /// </summary>
    public partial class ScrollDocPageViewerWindow : Window
    {
        public ScrollDocPageViewerWindow()
        {
            InitializeComponent();
        }

        private void ToWindow3_Click(object sender, RoutedEventArgs e)
        {
            FlowDocReaderWindow flowReader = new FlowDocReaderWindow();
            this.Hide();
            flowReader.Show();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            fdViewer.Find();
        }
    }
}
