#pragma checksum "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\Category\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "851689277d293d434180449327573fc3c1e57983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_CategoryList), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/CategoryList.cshtml")]
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
#line 1 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\_ViewImports.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"851689277d293d434180449327573fc3c1e57983", @"/Areas/Admin/Views/Category/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47a4daf7d17fa5d3a8f6890b0081107613fa406e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\Category\CategoryList.cshtml"
  
    ViewData["Title"] = "CategoryList";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Kategori Adı</th>\r\n        <th>Pasif Yap</th>\r\n        <th>Aktif Yap</th>\r\n        <th>Düzenle</th>\r\n        <th>Sil</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\Category\CategoryList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 17 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\Category\CategoryList.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 18 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\Category\CategoryList.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-secondary\">Pasif Yap</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-primary\">Aktif Yap</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-info\">Düzenle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 643, "\"", 698, 3);
            WriteAttributeValue("", 650, "/Admin/Category/CategoryDelete/", 650, 31, true);
#nullable restore
#line 22 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\Category\CategoryList.cshtml"
WriteAttributeValue("", 681, item.CategoryID, 681, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 697, "/", 697, 1, true);
            EndWriteAttribute();
            WriteLiteral(" \r\n                   id=\"DeleteBtn\" \r\n                   onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\');\"\r\n                   class=\"btn btn-danger\">Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\Category\CategoryList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<td><a href=\"/Admin/Category/CategoryAdd/\" class=\"btn btn-success\">Yeni Kategori Ekle</a></td>\r\n<br /><br />\r\n");
#nullable restore
#line 31 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\Category\CategoryList.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("CategoryList", new { page })));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
