#pragma checksum "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Cars\DisplayTemplates\CarWithColors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dda8bb0f87356df9c8a8d858cc6d5a3ab5e36be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_DisplayTemplates_CarWithColors), @"mvc.1.0.view", @"/Views/Cars/DisplayTemplates/CarWithColors.cshtml")]
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
#line 1 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\_ViewImports.cshtml"
using AutoLot.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\_ViewImports.cshtml"
using AutoLot.Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\_ViewImports.cshtml"
using AutoLot.Dal.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dda8bb0f87356df9c8a8d858cc6d5a3ab5e36be", @"/Views/Cars/DisplayTemplates/CarWithColors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6535a691a72568fede56044d50050e4cebc56440", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_DisplayTemplates_CarWithColors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutoLot.Dal.Models.Entities.Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<hr />\n<div>\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 6 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Cars\DisplayTemplates\CarWithColors.cshtml"
       Write(Html.DisplayNameFor(model => model.PetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 9 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Cars\DisplayTemplates\CarWithColors.cshtml"
       Write(Html.DisplayFor(model => model.PetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 12 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Cars\DisplayTemplates\CarWithColors.cshtml"
       Write(Html.DisplayNameFor(model => model.MakeNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 15 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Cars\DisplayTemplates\CarWithColors.cshtml"
       Write(Html.DisplayFor(model => model.MakeNavigation.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 18 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Cars\DisplayTemplates\CarWithColors.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\"");
            BeginWriteAttribute("style", " style=\"", 630, "\"", 656, 2);
            WriteAttributeValue("", 638, "color:", 638, 6, true);
#nullable restore
#line 20 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Cars\DisplayTemplates\CarWithColors.cshtml"
WriteAttributeValue("", 644, Model.Color, 644, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            ");
#nullable restore
#line 21 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Cars\DisplayTemplates\CarWithColors.cshtml"
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutoLot.Dal.Models.Entities.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
