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
using contentstack_dotnet_starter_app.Data.Models.FooterGroup;

namespace contentstack_dotnet_starter_app.Data.Models
{
    public partial class Footer : IEmbeddedObject
    {
        public const string ContentType = "footer";
        public string Uid { get; set; }
        [JsonProperty(propertyName: "_content_type_uid")]
        public string ContentTypeUid { get; set; }
        public string Title { get; set; }
        public Asset Logo { get; set; }
        public GroupFooterNavigation Navigation { get; set; }
        public GroupFooterSocial Social { get; set; }
        public Node Copyright { get; set; }
    }
}

