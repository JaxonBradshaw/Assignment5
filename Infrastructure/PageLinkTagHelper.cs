using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models.ViewModels;

namespace Assignment5.Infrastructure
{
    //setting it up as a div tag
    [HtmlTargetElement("div", Attributes = "page-model")]

    //Hilton said to not worry about this next bit haha
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory hp)
        {
            urlHelperFactory = hp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }

        //setting up dictionary so that anything in the format of page-url- is added to the dictionary
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();

        //adding more properties
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        //Overriding
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder result = new TagBuilder("div");

            //building navigation
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                //building a tag
                TagBuilder tag = new TagBuilder("a");

                PageUrlValues["page"] = i;
                //adding PageUrlValues to finish building the rest of the tag
                tag.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);

                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    //if i is the current page then do PageClassSelected otherwise do PageClassNormal
                    tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                }

                tag.InnerHtml.Append(i.ToString());

                //appending tag that was built
                result.InnerHtml.AppendHtml(tag);
            }
            //finished product of my labors
            output.Content.AppendHtml(result.InnerHtml);
        }

    }
}
