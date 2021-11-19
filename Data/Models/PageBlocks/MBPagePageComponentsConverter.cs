using System;
using Newtonsoft.Json;
using System.Reflection;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using Contentstack.Core;
namespace contentstack_dotnet_starter_app.Data.Models.PageBlocks
{
    [CSJsonConverter("MBPagePageComponentsConverter")]
    public partial class MBPagePageComponentsConverter : JsonConverter<MBPagePageComponents>
    {
        protected MBPagePageComponents Create(Type objectType, JObject jObject)
        {
            if (ContentstackHelper.FieldExists(ContentstackHelper.GetDescription(MBPagePageComponentsEnum.HeroBanner), jObject))
             {
                 MBPageHeroBanner block = new MBPageHeroBanner();
                 block.BlockType = MBPagePageComponentsEnum.HeroBanner;
                 return block;
             }
            if (ContentstackHelper.FieldExists(ContentstackHelper.GetDescription(MBPagePageComponentsEnum.ContactDetails), jObject))
             {
                 MBPageContactDetails block = new MBPageContactDetails();
                 block.BlockType = MBPagePageComponentsEnum.ContactDetails;
                 return block;
             }
            if (ContentstackHelper.FieldExists(ContentstackHelper.GetDescription(MBPagePageComponentsEnum.SectionWithBuckets), jObject))
             {
                 MBPageSectionWithBuckets block = new MBPageSectionWithBuckets();
                 block.BlockType = MBPagePageComponentsEnum.SectionWithBuckets;
                 return block;
             }
            if (ContentstackHelper.FieldExists(ContentstackHelper.GetDescription(MBPagePageComponentsEnum.Section), jObject))
             {
                 MBPageSection block = new MBPageSection();
                 block.BlockType = MBPagePageComponentsEnum.Section;
                 return block;
             }
            if (ContentstackHelper.FieldExists(ContentstackHelper.GetDescription(MBPagePageComponentsEnum.SectionWithCards), jObject))
             {
                 MBPageSectionWithCards block = new MBPageSectionWithCards();
                 block.BlockType = MBPagePageComponentsEnum.SectionWithCards;
                 return block;
             }
            if (ContentstackHelper.FieldExists(ContentstackHelper.GetDescription(MBPagePageComponentsEnum.SectionWithHtmlCode), jObject))
             {
                 MBPageSectionWithHTMLCode block = new MBPageSectionWithHTMLCode();
                 block.BlockType = MBPagePageComponentsEnum.SectionWithHtmlCode;
                 return block;
             }
            if (ContentstackHelper.FieldExists(ContentstackHelper.GetDescription(MBPagePageComponentsEnum.FromBlog), jObject))
             {
                 MBPageFromBlog block = new MBPageFromBlog();
                 block.BlockType = MBPagePageComponentsEnum.FromBlog;
                 return block;
             }
            if (ContentstackHelper.FieldExists(ContentstackHelper.GetDescription(MBPagePageComponentsEnum.OurTeam), jObject))
             {
                 MBPageOurTeam block = new MBPageOurTeam();
                 block.BlockType = MBPagePageComponentsEnum.OurTeam;
                 return block;
             }
            if (ContentstackHelper.FieldExists(ContentstackHelper.GetDescription(MBPagePageComponentsEnum.Widget), jObject))
             {
                 MBPageWidget block = new MBPageWidget();
                 block.BlockType = MBPagePageComponentsEnum.Widget;
                 return block;
             }
        return new MBPagePageComponents();
        }
        public override MBPagePageComponents ReadJson(JsonReader reader, Type objectType, MBPagePageComponents existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
             JObject jObject = JObject.Load(reader);
             MBPagePageComponents target = Create(objectType, jObject);
             serializer.Populate(jObject.GetValue(ContentstackHelper.GetDescription(target.BlockType)).CreateReader(), target);
             return target;
         }
        public override void WriteJson(JsonWriter writer, MBPagePageComponents value, JsonSerializer serializer)
        {
        }
    }
}

