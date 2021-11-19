using System.ComponentModel;
namespace contentstack_dotnet_starter_app.Data.Models.PageBlocks
{
    public enum MBPagePageComponentsEnum
    {
        [DisplayName(displayName: "hero_banner")]
        HeroBanner,
        [DisplayName(displayName: "contact_details")]
        ContactDetails,
        [DisplayName(displayName: "section_with_buckets")]
        SectionWithBuckets,
        [DisplayName(displayName: "section")]
        Section,
        [DisplayName(displayName: "section_with_cards")]
        SectionWithCards,
        [DisplayName(displayName: "section_with_html_code")]
        SectionWithHtmlCode,
        [DisplayName(displayName: "from_blog")]
        FromBlog,
        [DisplayName(displayName: "our_team")]
        OurTeam,
        [DisplayName(displayName: "widget")]
        Widget
    }
}

