using System;
using System.Threading.Tasks;
using Contentstack.Core;
using Contentstack.Core.Models;
using contentstack_dotnet_starter_app.Data.Models;

namespace contentstack_dotnet_starter_app.Data
{
    public class PageService
    {
        private ContentstackClient _client;
        public PageService(ContentstackClient client)
        {
            _client = client;
        }

        public Task<ContentstackCollection<Page>> GetPageAsync(string pageUrl, string reference = null)
        {
            Query query = _client.ContentType("page").Query().Where("url", pageUrl);
            if (reference != null)
            {
                query.IncludeReference(reference);
            }

            return query.Find<Page>();
        }
    }
}
