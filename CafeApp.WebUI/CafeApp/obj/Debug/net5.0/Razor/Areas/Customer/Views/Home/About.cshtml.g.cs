#pragma checksum "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\About.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02aa22eaff45b9ac3aba25ff8bd939e71810c3f2204392071854cade41527825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_About), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/About.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\_ViewImports.cshtml"
using CafeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\_ViewImports.cshtml"
using CafeApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"02aa22eaff45b9ac3aba25ff8bd939e71810c3f2204392071854cade41527825", @"/Areas/Customer/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0d987a2ea6e0670505fb2ae123c7b48b3c3455183aa5569831650f7eb2072499", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customer_Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CafeApp.Models.About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_Ana_Sayfa_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Title Page -->
<section class=""bg-title-page flex-c-m p-t-160 p-b-80 p-l-15 p-r-15"" style=""background-image: url(/Site/images/bg-title-page-03.jpg);"">
    <h2 class=""tit6 t-center"">
        Hakkımızda
    </h2>
</section>


<!-- Our Story -->
<section class=""bg2-pattern p-t-116 p-b-110 t-center p-l-15 p-r-15"">
    <span class=""tit2 t-center"">
        AYATO' CAFE
    </span>

    <h3 class=""tit3 t-center m-b-35 m-t-5"">
        Hikayemiz
    </h3>
");
#nullable restore
#line 24 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\About.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"t-center size32 m-l-r-auto\">\r\n            ");
#nullable restore
#line 27 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\About.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 29 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</section>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CafeApp.Models.About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
