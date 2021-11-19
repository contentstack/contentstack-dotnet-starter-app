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
using contentstack_dotnet_starter_app.Data.Models.PageBlocks;


namespace contentstack_dotnet_starter_app.Data.Models
{
    public partial class Page : IEntryEmbedable, IEmbeddedObject
    {
        public const string ContentType = "page";
        public string Uid { get; set; }
        [JsonProperty(propertyName: "_content_type_uid")]
        public string ContentTypeUid { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        [JsonProperty(propertyName: "page_components")]
        public List<MBPagePageComponents> PageComponents { get; set; }
        public SEO Seo { get; set; }
        [JsonProperty(propertyName: "_embedded_items")]
        public Dictionary<string, List<IEmbeddedObject>> embeddedItems { get; set; }
    }
}

