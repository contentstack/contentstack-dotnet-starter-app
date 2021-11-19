using System;
using System.Threading.Tasks;
using Contentstack.Core;
using Contentstack.Core.Models;
using contentstack_dotnet_starter_app.Data.Models;

namespace contentstack_dotnet_starter_app.Data
{
    public class FooterService
    {
        
        private ContentstackClient _client;

        public FooterService(ContentstackClient client)
        {
            _client = client;
        }

        public Task<ContentstackCollection<Footer>> GetFooterAsync()
        {
            return _client.ContentType("footer").Query().Find<Footer>();
        }
    }
}
