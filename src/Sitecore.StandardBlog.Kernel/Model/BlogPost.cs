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
    [ItemAdapterModel(BlogPostTemplateId, typeof(ItemAdapterModel))]
    public class BlogPost : ItemAdapterModel
    {
        public const string BlogPostTemplateId = "{A0EA7963-9194-4367-A20A-F3B629035424}";

        public const string TitleFieldId = "{14BF117B-97EB-4E1C-8BEE-C63065ADEF27}";
        public const string PostDateFieldId = "{AF42D8F2-A9D7-42F3-9784-55C6FE89285C}";
        public const string AuthorFieldId = "{81655FA5-9865-4B04-86FD-A3CBE0E92C3E}";
        public const string TagsFieldId = "{AE024939-93F9-41E3-B901-31CBA398C786}";
        public const string AbstractFieldId = "{DE8D9062-6EEB-45D2-A834-F80B5F663967}";
        public const string BodyFieldId = "{A649DB88-517E-43D0-9017-F18D150AB5F2}";
        

        [ItemAdapterTextField(TitleFieldId)]
        public string Title { get; set; }

        [ItemAdapterDateTimeField(PostDateFieldId)]
        public Nullable<DateTime> PostDate { get; set; }
        
        [ItemAdapterLinkField(AuthorFieldId, typeof(Author))]
        public Author Author { get; set; }

        [ItemAdapterMultilistField(TagsFieldId, typeof(Tag))]
        public List<IItemAdapterModel> Tags { get; set; }
        
        [ItemAdapterTextField(AbstractFieldId)]
        public string Abstract { get; set; }

        [ItemAdapterExtendedProperty]
        [ItemAdapterRichTextField(BodyFieldId)]
        public string Body { get; set; }


    }
}
