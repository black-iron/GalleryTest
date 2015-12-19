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

namespace GalleryTest.UI
{
    /// <summary>
    /// Interaction logic for GalleryItem.xaml
    /// </summary>
    public partial class GalleryItem : UserControl
    {
        public GalleryItem()
        {
            InitializeComponent();
        }

        public string DisplayText
        {
            get { return this.displayTextLabel.Content.ToString(); }
            set { this.displayTextLabel.Content = value; }
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            (sender as Border).Background = (Brush)bc.ConvertFrom("#FF00caFF");
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            (sender as Border).Background = (Brush)bc.ConvertFrom("#FF00B9FF");
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            (sender as Border).Background = (Brush)bc.ConvertFrom("#FF00ddFF");
        }

        private void Border_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            (sender as Border).Background = (Brush)bc.ConvertFrom("#FF00caFF");
        }
    }
}
