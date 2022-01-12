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


namespace contentstack_dotnet_starter_app.Data.Models.PageBlocks.MBPageSectionWithBucketsGroup
{
    public partial class GroupMBPageSectionWithBucketsBuckets
    {
        [JsonProperty(propertyName: "title_h3")]
        public string TitleH { get; set; }
        public Node Description { get; set; }
        public Asset Icon { get; set; }
        [JsonProperty(propertyName: "call_to_action")]
        public ContentstackLink CallToAction { get; set; }
    }
}

