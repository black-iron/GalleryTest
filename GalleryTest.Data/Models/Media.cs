using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Net.Mime;
using Newtonsoft.Json;

namespace GalleryTest.Data.Models
{
    public class Media : Base
    {
        public string Title { get; set; }
        public MediaType Type { get; set; }
        public string SerilizedExtendedProperties { get; set; }
        [NotMapped]
        public object ExtendedPropertires
        {
            get { return JsonConvert.DeserializeObject(SerilizedExtendedProperties); }
            set { SerilizedExtendedProperties = JsonConvert.SerializeObject(value); }
        }


    }

    public enum MediaType
    {
        Video,
        Image,
        Website

    }

}
