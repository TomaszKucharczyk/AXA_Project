#pragma checksum "C:\Users\Tomke\source\repos\AXA_Project\AXA_Project\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ea2c1348446f814620ea9f7e90540f8ffbf65d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\Tomke\source\repos\AXA_Project\AXA_Project\Views\_ViewImports.cshtml"
using AXA_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tomke\source\repos\AXA_Project\AXA_Project\Views\_ViewImports.cshtml"
using AXA_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ea2c1348446f814620ea9f7e90540f8ffbf65d4", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42b5e9ad2646018af210ee0bf51eb127268f8a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AXA_Project.Models.ViewModels.MovieViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>List of STAR WARS Films</h3>\r\n<div>\r\n\t<ul>\r\n");
#nullable restore
#line 8 "C:\Users\Tomke\source\repos\AXA_Project\AXA_Project\Views\Movie\Index.cshtml"
         foreach (var item in Model.Results)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<li>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<span>\r\n\t\t\t\t\t\t");
#nullable restore
#line 13 "C:\Users\Tomke\source\repos\AXA_Project\AXA_Project\Views\Movie\Index.cshtml"
                   Write(Html.ActionLink("Episode " + item.Episode_id + ": " + item.Title, "Details", "Movie", new { id = item.Episode_id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\t\t\t\t\t\t| Rating: ");
#nullable restore
#line 14 "C:\Users\Tomke\source\repos\AXA_Project\AXA_Project\Views\Movie\Index.cshtml"
                             Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</div>\r\n\t\t\t</li>\r\n");
#nullable restore
#line 18 "C:\Users\Tomke\source\repos\AXA_Project\AXA_Project\Views\Movie\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AXA_Project.Models.ViewModels.MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
