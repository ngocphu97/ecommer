#pragma checksum "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Account\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6f7074364615545c139c379785217efb39f9528"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_OrderDetail), @"mvc.1.0.view", @"/Views/Account/OrderDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/OrderDetail.cshtml", typeof(AspNetCore.Views_Account_OrderDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7074364615545c139c379785217efb39f9528", @"/Views/Account/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Account\OrderDetail.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 7820, true);
            WriteLiteral(@"
<!-- Start Page Title -->
<div class=""page-title"">
    <div class=""container"">
        <div class=""column"">
            <h1>Chi tiết đơn hàng</h1>
        </div>
        <div class=""column"">
            <ul class=""breadcrumbs"">
                <li><a href=""index-1.html"">Trang chủ</a></li>
                <li class=""separator"">&nbsp;</li>
                <li><a href=""account-orders.html"">Đơn hàng của tôi</a></li>
                <li class=""separator"">&nbsp;</li>
                <li>Chi tiết đơn hàng</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Title -->
<!-- Start My Orders -->
<div class=""container padding-top-1x padding-bottom-3x"">
    <div class=""row"">
        <div class=""col-lg-4"">
            <aside class=""user-info-wrapper"">
                <div class=""user-cover account-details"">
                    <div class=""info-label"" data-toggle=""tooltip"" title=""You currently have 530 Reward Points to spend""><i class=""icon-medal""></i>530 Điểm</div>
              ");
            WriteLiteral(@"  </div>
                <div class=""user-info"">
                    <div class=""user-avatar""><a class=""edit-avatar"" href=""#""></a><img src=""/assets/images/account/user-ava.jpg"" alt=""User""></div>
                    <div class=""user-data"">
                        <h4>Tony Stark</h4><span>Joined February 06, 2018</span>
                    </div>
                </div>
            </aside>
            <nav class=""list-group"">
                <a class=""list-group-item"" href=""account-profile.html""><i class=""icon-head""></i>Thông tin tài khoản</a>
                <a class=""list-group-item"" href=""account-bank.html""><i class=""icon-columns""></i>Ngân hàng</a>
                <a class=""list-group-item with-badge"" href=""account-orders.html""><i class=""icon-bag""></i>Đơn hàng<span class=""badge badge-primary badge-pill"">6</span></a>
                <a class=""list-group-item with-badge"" href=""account-wishlist.html""><i class=""icon-heart""></i>Sản phẩm đã thích<span class=""badge badge-primary badge-pill"">3</span></a>");
            WriteLiteral(@"
                <a class=""list-group-item with-badge"" href=""account-notification.html""><i class=""icon-bell""></i>Thông báo<span class=""badge badge-primary badge-pill"">4</span></a>
                <a class=""list-group-item"" href=""account-changepass.html""><i class=""icon-repeat""></i>Đổi mật khẩu</a>
            </nav>
        </div>
        <div class=""col-lg-8"">
            <div class=""padding-top-2x mt-2 hidden-lg-up""></div>
            <div class=""pt-1 mb-1"">
                <h4>Thông tin đơn hàng</h4>
                <hr><br>
                <div class=""row"">
                    <div class=""col-sm-1""></div>
                    <div class=""col-sm-5"">
                        <span class=""text-lg"">Mã đơn hàng:</span> #17685932
                    </div>
                    <div class=""col-sm-6"">
                        <span class=""text-lg"">Ngày đặt:</span> 13-11-2018
                    </div>
                    <div class=""col-sm-1""></div>
                    <div class=""col-sm-5"">
      ");
            WriteLiteral(@"                  <span class=""text-lg"">Tình trạng:</span> Đang giao
                    </div>
                    <div class=""col-sm-5"">
                        <span class=""text-lg"">Tổng tiền:</span> 12.500.000 Đ
                    </div>
                </div>
            </div>
            <br>
            <div class=""table-responsive"">
                <h4>Các sản phẩm trong đơn hàng</h4>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Tên sản phẩm</th>
                            <th class=""text-center"">Số lượng</th>
                            <th class=""text-center"">Đơn giá</th>
                            <th class=""text-center"">Tổng</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <div class=""table-responsive shopping-cart"">
                                    <di");
            WriteLiteral(@"v class=""product-item"">
                                        <a href=""shop-single-1.html"">
                                            <img src=""/assets/images/shop/cart/01.jpg"" alt=""Product"" width=""100"">
                                        </a>
                                        <div class=""product-info"">
                                            <h4 class=""product-title""><a href=""shop-single-1.html"">iPhone X Black</a></h4>
                                            <span><em>Size:</em> 64GB</span><span><em>Color:</em> Gold</span>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td class=""text-center text-lg text-medium"">1</td>
                            <td class=""text-center text-lg text-medium"">$649</td>
                            <td class=""text-center text-lg text-medium"">$649</td>
                        </tr>
                    ");
            WriteLiteral(@"    <tr>
                            <td>
                                <div class=""table-responsive shopping-cart"">
                                    <div class=""product-item"">
                                        <a href=""shop-single-1.html"">
                                            <img src=""/assets/images/shop/cart/01.jpg"" alt=""Product"" width=""100"">
                                        </a>
                                        <div class=""product-info"">
                                            <h4 class=""product-title""><a href=""shop-single-1.html"">iPhone X Black</a></h4>
                                            <span><em>Size:</em> 64GB</span><span><em>Color:</em> Gold</span>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td class=""text-center text-lg text-medium"">1</td>
                            <td class=""text-center text-");
            WriteLiteral(@"lg text-medium"">$649</td>
                            <td class=""text-center text-lg text-medium"">$649</td>
                        </tr>
                        <tr>
                            <td>
                                <div class=""table-responsive shopping-cart"">
                                    <div class=""product-item"">
                                        <a href=""shop-single-1.html"">
                                            <img src=""/assets/images/shop/cart/01.jpg"" alt=""Product"" width=""100"">
                                        </a>
                                        <div class=""product-info"">
                                            <h4 class=""product-title""><a href=""shop-single-1.html"">iPhone X Black</a></h4>
                                            <span><em>Size:</em> 64GB</span><span><em>Color:</em> Gold</span>
                                        </div>
                                    </div>
                                </div>
          ");
            WriteLiteral(@"                  </td>
                            <td class=""text-center text-lg text-medium"">1</td>
                            <td class=""text-center text-lg text-medium"">$649</td>
                            <td class=""text-center text-lg text-medium"">$649</td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div>
                <hr class=""mt-1 mb-2"">
                <center><button class=""btn btn-primary margin-right-none"" type=""button""><!-- disabled -->Huỷ đơn hàng</button></center>
            </div>
        </div>
    </div>
</div>
<!-- End My Orders -->");
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
