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
using GalleryTest.Data.DataProviders;

namespace GalleryTest.UI
{
    /// <summary>
    /// Interaction logic for Galleries.xaml
    /// </summary>
    public partial class Galleries : Page
    {
        public Galleries()
        {
            InitializeComponent();
        }

        private void BoxLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var id = (int) (sender as GalleryItem).Tag;
            this.NavigationService.Navigate(new Uri($"GalleryDetails.xaml?galleryId={id}", UriKind.RelativeOrAbsolute));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var galleries = new DataContext().Galleries.ToList();
            foreach (var item in galleries)
            {
                var boxLink = new GalleryItem()
                {
                    DisplayText = item.Name,
                    Margin = new Thickness(10, 5, 10, 5),
                    Tag = item.Id
                };
                boxLink.MouseLeftButtonDown += BoxLink_MouseLeftButtonDown;
                this.StackPanel.Children.Add(boxLink);
            }
        }
    }
}
