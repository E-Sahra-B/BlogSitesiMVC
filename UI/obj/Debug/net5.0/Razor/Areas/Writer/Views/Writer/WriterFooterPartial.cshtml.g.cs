#pragma checksum "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Writer\WriterFooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f29502f167c7cf734eaee996ba33a1f83364381c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Writer_WriterFooterPartial), @"mvc.1.0.view", @"/Areas/Writer/Views/Writer/WriterFooterPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f29502f167c7cf734eaee996ba33a1f83364381c", @"/Areas/Writer/Views/Writer/WriterFooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5511a1b0918b600f085b0f7fa28a8647922e4a68", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Writer_WriterFooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer class=\"footer\">\r\n    <div class=\"container-fluid clearfix\">\r\n        <span class=\"text-muted d-block text-center text-sm-left d-sm-inline-block\">Copyright © Tüm Hakları Saklıdır | ");
#nullable restore
#line 3 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Writer\Views\Writer\WriterFooterPartial.cshtml"
                                                                                                                  Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"float-none float-sm-right d-block mt-1 mt-sm-0 text-center\"> Yazar Paneli <a href=\"#\" target=\"_blank\">Blog Sitesi </a></span>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
