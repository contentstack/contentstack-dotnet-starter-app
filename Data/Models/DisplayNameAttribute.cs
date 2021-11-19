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
    [AttributeUsage(AttributeTargets.Field)]
    public partial class DisplayNameAttribute: Attribute
    {
         private string displayName;
        public string DisplayName
        {
            get
            {
                return displayName;
            }
        }
        public DisplayNameAttribute(string displayName)
        {
            this.displayName = displayName;
        }
    }
}

