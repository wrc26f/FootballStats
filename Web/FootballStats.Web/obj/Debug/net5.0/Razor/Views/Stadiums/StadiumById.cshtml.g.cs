#pragma checksum "C:\Users\User\Downloads\New folder (4)\FootballStats\Web\FootballStats.Web\Views\Stadiums\StadiumById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e1c688878fd829916628dcb4af85e0360313d5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stadiums_StadiumById), @"mvc.1.0.view", @"/Views/Stadiums/StadiumById.cshtml")]
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
#line 1 "C:\Users\User\Downloads\New folder (4)\FootballStats\Web\FootballStats.Web\Views\_ViewImports.cshtml"
using FootballStats.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\New folder (4)\FootballStats\Web\FootballStats.Web\Views\_ViewImports.cshtml"
using FootballStats.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e1c688878fd829916628dcb4af85e0360313d5e", @"/Views/Stadiums/StadiumById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7f5fa18523693ba3fa5bb7e9a29cd5a20c7c7a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Stadiums_StadiumById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FootballStats.Web.ViewModels.Stadiums.StadiumViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Downloads\New folder (4)\FootballStats\Web\FootballStats.Web\Views\Stadiums\StadiumById.cshtml"
  
    this.TempData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"media\">\r\n    <img class=\"mr-3\"");
            BeginWriteAttribute("src", " src=\"", 156, "\"", 177, 1);
#nullable restore
#line 7 "C:\Users\User\Downloads\New folder (4)\FootballStats\Web\FootballStats.Web\Views\Stadiums\StadiumById.cshtml"
WriteAttributeValue("", 162, Model.UrlImage, 162, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Generic placeholder image\">\r\n    <div class=\"media-body\">\r\n        <h5 class=\"mt-0\">");
#nullable restore
#line 9 "C:\Users\User\Downloads\New folder (4)\FootballStats\Web\FootballStats.Web\Views\Stadiums\StadiumById.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p>Capacity: ");
#nullable restore
#line 10 "C:\Users\User\Downloads\New folder (4)\FootballStats\Web\FootballStats.Web\Views\Stadiums\StadiumById.cshtml"
                Write(Model.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Country: ");
#nullable restore
#line 11 "C:\Users\User\Downloads\New folder (4)\FootballStats\Web\FootballStats.Web\Views\Stadiums\StadiumById.cshtml"
               Write(Model.Country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Number of teams that use this stadium: ");
#nullable restore
#line 12 "C:\Users\User\Downloads\New folder (4)\FootballStats\Web\FootballStats.Web\Views\Stadiums\StadiumById.cshtml"
                                             Write(Model.TeamsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FootballStats.Web.ViewModels.Stadiums.StadiumViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
