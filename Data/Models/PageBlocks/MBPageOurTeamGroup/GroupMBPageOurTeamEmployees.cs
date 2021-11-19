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


namespace contentstack_dotnet_starter_app.Data.Models.PageBlocks.MBPageOurTeamGroup
{
    public partial class GroupMBPageOurTeamEmployees
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public Asset Image { get; set; }
    }
}

