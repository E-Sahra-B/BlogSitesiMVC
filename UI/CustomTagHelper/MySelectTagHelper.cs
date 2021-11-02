using Entity.Concrete;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.CustomTagHelper
{
    [HtmlTargetElement("mySelect")]
    public class MySelectTagHelper:TagHelper
    {
        [HtmlAttributeName("lst-for")]
        public List<Category> CategoryList { get; set; }

        public ModelExpression AspFor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "select";
            output.TagMode = TagMode.StartTagAndEndTag;
            if (!String.IsNullOrEmpty(this.AspFor.Name))
            {
                output.Attributes.Add("name", this.AspFor.Name);
                output.Attributes.Add("class", "form-control");
            }
            var sb = new StringBuilder();
            this.CategoryList.ForEach(x => sb.AppendFormat("<option value='" + x.CategoryID + "'>" + x.CategoryName + "</option>"));
            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}

