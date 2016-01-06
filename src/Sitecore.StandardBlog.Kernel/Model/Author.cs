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
    [ItemAdapterModel(AuthorTemplateId, typeof(ItemAdapterModel))]
    public class Author : ItemAdapterModel
    {
        public const string AuthorTemplateId = "{E6411BF5-E8B8-434B-A7FD-80E3169C198A}";

        public const string FullNameFieldId = "{8DB1413E-83E9-4000-ACB3-46F262D4A66A}";
        public const string TwitterHandleFieldId = "{3B261021-714C-4776-8668-42343D960C2D}";
        public const string BiographyFieldId = "{8EDE7E9D-B0E6-4B25-9574-0984D5C521AB}";
        public const string ProfileImageFieldId = "{96A02ABB-3764-4292-A3B8-81F1CEB57451}";
        public const string CreatedDateFieldId = "{25BED78C-4957-4165-998A-CA1B52F67497}";

        [ItemAdapterTextField(FullNameFieldId)]
        public string FullName { get; set; }

        [ItemAdapterTextField(TwitterHandleFieldId)]
        public string TwitterHandle { get; set; }
        
        [ItemAdapterExtendedProperty]
        [ItemAdapterRichTextField(BiographyFieldId)]
        public string Biography { get; set; }

        [ItemAdapterExtendedProperty]
        [ItemAdapterImageUrlField(ProfileImageFieldId)]
        public string ProfileImageUrl { get; set; }

        [ItemAdapterExtendedProperty]
        [ItemAdapterDateTimeField(CreatedDateFieldId)]
        public Nullable<DateTime> CreatedDate { get; set; }


    }
}
