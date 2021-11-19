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
using contentstack_dotnet_starter_app.Data.Models.FooterGroup.GroupFooterSocialGroup;

namespace contentstack_dotnet_starter_app.Data.Models.FooterGroup
{
    public partial class GroupFooterSocial
    {
        [JsonProperty(propertyName: "social_share")]
        public List<GroupGroupFooterSocialSocialShare> SocialShare { get; set; }
    }
}

