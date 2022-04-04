#pragma checksum "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\Writer2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c290de4fe114eca9403162f48fda1ff2563e8a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer2_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer2/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c290de4fe114eca9403162f48fda1ff2563e8a0", @"/Areas/Admin/Views/Writer2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47a4daf7d17fa5d3a8f6890b0081107613fa406e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Writer2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\MyProjects\VisualStudio\BlogSitesiMVC\UI\Areas\Admin\Views\Writer2\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazar Ajax İşlemleri</h1>
<br />
<button type=""button"" id=""btnGetList"" class=""btn btn-outline-primary"">Yazar Listesi</button>
<button type=""button"" id=""btnGetById"" class=""btn btn-outline-success"">Yazar Getir</button>
<button type=""button"" id=""btnAddWriter"" class=""btn btn-outline-info"">Yazar Ekle</button>
<button type=""button"" id=""btndeletewriter"" class=""btn btn-outline-danger"">Yazar Sil</button>
<button type=""button"" id=""btnupdatewriter"" class=""btn btn-outline-warning"">Yazar Güncelle</button>

<div class=""mb-lg-3"" id=""writerList""></div>
<div id=""writerGet""></div>
<div >
    <input type=""text"" class=""form-control"" id=""writerId"" placeholder=""Yazar Id değerini giriniz"" />
</div>
<div class=""mb-lg-3"">
    <h1 class=""text-center"">Yazar Ekle</h1>
    <input type=""text"" id=""txtWriterId"" class=""form-control mb-lg-1"" placeholder=""Yazar ID"" />
    <input type=""text"" id=""txtWriterName"" class=""form-control mb-lg-1"" placeholder=""Yazar Adı"" />
</div>
<div class=""mb-lg-3"">
    <h1 class=""text-center");
            WriteLiteral(@""">Yazar Sil</h1>
    <input type=""text"" id=""txtid"" class=""form-control"" placeholder=""Silinecek Yazar ID"" />
</div>
<h1 class=""text-center mb-lg-3"">Yazar Güncelle</h1>
<input type=""text"" class=""form-control mb-lg-1"" id=""txtUpdateWriterId"" placeholder=""Güncellenecek ID"" />
<input type=""text"" class=""form-control mb-lg-1"" id=""txtUpdateWriterName"" placeholder=""Güncellenecek İsim"" />

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btnGetList"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer2/WriterList"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                   /* console.log(w);*/
                    let tablehtml = ""<table class='table table-bordered' <tr><th>Yazar ID</th><th>Yazar Adı</th></tr> "";
                    $.each(w, (index, value) => {
                        tablehtml += `<tr><td>${value.Id}</td> <td>${value.Name}</td></tr>`
                    });
                    tablehtml += ""</table>""
                    $(""#writerList"").html(tablehtml);
                }
            })
        })
    </script>
    <script>
        $(""#btnGetById"").click(function () {
            let writerId = $(""#writerId"").val();
            //console.log(writerId);
            $.ajax({
             ");
                WriteLiteral(@"   contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer2/GetWriterByID/"",
                data: { writerId: writerId },
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    /*console.log(w);*/
                    let getValue = `<table class=""table table-bordered""> <tr> <th>Yazar Id</th> <th>Yazar Adı</th></tr>
                            <tr><td>${w.Id}</td> <td>${w.Name}</td></tr></table>`
                    $(""#writerGet"").html(getValue);
                }
            });
        });
    </script>
    <script>
        $(""#btnAddWriter"").click(function () {
            let writer = {
                Id: $(""#txtWriterId"").val(),
                Name: $(""#txtWriterName"").val()
            };
            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer2/AddWriter"",
                data: writer,
                success: f");
                WriteLiteral(@"unction (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar Ekleme işlemi başarılı bir şekilde gerçekleşti"");
                }
            });
        });
    </script>
    <script>
        $(""#btndeletewriter"").click(x => {
            let id = $(""#txtid"").val();
            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer2/DeleteWriter/"" + id,
                dataType: ""json"",
                success: function (func) {
                    alert(""Yazar Silme işlemi başarılı bir şekilde gerçekleşti"");
                }
            });
        });
    </script>
    <script>
        $(""#btnupdatewriter"").click(function () {
            let writer = {
                Id: $(""#txtUpdateWriterId"").val(),
                Name: $(""#txtUpdateWriterName"").val()
            };
            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer2/UpdateWriter"",
                data: writer,
          ");
                WriteLiteral("      success: function (func) {\r\n                    alert(\"Yazar Güncelleme işlemi başarılı bir şekilde gerçekleşti\");\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
