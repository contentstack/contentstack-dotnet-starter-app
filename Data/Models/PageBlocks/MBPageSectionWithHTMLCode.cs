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
    public partial class MBPageSectionWithHTMLCode : MBPagePageComponents
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [JsonProperty(propertyName: "html_code")]
        public string HtmlCode { get; set; }
        [JsonProperty(propertyName: "html_code_alignment")]
        public string HtmlCodeAlignment { get; set; }
    }
}

