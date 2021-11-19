using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contentstack.Core;
using Contentstack.Core.Models;
using contentstack_dotnet_starter_app.Data.Models;

namespace contentstack_dotnet_starter_app.Data
{
    public class BlogService
    {
        private ContentstackClient _client;
        public BlogService(ContentstackClient client)
        {
            _client = client;
        }

        public Task<ContentstackCollection<BlogEntry>> GetBlogAsync(string pageUrl = null, string[] references = null)
        {
            Query query = _client.ContentType("blog_post").Query();
            if (pageUrl != null)
            {
                query.Where("url", pageUrl);
            }
            if (references != null)
            {
                query.IncludeReference(references);
            }
            return query.Find<BlogEntry>();
        }
    }
}
