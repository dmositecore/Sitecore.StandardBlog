using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.ItemAdapter;
using Sitecore.ItemAdapter.Model;

namespace Sitecore.StandardBlog.Kernel.Model
{
    [Serializable]
    [ItemAdapterModel(FolderTemplateId, typeof(BlogPost))]
    public class BlogPostFolder : ItemAdapterModel
    {
        public const string FolderTemplateId = "{A87A00B1-E6DB-45AB-8B54-636FEC3B5523}";
    }
}
