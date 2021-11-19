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
using System.ComponentModel;
using System.Reflection;
namespace contentstack_dotnet_starter_app.Data.Models
{
    public partial class ContentstackHelper
    {
       public static string GetDescription(Enum en)
        {
             Type type = en.GetType();
             MemberInfo[] memInfo = type.GetMember(en.ToString());
             if (memInfo != null && memInfo.Length > 0)
             {
                 object[] attrs = memInfo[0].GetCustomAttributes(typeof(DisplayNameAttribute),false);
                 if (attrs != null && attrs.Length > 0)
                 return ((DisplayNameAttribute)attrs[0]).DisplayName;
             }
             return en.ToString();
        }
        public static bool FieldExists(string fieldName, JObject jObject)
        {
            return jObject[fieldName] != null;
        }
    }
}

