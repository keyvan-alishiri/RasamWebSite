#pragma checksum "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fba61756c5f4710ca581522b4db25b8944ab285e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MostTalkNews), @"mvc.1.0.view", @"/Views/Shared/_MostTalkNews.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba61756c5f4710ca581522b4db25b8944ab285e", @"/Views/Shared/_MostTalkNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31549871ec6bbee94f7009b7264021f55ba903a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__MostTalkNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsWebsite.ViewModels.News.NewsViewModel>>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""single-widget mb-50 border ligh"">
        <div class=""section-heading style-2 mb-30"">
            <h4>پر بحث ترین اخبار</h4>
            <div class=""line""></div>
        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 "">
                    <nav>
                        <div class=""nav nav-tabs nav-fill"" id=""nav-tab"" role=""tablist"">
                            <a class=""nav-item nav-link active most-talk"" id=""most-talk-day-tab"" data-toggle=""tab"" data-url=""");
#nullable restore
#line 12 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                                                                                                                        Write(Url.Action("Index","Home",values:new {duration="day",TypeOfNews="MostTalkNews"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">امروز</a>\n                            <a class=\"nav-item nav-link most-talk\" id=\"-most-talk-week-tab\" data-toggle=\"tab\" data-url=\"");
#nullable restore
#line 13 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                                                                                                                   Write(Url.Action("Index","Home",values:new {duration="week",TypeOfNews="MostTalkNews"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">هفته</a>\n                            <a class=\"nav-item nav-link most-talk\" id=\"-most-talk-month-tab\" data-toggle=\"tab\" data-url=\"");
#nullable restore
#line 14 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                                                                                                                    Write(Url.Action("Index","Home",values:new {duration="month",TypeOfNews="MostTalkNews"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">ماه</a>\n                        </div>\n                    </nav>\n                    <div class=\"tab-content py-3 px-3 px-sm-0\" id=\"nav-tabContent\">\n                        <div class=\"tab-pane fade show active\" id=\"nav-mostTalkNews\">\n");
#nullable restore
#line 19 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                             if (Model.Count() != 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"single-blog-post d-flex\">\n                                        <div class=\"post-thumbnail\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fba61756c5f4710ca581522b4db25b8944ab285e6019", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1714, "~/newsImage/", 1714, 12, true);
#nullable restore
#line 25 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
AddHtmlAttributeValue("", 1726, item.ImageName, 1726, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
AddHtmlAttributeValue("", 1748, item.ImageName, 1748, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </div>\n                                        <div class=\"post-content\">\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1926, "\"", 1956, 4);
            WriteAttributeValue("", 1933, "/", 1933, 1, true);
#nullable restore
#line 28 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
WriteAttributeValue("", 1934, item.NewsId, 1934, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1946, "/", 1946, 1, true);
#nullable restore
#line 28 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
WriteAttributeValue("", 1947, item.Url, 1947, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-title\">\n                                                ");
#nullable restore
#line 29 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                                           Write(item.ShortTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </a>
                                            <div class=""post-meta d-flex justify-content-between"">
                                                <a href=""#""><i class=""fa fa-comments-o"" aria-hidden=""true""></i> ");
#nullable restore
#line 32 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                                                                                                           Write(item.NumberOfComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                                <a href=\"#\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 33 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                                                                                                    Write(item.NumberOfVisit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                                <a href=\"#\"><i class=\"fa fa-thumbs-o-up\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 34 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                                                                                                            Write(item.NumberOfLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                                <a href=\"#\"><i class=\"fa fa-thumbs-o-down\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 35 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                                                                                                              Write(item.NumberOfDisLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                            </div>\n                                        </div>\n                                    </div>\n");
#nullable restore
#line 39 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\" alert alert-primary\">پر بحث ترین اخبار یافت نشد...</p>\n");
#nullable restore
#line 45 "C:\Users\shiri.A\Documents\RasamSite\NewsWebsite-main\NewsWebsite\Views\Shared\_MostTalkNews.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                        </div>\n                    </div>\n\n                </div>\n            </div>\n        </div>\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsWebsite.ViewModels.News.NewsViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
