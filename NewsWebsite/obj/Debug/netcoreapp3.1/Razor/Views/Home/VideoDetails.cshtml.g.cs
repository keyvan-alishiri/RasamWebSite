#pragma checksum "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\VideoDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a6d975681b151742c29a5c1e820ec3716405354cc614a57415df343ebf428229"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VideoDetails), @"mvc.1.0.view", @"/Views/Home/VideoDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\VideoDetails.cshtml"
using NewsWebsite.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a6d975681b151742c29a5c1e820ec3716405354cc614a57415df343ebf428229", @"/Views/Home/VideoDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"79e89eaf0a90e2ef3003a81f112493381489ab29759a7804fa534a17b3fc41c6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_VideoDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsWebsite.Entities.Video>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\VideoDetails.cshtml"
  
    ViewData["Title"] = "VideoDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- ##### Breadcrumb Area Start ##### -->
<div class=""vizew-breadcrumb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""/""><i class=""fa fa-home"" aria-hidden=""true""></i>خانه</a></li>
                        <li class=""breadcrumb-item""><a href=""/Videos"">ویدیوها</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">");
#nullable restore
#line 18 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\VideoDetails.cshtml"
                                                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>

<section class=""post-details-area mb-80"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""single-video-area"">
                    <div class=""post-thumbnail"">
                        <video width=""100%""");
            BeginWriteAttribute("poster", " poster=\"", 1082, "\"", 1118, 1);
#nullable restore
#line 32 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\VideoDetails.cshtml"
WriteAttributeValue("", 1091, "/posters/"+Model.Poster, 1091, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" controls><source");
            BeginWriteAttribute("src", " src=\"", 1136, "\"", 1152, 1);
#nullable restore
#line 32 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\VideoDetails.cshtml"
WriteAttributeValue("", 1142, Model.Url, 1142, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Your browser does not support the video tag.</video>\n                        <span class=\"video-duration\">");
#nullable restore
#line 33 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\VideoDetails.cshtml"
                                                Write(Model.PublishDateTime.ConvertMiladiToShamsi("dd MMMM yyyy ساعت HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                    <div class=\"post-content\">\n                        <p style=\"font-size:19px;\">");
#nullable restore
#line 36 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\VideoDetails.cshtml"
                                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebsite.Entities.Video> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
