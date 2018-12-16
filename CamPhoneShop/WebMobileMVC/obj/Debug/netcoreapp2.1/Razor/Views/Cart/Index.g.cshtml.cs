#pragma checksum "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "107402bb103f275cc4ae819bf77418144f69c6a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"107402bb103f275cc4ae819bf77418144f69c6a4", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("coupon-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Cart\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 5363, true);
            WriteLiteral(@"
<!-- Start Page Title -->
<div class=""page-title"">
    <div class=""container"">
        <div class=""column"">
            <h1>Giỏ hàng</h1>
        </div>
        <div class=""column"">
            <ul class=""breadcrumbs"">
                <li><a href=""index-1.html"">Trang chủ</a></li>
                <li class=""separator"">&nbsp;</li>
                <li>Giỏ hàng</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Title -->
<!-- Start Cart Content -->
<div class=""container padding-top-1x padding-bottom-3x"">
    <!-- Start Shopping Cart -->
    <div class=""table-responsive shopping-cart"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Tên sản phẩm</th>
                    <th class=""text-center"">Số lượng</th>
                    <th class=""text-center"">Đơn giá</th>
                    <th class=""text-center"">Tổng</th>
                    <th class=""text-center"">
                        <a class=""btn btn-sm btn-outline-dan");
            WriteLiteral(@"ger"" href=""#"">Xoá tất cả</a>
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        <div class=""product-item"">
                            <a class=""product-thumb"" href=""shop-single-1.html"">
                                <img src=""/assets/images/shop/cart/01.jpg"" alt=""Product"">
                            </a>
                            <div class=""product-info"">
                                <h4 class=""product-title""><a href=""shop-single-1.html"">iPhone X Black</a></h4>
                                <span><em>Size:</em> 64GB</span><span><em>Color:</em> Gold</span>
                            </div>
                        </div>
                    </td>
                    <td class=""text-center"">
                        <div class=""count-input"">
                            <input type=""number"" step=""1"" min=""1"" max="""" name=""quantity"" value=""1"" title=""Qty"" class=""input-text qty tex");
            WriteLiteral(@"t"" size=""4"" pattern=""[0-9]*"" inputmode=""numeric"" style=""width: 60px"">
                        </div>
                    </td>
                    <td class=""text-center text-lg text-medium"">$649</td>
                    <td class=""text-center text-lg text-medium"">$649</td>
                    <td class=""text-center"">
                        <a class=""remove-from-cart"" href=""#"" data-toggle=""tooltip"" title=""Remove item""><i class=""icon-cross""></i></a>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class=""product-item"">
                            <a class=""product-thumb"" href=""shop-single-1.html""><img src=""/assets/images/shop/cart/02.jpg"" alt=""Product""></a>
                            <div class=""product-info"">
                                <h4 class=""product-title""><a href=""shop-single-1.html"">Panasonic TX-32</a></h4>
                                <span><em>Size:</em> 180SM</span><span><em>Color:</em> Silver</span>
");
            WriteLiteral(@"                            </div>
                        </div>
                    </td>
                    <td class=""text-center"">
                        <div class=""count-input"">
                            <input type=""number"" step=""1"" min=""1"" max="""" name=""quantity"" value=""1"" title=""Qty"" class=""input-text qty text"" size=""4"" pattern=""[0-9]*"" inputmode=""numeric"" style=""width: 60px"">
                        </div>
                    </td>
                    <td class=""text-center text-lg text-medium"">$800</td>
                    <td class=""text-center"">&mdash;</td>
                    <td class=""text-center"">
                        <a class=""remove-from-cart"" href=""#"" data-toggle=""tooltip"" title=""Remove item""><i class=""icon-cross""></i></a>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class=""product-item"">
                            <a class=""product-thumb"" href=""shop-single-1.html""><img src=""/assets/image");
            WriteLiteral(@"s/shop/cart/03.jpg"" alt=""Product""></a>
                            <div class=""product-info"">
                                <h4 class=""product-title""><a href=""shop-single-1.html"">Sony HDR-AS50R</a></h4>
                                <span><em>Size:</em> 20MP</span><span><em>Color:</em> Black</span>
                            </div>
                        </div>
                    </td>
                    <td class=""text-center"">
                        <div class=""count-input"">
                            <input type=""number"" step=""1"" min=""1"" max="""" name=""quantity"" value=""1"" title=""Qty"" class=""input-text qty text"" size=""4"" pattern=""[0-9]*"" inputmode=""numeric"" style=""width: 60px"">
                        </div>
                    </td>
                    <td class=""text-center text-lg text-medium"">$549.00</td>
                    <td class=""text-center"">&mdash;</td>
                    <td class=""text-center"">
                        <a class=""remove-from-cart"" href=""#"" data-toggle=""to");
            WriteLiteral("oltip\" title=\"Remove item\"><i class=\"icon-cross\"></i></a>\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"shopping-cart-footer\">\r\n        <div class=\"column\">\r\n            ");
            EndContext();
            BeginContext(5397, 265, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ad970687ea14838bce00f308052cbdc", async() => {
                BeginContext(5437, 218, true);
                WriteLiteral("\r\n                <input class=\"form-control form-control-sm\" type=\"text\" placeholder=\"Mã giảm giá\" required>\r\n                <button class=\"btn btn-outline-primary btn-sm\" type=\"submit\">Áp dụng</button>\r\n            ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5662, 777, true);
            WriteLiteral(@"
        </div>
        <div class=""column text-lg"">Thành tiền: <span class=""text-medium"">$1899</span></div>
    </div>
    <div class=""shopping-cart-footer"">
        <div class=""column"">
            <a class=""btn btn-outline-secondary"" href=""shop-grid-1.html""><i class=""icon-arrow-left""></i>&nbsp;Tiếp tục mua hàng</a>
        </div>
        <div class=""column"">
            <a class=""btn btn-primary"" href=""#"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Your cart"" data-toast-message=""is updated successfully!"">Cập nhật</a><a class=""btn btn-success"" href=""checkout-address.html"">Thanh toán</a>
        </div>
    </div>
    <!-- End Shopping Cart -->
</div>
<!-- End Cart Content -->");
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
