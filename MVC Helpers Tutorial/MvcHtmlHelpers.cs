using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Helpers_Tutorial
{
    public static class LabelHelper
    {
        //public static string Label(string target, string text)
        //{
        //    return String.Format("<label for='{0}'>{1}</label>", target, text);
        //}

        public static string LabelCustom(this HtmlHelper helper, string target, string text)
        {
            return string.Format("<label for='{0}'>{1}</label>", target, text);
        }


        public static MvcHtmlString LabelCustomTagBuilder(this HtmlHelper helper, string target, string text)
        {
            TagBuilder builder = new TagBuilder("label");
            builder.MergeAttribute("for", target);
            builder.MergeAttribute("text", text);
            builder.InnerHtml = text;

            MvcHtmlString htmlString = MvcHtmlString.Create(builder.ToString());

            return htmlString;

            //return string.Format("<label for='{0}'>{1}</label>", target, text);
        }

        public static MvcHtmlString Image(this HtmlHelper helper, string src, string altText, string height)
        {
            var builder = new TagBuilder("img");
            builder.MergeAttribute("src", src);
            builder.MergeAttribute("alt", altText);
            builder.MergeAttribute("height", height);

            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}