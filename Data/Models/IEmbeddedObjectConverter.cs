using System;
using Newtonsoft.Json;
using Contentstack.Core;
using Newtonsoft.Json.Linq;
using Contentstack.Core.Models;
using System.Collections.Generic;
using Contentstack.Utils.Interfaces;

namespace contentstack_dotnet_starter_app.Data.Models
{
    [CSJsonConverter("IEmbeddedObjectConverter")]
    public partial class IEmbeddedObjectConverter : JsonConverter<List<IEmbeddedObject>>
    {
         protected List<IEmbeddedObject> Create(Type objectType, JArray jArray)
         {
            return new List<IEmbeddedObject>();
         }
         public override List<IEmbeddedObject> ReadJson(JsonReader reader, Type objectType, List<IEmbeddedObject> existingValue, bool hasExistingValue, JsonSerializer serializer)
         {
             JArray jArray = JArray.Load(reader);
             List<IEmbeddedObject> target = Create(objectType, jArray);
             foreach (JObject obj in jArray)
             {
                 if ((string)obj.GetValue("_content_type_uid") == "page")
                 {
                    Page Page = obj.ToObject<Page>();
                    target.Add(Page);
                 }
                 else if ((string)obj.GetValue("_content_type_uid") == "header")
                 {
                    Header Header = obj.ToObject<Header>();
                    target.Add(Header);
                 }
                 else if ((string)obj.GetValue("_content_type_uid") == "footer")
                 {
                    Footer Footer = obj.ToObject<Footer>();
                    target.Add(Footer);
                 }
                 else if ((string)obj.GetValue("_content_type_uid") == "blog_post")
                 {
                    BlogEntry BlogPost = obj.ToObject<BlogEntry>();
                    target.Add(BlogPost);
                 }
                 else if ((string)obj.GetValue("_content_type_uid") == "author")
                 {
                    Author Author = obj.ToObject<Author>();
                    target.Add(Author);
                 }
                 else if ((string)obj.GetValue("_content_type_uid") == "sys_assets")
                 {
                    Asset asset = obj.ToObject<Asset>();
                    target.Add(asset);
                 }
             }
             return target;
         }
         public override void WriteJson(JsonWriter writer, List<IEmbeddedObject> value, JsonSerializer serializer)
         {
         }
    }
}

