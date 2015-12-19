using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
    /// Interaction logic for GalleryDetails.xaml
    /// </summary>
    public partial class GalleryDetails : Page
    {
        private int _galleryId;
        public GalleryDetails()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var t = HttpUtility.ParseQueryString(NavigationService.Source.OriginalString);
            _galleryId = int.Parse(t[0]);
            var gallery = new DataContext().Galleries.FirstOrDefault(x => x.Id == _galleryId);
            foreach (var item in gallery.Media)
            {
                var boxLink = new MediaItem()
                {
                    DisplayText = item.Title,
                    Margin = new Thickness(10, 5, 10, 5),
                };
                boxLink.MouseLeftButtonDown += BoxLink_MouseLeftButtonDown;
                this.StackPanel.Children.Add(boxLink);
            }
        }

        private void BoxLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            

        }
    }
}
