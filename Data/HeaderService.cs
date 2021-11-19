using System;
using System.Threading.Tasks;
using Contentstack.Core;
using Contentstack.Core.Models;
using contentstack_dotnet_starter_app.Data.Models;

namespace contentstack_dotnet_starter_app.Data
{
    public class HeaderService
    {

        private ContentstackClient _client;

        public HeaderService(ContentstackClient client)
        {
            _client = client;
        }

        public Task<ContentstackCollection<Header>> GetHeaderAsync()
        {
            return _client.ContentType("header").Query().IncludeReference("navigation_menu.page_reference").Find<Header>();
        }
    }
}
    