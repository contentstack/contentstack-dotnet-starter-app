using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contentstack.Core.Models;
using Contentstack.Utils.Models;
using Contentstack.Utils.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;


namespace contentstack_dotnet_starter_app.Data.Models.PageBlocks
{
    public partial class MBPageSection : MBPagePageComponents
    {
        [JsonProperty(propertyName: "title_h2")]
        public string TitleH { get; set; }
        public string Description { get; set; }
        [JsonProperty(propertyName: "call_to_action")]
        public ContentstackLink CallToAction { get; set; }
        public Asset Image { get; set; }
        [JsonProperty(propertyName: "image_alignment")]
        public string ImageAlignment { get; set; }
    }
}

