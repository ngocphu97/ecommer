#pragma checksum "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\AccountSeller\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02bb7fe84bcbc224adf0542b239dd807e7d0bceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountSeller_ChangePassword), @"mvc.1.0.view", @"/Views/AccountSeller/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccountSeller/ChangePassword.cshtml", typeof(AspNetCore.Views_AccountSeller_ChangePassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02bb7fe84bcbc224adf0542b239dd807e7d0bceb", @"/Views/AccountSeller/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountSeller_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\AccountSeller\ChangePassword.cshtml"
  
    Layout = "_LayoutSellers";

#line default
#line hidden
            BeginContext(39, 388, true);
            WriteLiteral(@"<div class=""content"">
    <div class=""animated fadeIn"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h2>ĐỔI MẬT KHẨU</h2>
                    </div>
                    <div class=""card-body card-block"" style=""padding-left: 40px;"">
                        ");
            EndContext();
            BeginContext(427, 1689, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34170a9d5c814324ac66bf4e3a558530", async() => {
                BeginContext(512, 1597, true);
                WriteLiteral(@"
                            <div class=""row form-group"">
                                <div class=""col col-md-3""><label for=""password-input"" class="" form-control-label"">Mật khẩu hiện tại</label></div>
                                <div class=""col-12 col-md-8""><input type=""password"" id=""password-input1"" name=""password-input1"" class=""form-control""></div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col col-md-3""><label for=""password-input"" class="" form-control-label"">Mật khẩu mới</label></div>
                                <div class=""col-12 col-md-8""><input type=""password"" id=""password-input2"" name=""password-input2"" class=""form-control""></div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col col-md-3""><label for=""password-input"" class="" form-control-label"">Xác nhận mật khẩu</label></div>
                          ");
                WriteLiteral(@"      <div class=""col-12 col-md-8""><input type=""password"" id=""password-input3"" name=""password-input3"" class=""form-control""></div>
                            </div>

                            <div>

                                <button type=""submit"" class=""btn btn-info btn-primary-custom pull-right"">
                                    <i class=""fa fa-lock fa-lg""></i>&nbsp;
                                    <span id=""payment-button-amount"">Lưu</span>
                                </button>
                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2116, 218, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div><!-- /# column -->\r\n        </div>\r\n\r\n        <!-- /.content -->\r\n        <!-- /.site-footer -->\r\n    </div>\r\n    <!-- /#right-panel -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591