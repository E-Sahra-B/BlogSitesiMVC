#pragma checksum "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28979b276d329874b36d96e4755c5d313deaaab1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Areas/Writer/Views/Blog/BlogListByWriter.cshtml")]
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
#nullable restore
#line 1 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\_ViewImports.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28979b276d329874b36d96e4755c5d313deaaab1", @"/Areas/Writer/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5511a1b0918b600f085b0f7fa28a8647922e4a68", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-gradient-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-gradient-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Yazarın Blogları</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Blog Başlığı</th>
        <th>Oluşturulma Tarihi</th>
        <th>Kategori</th>
        <th>Durumu</th>
        <th>Sil</th>
        <th>Düzenle</th>
        <th>Aktif/Pasif</th>
    </tr>
");
#nullable restore
#line 17 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>");
#nullable restore
#line 21 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
   Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <td>");
#nullable restore
#line 22 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
    Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    <td>\r\n");
#nullable restore
#line 26 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
         if (item.Category.CategoryName == "Tiyatro")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"badge badge-warning\">Tiyatro</p>\r\n");
#nullable restore
#line 29 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
         if (item.Category.CategoryName == "Yazılım")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"badge badge-success\">Yazılım</p>\r\n");
#nullable restore
#line 33 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
         if (item.Category.CategoryName == "Teknoloji")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"badge badge-primary\">Teknoloji</p>\r\n");
#nullable restore
#line 37 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
         if (item.Category.CategoryName == "Oyun")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"badge badge-secondary\">Oyun</p>\r\n");
#nullable restore
#line 41 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
         if (item.Category.CategoryName == "sinema")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"badge badge-info\">sinema</p>\r\n");
#nullable restore
#line 45 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\r\n    <td>\r\n");
#nullable restore
#line 48 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
         if (@item.BlogStatus)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"badge badge-success\">Aktif</p>\r\n");
#nullable restore
#line 51 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"badge badge-secondary\">Pasif</p>\r\n");
#nullable restore
#line 55 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 1468, "\"", 1514, 2);
            WriteAttributeValue("", 1475, "/Writer/Blog/BlogDelete?id=", 1475, 27, true);
#nullable restore
#line 57 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1502, item.BlogID, 1502, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1515, "\"", 1536, 2);
            WriteAttributeValue("", 1520, "Sil_", 1520, 4, true);
#nullable restore
#line 57 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1524, item.BlogID, 1524, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 1585, "\"", 1629, 2);
            WriteAttributeValue("", 1592, "/Writer/Blog/BlogEdit?id=", 1592, 25, true);
#nullable restore
#line 58 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1617, item.BlogID, 1617, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></td>\r\n    <td>\r\n\r\n");
#nullable restore
#line 61 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
         if (item.BlogStatus)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28979b276d329874b36d96e4755c5d313deaaab110872", async() => {
                WriteLiteral("Pasif Yap");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1748, "~/Writer/Blog/ChangeStatusBlog?id=", 1748, 34, true);
#nullable restore
#line 63 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
AddHtmlAttributeValue("", 1782, item.BlogID, 1782, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1800, "Durum_", 1800, 6, true);
#nullable restore
#line 63 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
AddHtmlAttributeValue("", 1806, item.BlogID, 1806, 12, false);

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
            WriteLiteral(" ");
#nullable restore
#line 63 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
                                                                                                                                              }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28979b276d329874b36d96e4755c5d313deaaab113447", async() => {
                WriteLiteral("Aktif Yap");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1918, "~/Writer/Blog/ChangeStatusBlog?id=", 1918, 34, true);
#nullable restore
#line 66 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
AddHtmlAttributeValue("", 1952, item.BlogID, 1952, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1970, "Durum_", 1970, 6, true);
#nullable restore
#line 66 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
AddHtmlAttributeValue("", 1976, item.BlogID, 1976, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 66 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
                                                                                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <script>\r\n                                    $(\'#Sil_");
#nullable restore
#line 70 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
                                       Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"').click(function (e) {
                                        e.preventDefault();
                                        var linkURL = $(this).attr(""href"");
                                        Swal.fire({
                                            title: 'UYARI!',
                                            text: ""Blog yazısını silmek istediğinize emin misiniz?"",
                                            icon: 'warning',
                                            showCancelButton: true,
                                            showCancelButton: true,
                                            confirmButtonColor: '#5CBA6C',
                                            cancelButtonColor: '#d33',
                                            confirmButtonText: 'Evet',
                                            cancelButtonText: 'Hayır'
                                        }).then((result) => {
                                            if (result.isConfirmed) {
                   ");
            WriteLiteral(@"                             window.location.href = linkURL;
                                                Swal.fire(
                                                    'Başarılı!',
                                                    'Seçilen Blog Silindi .',
                                                    'success'
                                                )
                                            }
                                            else if (result.dismiss === Swal.DismissReason.cancel) {
                                            }
                                        })
                                    });

                    $('#Durum_");
#nullable restore
#line 97 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
                         Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').click(function (e) {\r\n                                        e.preventDefault();\r\n                        var linkURL = $(this).attr(\"href\");\r\n                        var deger = document.getElementById(\"Durum_");
#nullable restore
#line 100 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
                                                              Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").textContent;
                        var mesaj;
                        var onayMesaji;
                        if (deger == ""Pasif Yap"") {
                            mesaj = ""Blog yazısını pasif yapmak istediğinize emin misiniz ?"";
                            onayMesaji=""Seçilen blog pasif yapıldı.""
                        }
                        else if (deger) {
                            mesaj = ""Blog yazısını aktif yapmak istediğinize emin misiniz ?"";
                            onayMesaji=""Seçilen blog aktif yapıldı.""
                        }
                                        Swal.fire({
                                            title: 'UYARI!',
                                            text: mesaj,
                                            icon: 'warning',
                                            showCancelButton: true,
                                            showCancelButton: true,
                                            confirmButtonColor: '#5CBA6C',
 ");
            WriteLiteral(@"                                           cancelButtonColor: '#d33',
                                            confirmButtonText: 'Evet',
                                            cancelButtonText: 'Hayır'
                                        }).then((result) => {
                                            if (result.isConfirmed) {
                                                window.location.href = linkURL;
                                                Swal.fire(
                                                    'Başarılı!',
                                                    onayMesaji,
                                                    'success'
                                                )
                                            }
                                            else if (result.dismiss === Swal.DismissReason.cancel) {
                                            }
                                        })
                                    });
    </scr");
            WriteLiteral("ipt>\r\n</tr>\r\n");
#nullable restore
#line 136 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Writer/Blog/BlogAdd/\" class=\"btn btn-primary\">Yeni Blog Oluştur</a>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591