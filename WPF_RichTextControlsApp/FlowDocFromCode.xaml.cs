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
    /// Interaction logic for FlowDocFromCode.xaml
    /// </summary>
    public partial class FlowDocFromCode : Window
    {
        //public delegate void MyEventHandler(object sender, RoutedEventArgs e);

        public FlowDocFromCode()
        {
            InitializeComponent();
            LoadWindow();
        }

        private void LoadWindow()
        {         

            StackPanel gd = new StackPanel();
            gd.Background = Brushes.Red;


            Button btnNextwindow = new Button();
            btnNextwindow.Background = Brushes.Green;
            btnNextwindow.Width = 100;
            btnNextwindow.Height = 20;
            btnNextwindow.Content = "To Next Window";
            btnNextwindow.Click += (handler);
            btnNextwindow.VerticalAlignment = VerticalAlignment.Bottom;
            btnNextwindow.HorizontalAlignment = HorizontalAlignment.Right;
            gd.Children.Add(btnNextwindow);

            FlowDocumentScrollViewer scrollViewer = new FlowDocumentScrollViewer();
            FlowDocument doc = new FlowDocument();

            Paragraph p = new Paragraph(new Run("Hello world!"));
            p.FontSize = 36;
            doc.Blocks.Add(p);

            p = new Paragraph(new Run("The ultimate programming greeting!"));
            p.FontSize = 14;
            p.FontStyle = FontStyles.Italic;
            p.TextAlignment = TextAlignment.Left;
            p.Foreground = Brushes.Gray;
            doc.Blocks.Add(p);

            scrollViewer.Document = doc;
            gd.Children.Add(scrollViewer);

            this.AddChild(gd);            
        }

        private void handler(object sender, RoutedEventArgs e)
        {
            AdvancedFlowDocWindow adv = new AdvancedFlowDocWindow();
            this.Hide();
            adv.Show();
        }
    }
}
