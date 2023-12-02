#pragma checksum "C:\Users\shiri.a\Desktop\NewsWebsite-main\NewsWebsite\Areas\Admin\Views\Comments\_CommentsTable.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4752245a69862dbb6ebb6150401fedeed9c77965b8f4e7c5ad28c3f6fa70d2cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comments__CommentsTable), @"mvc.1.0.view", @"/Areas/Admin/Views/Comments/_CommentsTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4752245a69862dbb6ebb6150401fedeed9c77965b8f4e7c5ad28c3f6fa70d2cb", @"/Areas/Admin/Views/Comments/_CommentsTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"79e89eaf0a90e2ef3003a81f112493381489ab29759a7804fa534a17b3fc41c6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Comments__CommentsTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsWebsite.ViewModels.Comments.CommentViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div id=\"toolbar\">\n        <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"ajax-modal\" data-url=\"");
#nullable restore
#line 3 "C:\Users\shiri.a\Desktop\NewsWebsite-main\NewsWebsite\Areas\Admin\Views\Comments\_CommentsTable.cshtml"
                                                                                   Write(Url.Action("DeleteGroup","Tag"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
            <i class=""fa fa-trash""></i> | حذف گروهی
        </button>
    </div>
<table id=""table""
       data-toolbar=""#toolbar""
       data-search=""true""
       data-show-refresh=""true""
       data-show-toggle=""true""
       data-show-fullscreen=""true""
       data-show-columns=""true""
       data-detail-view=""true""
       data-show-export=""true""
       data-click-to-select=""true""
       data-detail-formatter=""detailFormatter""
       data-minimum-count-columns=""2""
       data-show-pagination-switch=""true""
       data-pagination=""true""
       data-id-field=""id""
       data-page-list=""[10, 25, 50, 100, all]""
       data-show-footer=""true""
       data-side-pagination=""server""
       data-url=""/Admin/Comments/GetComments?newsId=");
#nullable restore
#line 25 "C:\Users\shiri.a\Desktop\NewsWebsite-main\NewsWebsite\Areas\Admin\Views\Comments\_CommentsTable.cshtml"
                                               Write(Model.NewsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&isConfirm=");
#nullable restore
#line 25 "C:\Users\shiri.a\Desktop\NewsWebsite-main\NewsWebsite\Areas\Admin\Views\Comments\_CommentsTable.cshtml"
                                                                        Write(Model.IsConfirm);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
       data-response-handler=""responseHandler""></table>


<script>
        var $table = $('#table')
        var selections = []


  function get_query_params(p) {
    return {
        extraParam: 'abc',
        search: p.title,
        sort: p.sort,
        order: p.order,
        limit: p.limit,
        offset: p.offset
    }
}


        function responseHandler(res) {
            $.each(res.rows, function (i, row) {
                row.state = $.inArray(row.id, selections) !== -1
            })
            return res
    }

    function detailFormatter(index, row) {
            var html = []
            $.each(row, function (key, value) {
                if (key != ""state"" && key != ""Id"" && key!=""ردیف"" && key!=""IsConfirm"")
                    html.push('<p><b>' + key + ':</b> ' + value + '</p>')
            })
            return html.join('')
        }




     function operateFormatter(value, row, index) {
        return [
            '<button type=""button"" class=""btn-link text-success"" data-toggle=""ajax");
            WriteLiteral("-modal\" data-url=");
#nullable restore
#line 67 "C:\Users\shiri.a\Desktop\NewsWebsite-main\NewsWebsite\Areas\Admin\Views\Comments\_CommentsTable.cshtml"
                                                                                              Write(Url.Action("ConfirmOrInconfirm", "Comments"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?commentId=\' + row.Id + \' title=\"تایید / عدم تایید\">\',\n            \'<i class=\"fa fa-check\"></i>\',\n            \'</button >\',\n\n            \'<button type=\"button\" class=\"btn-link text-danger\" data-toggle=\"ajax-modal\" data-url=");
#nullable restore
#line 71 "C:\Users\shiri.a\Desktop\NewsWebsite-main\NewsWebsite\Areas\Admin\Views\Comments\_CommentsTable.cshtml"
                                                                                             Write(Url.Action("Delete", "Comments"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/?commentId=' + row.Id + ' title=""حذف"">',
            '<i class=""fa fa-trash""></i>',
            '</button >'
        ].join('')
    }

   function isConfirmFormatter(value, row, index) {
       var spanClass = ""badge badge-success"";
       var IsConfirm = ""تایید شده"";
       if (!row.IsConfirm) {
           IsConfirm = ""تایید نشده"";
           spanClass = ""badge badge-danger"";
       }
        return [
           '<span class=""' + spanClass + '"">' + IsConfirm + '</span>'
        ].join('')
    }

     function checkBoxFormat(value, row) {
       return '<input type=""checkbox"" name=""btSelectItem"" value=""' + row.Id + '"" />';
    }


        function totalTextFormatter(data) {
            return 'تعداد'
        }

        function totalNameFormatter(data) {
            return data.length
        }


        function initTable() {
            $table.bootstrapTable('destroy').bootstrapTable({
                height: 600,
                locale: 'fa-IR',
                columns: [
                    [{
          ");
            WriteLiteral(@"              field: 'state',
                        checkbox: true,
                        rowspan: 2,
                        align: 'center',
                        valign: 'middle',
                        formatter: checkBoxFormat
                    }, {
                        title: 'ردیف',
                        field: 'ردیف',
                        rowspan: 2,
                        align: 'center',
                        valign: 'middle',
                        footerFormatter: totalTextFormatter
                    }, {
                        title: 'جزئیات اطلاعات دیدگاه ها',
                        colspan: 5,
                        align: 'center'
                    }],
                    [{
                        field: 'نام',
                        title: 'نام',
                        sortable: true,
                        footerFormatter: totalNameFormatter,
                    },{
                        field: 'ایمیل',
                        title: 'ایمیل',
               ");
            WriteLiteral(@"         sortable: true,
                    },{
                        field: 'تاریخ ارسال',
                        title: 'تاریخ ارسال',
                        align: 'center',
                        sortable: true,
                    },{
                        field: 'وضعیت',
                        title: 'وضعیت',
                        align: 'center',
                        sortable: true,
                        formatter: isConfirmFormatter
                    },{
                        field: 'operate',
                        title: 'عملیات',
                        align: 'center',
                        events: window.operateEvents,
                        formatter: operateFormatter
                    }]
                ]
            })
        }

        $(function () {
            initTable()
            $('#locale').change(initTable)
        })</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebsite.ViewModels.Comments.CommentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
