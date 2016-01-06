using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.ItemAdapter;
using Sitecore.ItemAdapter.FieldTypes;
using Sitecore.ItemAdapter.FieldTypes.NestedModel;
using Sitecore.ItemAdapter.Model;

namespace Sitecore.StandardBlog.Kernel.Model
{

    [Serializable]
    [ItemAdapterModel(TagTemplateId, typeof(ItemAdapterModel))]
    public class Tag : ItemAdapterModel
    {
        public const string TagTemplateId = "{E4C635C0-64E6-40C3-80B3-4381437B3959}";
        
    }
}
