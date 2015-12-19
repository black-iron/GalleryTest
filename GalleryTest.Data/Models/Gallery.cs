using System.Collections.Generic;

namespace GalleryTest.Data.Models
{
    public class Gallery:Base
    {
        public string Name { get; set; }
        public virtual ICollection<Media> Media { get; set; }
    }
}
