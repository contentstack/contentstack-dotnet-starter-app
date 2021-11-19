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
    public partial class ContentstackLink
    {
         public string Title { get; set; }
         public string Href { get; set; }
    }
}

