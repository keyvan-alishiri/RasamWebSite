#pragma checksum "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6d1ca0c602b2b43f4678391794563e4ce64ce705939c10a046b11984ccfa11f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6d1ca0c602b2b43f4678391794563e4ce64ce705939c10a046b11984ccfa11f4", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"79e89eaf0a90e2ef3003a81f112493381489ab29759a7804fa534a17b3fc41c6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsWebsite.ViewModels.Category.TreeViewCategory>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"classynav\">\n    <ul>\n        <li class=\"active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d1ca0c602b2b43f4678391794563e4ce64ce705939c10a046b11984ccfa11f43724", async() => {
                WriteLiteral("خانه");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n");
#nullable restore
#line 6 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
         foreach (var item in Model.OrderBy(t=>t.title))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\n                <a");
            BeginWriteAttribute("href", " href=\"", 283, "\"", 318, 4);
            WriteAttributeValue("", 290, "/Category/", 290, 10, true);
#nullable restore
#line 9 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 300, item.id, 300, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 308, "/", 308, 1, true);
#nullable restore
#line 9 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 309, item.url, 309, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                                                  Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 10 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                 if (item.subs.Count() != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul class=\"dropdown\">\n");
#nullable restore
#line 13 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                         foreach (var sub in item.subs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 557, "\"", 590, 4);
            WriteAttributeValue("", 564, "/Category/", 564, 10, true);
#nullable restore
#line 15 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 574, sub.id, 574, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 581, "/", 581, 1, true);
#nullable restore
#line 15 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 582, sub.url, 582, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                Write(sub.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 16 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </ul>\n");
#nullable restore
#line 20 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </li>\n");
#nullable restore
#line 23 "C:\Users\shiri.a\Desktop\RasamWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n        <li><a href=\"/Videos\">ویدئوها</a></li>\n    </ul>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsWebsite.ViewModels.Category.TreeViewCategory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
