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
    [ItemAdapterModel(BlogTemplateId, typeof(BlogPostFolder))]
    public class Blog : ItemAdapterModel
    {
        public const string BlogTemplateId = "{6858BEDF-3CDF-4DE2-917C-773D48531C18}";

        public const string TitleFieldId = "{4E85F56B-471F-4D45-8F89-FEFD68404A53}";
        public const string SubtitleFieldId = "{9CDD7100-200B-4E9F-A549-F3DA4D506ED9}";
        public const string AuthorsFieldId = "{53C3FAD0-6EC9-4D3B-B8E4-09C49C84B8D7}";
        public const string TagsFieldId = "{A97C7C0B-E231-4D39-8E28-244A6CB079BC}";
        public const string LogoImageFieldId = "{D9CF1F46-5FEB-44D3-8ABE-55A6CBB92427}";

        [ItemAdapterTextField(TitleFieldId)]
        public string Title { get; set; }

        [ItemAdapterTextField(SubtitleFieldId)]
        public string Subtitle { get; set; }
        
        [ItemAdapterExtendedProperty]
        [ItemAdapterImageUrlField(LogoImageFieldId)]
        public string LogoUrl { get; set; }

        [ItemAdapterMultilistField(AuthorsFieldId, typeof(Author))]
        public IEnumerable<IItemAdapterModel> Authors { get; set; }

        [ItemAdapterMultilistField(TagsFieldId, typeof(Tag))]
        public IEnumerable<IItemAdapterModel> Tags { get; set; }


    }
}
