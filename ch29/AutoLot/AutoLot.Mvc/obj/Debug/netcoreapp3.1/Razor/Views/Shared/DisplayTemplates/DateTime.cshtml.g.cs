#pragma checksum "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffd8b119855e0ee4a4b9138a25769ca1bc3bb47b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_DateTime), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/DateTime.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffd8b119855e0ee4a4b9138a25769ca1bc3bb47b", @"/Views/Shared/DisplayTemplates/DateTime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6535a691a72568fede56044d50050e4cebc56440", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_DateTime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateTime?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Unknown\n");
#nullable restore
#line 5 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
}
else
{
    if (ViewData.ModelMetadata.IsNullableValueType)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 10 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
      Write(Model.Value.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 11 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 14 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
      Write(((DateTime)Model).ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 15 "C:\Users\nuryn\Desktop\PycharmProjects\CSharp2020\C-Sharp-Class-2020\ch29\AutoLot\AutoLot.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
    }
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateTime?> Html { get; private set; }
    }
}
#pragma warning restore 1591
