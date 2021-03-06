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
using contentstack_dotnet_starter_app.Data.Models.PageBlocks.MBPageSectionWithCardsGroup;

namespace contentstack_dotnet_starter_app.Data.Models.PageBlocks
{
    public partial class MBPageSectionWithCards : MBPagePageComponents
    {
        public List<GroupMBPageSectionWithCardsCards> Cards { get; set; }
    }
}

