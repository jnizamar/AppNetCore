#pragma checksum "D:\horizont\Curso_C#_Jesus\Clase1\WebApplicationClase1\WebApplicationClase1\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e34ad9d05a7b5d942feeb9a38bb21994a63b2b94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
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
#line 1 "D:\horizont\Curso_C#_Jesus\Clase1\WebApplicationClase1\WebApplicationClase1\Views\_ViewImports.cshtml"
using WebApplicationClase1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\horizont\Curso_C#_Jesus\Clase1\WebApplicationClase1\WebApplicationClase1\Views\_ViewImports.cshtml"
using WebApplicationClase1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e34ad9d05a7b5d942feeb9a38bb21994a63b2b94", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e58ab5464025d5fe69e94c35f6c2997b27eef95", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <td>ID</td>\r\n            <td>Nombre</td>\r\n            <td>Apellido</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 15 "D:\horizont\Curso_C#_Jesus\Clase1\WebApplicationClase1\WebApplicationClase1\Views\Person\Index.cshtml"
         foreach (var item in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "D:\horizont\Curso_C#_Jesus\Clase1\WebApplicationClase1\WebApplicationClase1\Views\Person\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "D:\horizont\Curso_C#_Jesus\Clase1\WebApplicationClase1\WebApplicationClase1\Views\Person\Index.cshtml"
               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "D:\horizont\Curso_C#_Jesus\Clase1\WebApplicationClase1\WebApplicationClase1\Views\Person\Index.cshtml"
               Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "D:\horizont\Curso_C#_Jesus\Clase1\WebApplicationClase1\WebApplicationClase1\Views\Person\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591