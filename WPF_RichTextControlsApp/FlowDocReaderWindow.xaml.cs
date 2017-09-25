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
    /// Interaction logic for FlowDocReaderWindow.xaml
    /// </summary>
    public partial class FlowDocReaderWindow : Window
    {
        public FlowDocReaderWindow()
        {
            InitializeComponent();
        }

        private void ToWindow4_Click(object sender, RoutedEventArgs e)
        {
            FlowDocFromCode code = new FlowDocFromCode();
            this.Hide();
            code.Show();
        }
    }
}
