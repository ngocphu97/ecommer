#pragma checksum "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4b17cdd1cc3dee99f247a2885f4242b643fbe46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seller_Sanpham_Index), @"mvc.1.0.view", @"/Views/Seller/Sanpham/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seller/Sanpham/Index.cshtml", typeof(AspNetCore.Views_Seller_Sanpham_Index))]
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
#line 1 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\_ViewImports.cshtml"
using WebMobileMVC;

#line default
#line hidden
#line 2 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\_ViewImports.cshtml"
using WebMobileMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b17cdd1cc3dee99f247a2885f4242b643fbe46", @"/Views/Seller/Sanpham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Seller_Sanpham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebMobileMVC.Models.DanhMucSP>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutSellers.cshtml";

#line default
#line hidden
            BeginContext(148, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(177, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ac3610e75f84ffea7adf16394b1879d", async() => {
                BeginContext(200, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(214, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(307, 45, false);
#line 17 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDDanhMuc));

#line default
#line hidden
            EndContext();
            BeginContext(352, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(408, 41, false);
#line 20 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenDM));

#line default
#line hidden
            EndContext();
            BeginContext(449, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(505, 43, false);
#line 23 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenKhac));

#line default
#line hidden
            EndContext();
            BeginContext(548, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(604, 45, false);
#line 26 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TinhTrang));

#line default
#line hidden
            EndContext();
            BeginContext(649, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(705, 40, false);
#line 29 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(745, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(863, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(912, 44, false);
#line 38 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IDDanhMuc));

#line default
#line hidden
            EndContext();
            BeginContext(956, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1012, 40, false);
#line 41 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenDM));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1108, 42, false);
#line 44 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenKhac));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1206, 44, false);
#line 47 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TinhTrang));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1306, 39, false);
#line 50 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1401, 65, false);
#line 53 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1487, 71, false);
#line 54 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1579, 69, false);
#line 55 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Seller\Sanpham\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1687, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebMobileMVC.Models.DanhMucSP>> Html { get; private set; }
    }
}
#pragma warning restore 1591
