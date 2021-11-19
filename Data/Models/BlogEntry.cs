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
    public partial class BlogEntry : IEmbeddedObject
    {
        public const string ContentType = "blog_post";
        public string Uid { get; set; }
        [JsonProperty(propertyName: "_content_type_uid")]
        public string ContentTypeUid { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public List<Author> Author { get; set; }
        public DateTime Date { get; set; }
        [JsonProperty(propertyName: "featured_image")]
        public Asset FeaturedImage { get; set; }
        public string Body { get; set; }
        [JsonProperty(propertyName: "related_post")]
        public List<BlogEntry> RelatedPost { get; set; }
        [JsonProperty(propertyName: "is_archived")]
        public bool IsArchived { get; set; }
        public SEO Seo { get; set; }
    }
}

