#pragma checksum "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12d610c386586ad4799c47c3ede43e4a722161193b3403321a75d9e999787c3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 2 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
using NewsWebsite.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
using NewsWebsite.ViewModels.Newsletter;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"12d610c386586ad4799c47c3ede43e4a722161193b3403321a75d9e999787c3c", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"79e89eaf0a90e2ef3003a81f112493381489ab29759a7804fa534a17b3fc41c6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsWebsite.ViewModels.News.NewsViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post-title mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""vizew-breadcrumb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""/""><i class=""fa fa-home"" aria-hidden=""true""></i> خانه</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">نتایج جستجو</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>
<!-- ##### Breadcrumb Area End ##### -->
<!-- ##### Archive List Posts Area Start ##### -->
<div class=""vizew-archive-list-posts-area mb-80"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-12 col-lg-8"">
                <!-- Archive Catagory & View Options -->
                <div class=""archive-catagory-view mb-30 d-flex align-items-center justify-content-between"">
                    <!-- Catagory -->
                    <div clas");
            WriteLiteral(@"s=""archive-catagory"">
                        <h4> نتایج جستجو </h4>
                    </div>
                    <!-- View Options -->
                    <div class=""view-options"">
                        <a href=""archive-grid.html""><i class=""fa fa-th-large"" aria-hidden=""true""></i></a>
                        <a href=""archive-list.html"" class=""active""><i class=""fa fa-list-ul"" aria-hidden=""true""></i></a>
                    </div>
                </div>
");
#nullable restore
#line 42 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                 if (Model.Count() != 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <!-- Single Post Area -->
                        <div class=""single-post-area style-2"">
                            <div class=""row align-items-center"">
                                <div class=""col-12 col-md-6"">
                                    <!-- Post Thumbnail -->
                                    <div class=""post-thumbnail"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12d610c386586ad4799c47c3ede43e4a722161193b3403321a75d9e999787c3c6388", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2237, "~/newsImage/", 2237, 12, true);
#nullable restore
#line 52 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 2249, item.ImageName, 2249, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 52 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 2271, item.ImageName, 2271, 15, false);

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
            WriteLiteral("\n\n                                        <!-- Video Duration -->\n                                        <span class=\"video-duration\">");
#nullable restore
#line 55 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                                                                Write(item.PublishDateTime.ConvertMiladiToShamsi("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                                <div class=""col-12 col-md-6"">
                                    <!-- Post Content -->
                                    <div class=""post-content mt-0"">
                                        <a href=""#"" class=""post-cata cata-sm cata-success"">");
#nullable restore
#line 61 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                                                                                      Write(item.NameOfCategories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12d610c386586ad4799c47c3ede43e4a722161193b3403321a75d9e999787c3c9528", async() => {
#nullable restore
#line 62 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                                                                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2920, "~/News/", 2920, 7, true);
#nullable restore
#line 62 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 2927, item.NewsId, 2927, 12, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2939, "/", 2939, 1, true);
#nullable restore
#line 62 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 2940, item.Url, 2940, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        <div class=\"post-meta d-flex align-items-center mb-2\">\n                                            <a href=\"#\" class=\"post-author\">");
#nullable restore
#line 64 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                                                                       Write(item.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                            <i class=\"fa fa-circle\" aria-hidden=\"true\"></i>\n                                            <a href=\"#\" class=\"post-date\">");
#nullable restore
#line 66 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                                                                     Write(item.PublishDateTime.ConvertMiladiToShamsi("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                        </div>\n                                        <p class=\"mb-2\">");
#nullable restore
#line 68 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                                                   Write(item.Abstract);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        <div class=\"post-meta d-flex\">\n                                            <a href=\"#\"><i class=\"fa fa-comments-o\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 70 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                                                                                                       Write(item.NumberOfComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                            <a href=\"#\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 71 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                                                                                                Write(item.NumberOfVisit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                            <a href=\"#\"><i class=\"fa fa-thumbs-o-up\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 72 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                                                                                                        Write(item.NumberOfLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                            <a href=\"#\"><i class=\"fa fa-thumbs-o-down\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 73 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                                                                                                          Write(item.NumberOfDisLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                        </div>\n                                    </div>\n                                </div>\n                            </div>\n                        </div>\n");
#nullable restore
#line 79 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                     

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"alert alert-info\">خبری یافت نشد ...</p>\n");
#nullable restore
#line 86 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n\n            <div class=\"col-12 col-md-6 col-lg-4\">\n                <div class=\"sidebar-area\">\n                    <!-- ***** MostPopularNews***** -->\n");
            WriteLiteral("\n                    ");
#nullable restore
#line 97 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Home\Search.cshtml"
               Write(await Html.PartialAsync("_RegisterInNewsletter", new NewsletterViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <!-- ***** Single Widget ***** -->\n");
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
