#pragma checksum "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fa6f4805b2da5f2b6c8d87591e41cfa936fe9032a3e77feea42f89e33dbf0533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Identity\Pages\_ViewImports.cshtml"
using CafeApp.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Identity\Pages\_ViewImports.cshtml"
using CafeApp.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using CafeApp.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using CafeApp.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fa6f4805b2da5f2b6c8d87591e41cfa936fe9032a3e77feea42f89e33dbf0533", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6ff871d752acd1376f7cbcf8510b50427e7447da1f73a6db83ad0219f0fb7ff2", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6cdbb48762e7e2b44276775e71bec391a9ea3ada8e79ccffc2225b42134c328c", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f3f3d575a073b100e8280f2cd6c442e9ddebab4584eef07a0ecf0276bb045128", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#nullable restore
#line 6 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#nullable restore
#line 8 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
