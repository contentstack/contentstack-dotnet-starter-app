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
using contentstack_dotnet_starter_app.Data.Models.PageBlocks.MBPageSectionWithBucketsGroup;

namespace contentstack_dotnet_starter_app.Data.Models.PageBlocks
{
    public partial class MBPageSectionWithBuckets : MBPagePageComponents
    {
        [JsonProperty(propertyName: "title_h2")]
        public string TitleH { get; set; }
        public string Description { get; set; }
        public List<GroupMBPageSectionWithBucketsBuckets> Buckets { get; set; }
    }
}

