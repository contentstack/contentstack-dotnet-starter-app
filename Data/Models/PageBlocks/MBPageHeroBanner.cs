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
    public partial class MBPageHeroBanner : MBPagePageComponents
    {
        [JsonProperty(propertyName: "banner_image")]
        public Asset BannerImage { get; set; }
        [JsonProperty(propertyName: "bg_color")]
        public string BgColor { get; set; }
        [JsonProperty(propertyName: "banner_title")]
        public string BannerTitle { get; set; }
        [JsonProperty(propertyName: "banner_description")]
        public string BannerDescription { get; set; }
        [JsonProperty(propertyName: "call_to_action")]
        public ContentstackLink CallToAction { get; set; }
    }
}

