#pragma checksum "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cffc76f0cf549de58eb9a3598f871e9b87f7647f"
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
#line 1 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\_ViewImports.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cffc76f0cf549de58eb9a3598f871e9b87f7647f", @"/Areas/Writer/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5511a1b0918b600f085b0f7fa28a8647922e4a68", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
  
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
    </tr>
");
#nullable restore
#line 16 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 19 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 20 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 24 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
                 if (@item.BlogStatus)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"badge badge-success\">Aktif</p>\r\n");
#nullable restore
#line 27 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"badge badge-secondary\">Pasif</p>\r\n");
#nullable restore
#line 31 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 923, "\"", 966, 2);
            WriteAttributeValue("", 930, "/Writer/Blog/BlogDelete/", 930, 24, true);
#nullable restore
#line 33 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 954, item.BlogID, 954, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1023, "\"", 1064, 2);
            WriteAttributeValue("", 1030, "/Writer/Blog/BlogEdit/", 1030, 22, true);
#nullable restore
#line 34 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1052, item.BlogID, 1052, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\MyProjects\VisualStudio\BlokSitesi\UI\Areas\Writer\Views\Blog\BlogListByWriter.cshtml"
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
