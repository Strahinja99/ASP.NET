using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace drinicpsaa.helperi
{
    public static class helperi
    {
        public static MvcHtmlString test(string src)
        {
            var TagBuilder = new TagBuilder("div");
            TagBuilder.InnerHtml = "<img src=" + src + ">";
            TagBuilder.AddCssClass("slika");
            return new MvcHtmlString(TagBuilder.ToString());
        }
    }
}