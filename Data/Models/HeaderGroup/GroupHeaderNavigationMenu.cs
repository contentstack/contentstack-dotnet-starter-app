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


namespace contentstack_dotnet_starter_app.Data.Models.HeaderGroup
{
    public partial class GroupHeaderNavigationMenu
    {
        public string Label { get; set; }
        [JsonProperty(propertyName: "page_reference")]
        public List<Page> PageReference { get; set; }
    }
}

