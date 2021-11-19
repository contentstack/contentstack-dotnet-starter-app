using Markdig;
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
    public static class ContentstackStringExtension
    {

       public static string ToHtml(this String str)
        {
            if (str != null)
            {
                 var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
                 return Markdown.ToHtml(str, pipeline);
            }
            return string.Empty;
        }
        public static List<string> ToListHtml(this List<string> str)
        {
            List<string> result = new List<string>();
            foreach (var value in str)
            {
                 result.Add(value.ToHtml());
            }
            return result;
        }
    }
}

