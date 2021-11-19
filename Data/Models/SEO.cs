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


namespace contentstack_dotnet_starter_app.Data.Models
{
    public partial class SEO : IEmbeddedObject
    {
        public const string ContentType = "seo";
        public string Uid { get; set; }
        [JsonProperty(propertyName: "_content_type_uid")]
        public string ContentTypeUid { get; set; }
        [JsonProperty(propertyName: "meta_title")]
        public string MetaTitle { get; set; }
        [JsonProperty(propertyName: "meta_description")]
        public string MetaDescription { get; set; }
        public string Keywords { get; set; }
        [JsonProperty(propertyName: "enable_search_indexing")]
        public bool EnableSearchIndexing { get; set; }
    }
}

