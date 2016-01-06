using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ItemAdapter.Model;
using Sitecore.ItemAdapter;
using Sitecore.ItemAdapter.FieldTypes;

namespace Sitecore.StandardBlog.Web.Areas.StandardPage.Models
{
    [ItemAdapterModel(StandardPageTemplateId, typeof(StandardPage))]
    public class StandardPage : ItemAdapterModel
    {
        public const string StandardPageTemplateId = "{BC8AE07C-9B3D-57D5-CB1F-5E01C4584C78}";
        public const string TitleFieldId = "{C645D89C-E115-4F87-8265-05039EBA2F76}";
        public const string ContentFieldId = "{51FCC004-7175-467D-889C-8C1924D57079}";

        [ItemAdapterTextField(TitleFieldId)]
        public string Title { get; set; }

        [ItemAdapterRichTextField(ContentFieldId)]
        public string Content { get; set; }


    }
}