#pragma checksum "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8797ed4acdfd3f69a4c400b14e237a170c941d57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Create.cshtml", typeof(AspNetCore.Views_Product_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8797ed4acdfd3f69a4c400b14e237a170c941d57", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Product/Tao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 1846, true);
            WriteLiteral(@"<style>
    .inputfile {
        width: 0.1px;
        height: 0.1px;
        opacity: 0;
        overflow: hidden;
        position: absolute;
        z-index: -1;
    }

        .inputfile + label {
            height: 180px;
            width: 180px;
            font-size: 1.25em;
            font-weight: 700;
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
            border: .2rem dashed #bababa;
        }


            .inputfile:focus + label,
            .inputfile + label:hover {
                cursor: pointer;
            }

        .inputfile + label {
            cursor: pointer;
            /* ""hand"" cursor */
        }

        .inputfile:focus + label {
            outline: 1px dotted #000;
            outline: -webkit-focus-ring-color auto 5px;
        }

    .image-preview {
        border: 1px solid;
        width: 180px;
        height: 180px;
        margin-right:");
            WriteLiteral(@" 8px;
        margin-bottom: 8px;
    }

    .cons {
        position: relative;
    }

    .cancel-action {
        position: absolute;
        transform: translate(-50%, -50%);
        -ms-transform: translate(-50%, -50%);
        top: 11%;
        left: 86%;
    }

    .images-detail {
        display: flex;
    }

    .price {
        background: #FAFAFA;
        font-weight: 500;
        color: #ff5722;
        justify-content: center;
        align-items: center;
        display: flex;
    }

        .price .currency {
            font-size: 1.5rem;
        }

        .price .value {
            font-size: 2.5rem;
            margin: 0 20px 0 5px;
        }

        .price .center {
            background: #ff5722;
            color: #ffffff
        }
</style>

");
            EndContext();
            BeginContext(1881, 12, false);
#line 91 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
Write(ViewBag.mess);

#line default
#line hidden
            EndContext();
            BeginContext(1893, 1437, true);
            WriteLiteral(@"

<div class=""content"">
    <div class=""animated fadeIn row"">
        <div class=""col-lg-12"">
            <div class=""card"">

                <div class=""card-header"">
                    <strong class=""card-title"" style=""font-size: 25px"">THÊM SẢN PHẨM</strong>
                </div>

                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div style=""display: flex"">
                                <div class=""preview"" style=""margin-right: 10px"">
                                    <input type=""file"" name=""file"" id=""file"" class=""inputfile"" onchange=""readURL(this);"" />
                                    <label for=""file"">
                                        <i class=""fa fa-plus"" style=""color: #bababa""></i>
                                        <i>Thêm hình ảnh</i>
                                    </label>
                                </div>
                                <div>
");
            WriteLiteral(@"                                    <div id=""img-preview"" style=""display: flex"">
                                    </div>
                                </div>
                            </div>

                        </div>

                        <button onclick=""postData()"">Click</button>

                        <div class=""col-md-12"">
                            <div class=""information"">
");
            EndContext();
#line 125 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                 using (Html.BeginForm())
                                {

#line default
#line hidden
            BeginContext(3424, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3456, 15533, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd16fccd771e422182dc92531f3df5ff", async() => {
                BeginContext(3498, 1554, true);
                WriteLiteral(@"
                                    <div class=""action float-right"">
                                        <button class=""btn btn-sm btn-warning btn-primary-custom"" style=""color: #ffffff"">
                                            <i class=""fa fa-save""></i> Lưu
                                        </button>
                                    </div>

                                    <input type=""submit"" value=""Create"" class=""btn btn-default"" />

                                    <br>
                                    <h4>
                                        <a data-toggle=""collapse"" href=""#basicInfomation"" role=""button""
                                           aria-expanded=""false"" aria-controls=""basicInfomation"">
                                            Thông tin cơ bản <i class=""fa fa-angle-double-down""></i>
                                        </a>
                                    </h4>
                                    <br>
                                 ");
                WriteLiteral(@"   <div class=""collapse"" id=""basicInfomation"">
                                        <div class=""collapse"" id=""basicInfomation"">
                                            <div class=""form-group row"">
                                                <label class=""col-md-2"">
                                                    Tên sản phẩm
                                                </label>
                                                <div class=""col-md-10"">
                                                    ");
                EndContext();
                BeginContext(5053, 66, false);
#line 151 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                               Write(Html.TextBox("productName", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(5119, 551, true);
                WriteLiteral(@"
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label for=""colFormLabelSm"" class=""col-md-2"">
                                                    Mô tả sản phẩm (Tối đa 500 ký tự)
                                                </label>
                                                <div class=""col-md-10"">
                                                    ");
                EndContext();
                BeginContext(5671, 67, false);
#line 160 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                               Write(Html.TextArea("description", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(5738, 526, true);
                WriteLiteral(@"
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label for=""colFormLabelSm"" class=""col-md-2"">
                                                    Nội dung
                                                </label>
                                                <div class=""col-md-10"">
                                                    ");
                EndContext();
                BeginContext(6265, 67, false);
#line 169 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                               Write(Html.TextArea("information", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(6332, 617, true);
                WriteLiteral(@"
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label for=""colFormLabelSm"" class=""col-md-2"">
                                                    Danh mục sản phẩm
                                                </label>
                                                <div class=""col-md-10"">
                                                    <div class=""form-group"">
                                                        ");
                EndContext();
                BeginContext(6950, 223, false);
#line 179 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                                   Write(Html.DropDownList("danhmucsp",
                                                     new SelectList(Enum.GetValues(typeof(TenDanhMuc))),
                                                     new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(7173, 675, true);
                WriteLiteral(@"
                                                    </div>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label for=""colFormLabelSm"" class=""col-md-2"">
                                                    Tình trạng hàng
                                                </label>
                                                <div class=""col-md-10"">
                                                    <div class=""form-group"">
                                                        ");
                EndContext();
                BeginContext(7849, 228, false);
#line 192 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                                   Write(Html.DropDownList("productStatus",
                                                    new SelectList(Enum.GetValues(typeof(TinhTrangHang))),
                                                    new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(8077, 586, true);
                WriteLiteral(@"
                                                    </div>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label for=""colFormLabelSm"" class=""col-md-2"">
                                                    Bảo hành
                                                </label>
                                                <div class=""col-md-10"">
                                                    ");
                EndContext();
                BeginContext(8664, 68, false);
#line 204 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                               Write(Html.TextBox("guaranteeTime", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(8732, 1176, true);
                WriteLiteral(@"
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                    <br>
                                    <h4>
                                        <a data-toggle=""collapse"" href=""#productConfig"" role=""button""
                                           aria-expanded=""false"" aria-controls=""productConfig"">
                                            Cấu hình sản phẩm <i class=""fa fa-angle-double-down""></i>
                                        </a>
                                    </h4>
                                    <br>

                                    <div class=""collapse"" id=""productConfig"">
                                        <div class=""form-group row "">
                                            <label class=""col-md-2"">
                                                Thương hiệu
                   ");
                WriteLiteral("                         </label>\r\n                                            <div class=\"col-md-10\">\r\n                                                ");
                EndContext();
                BeginContext(9909, 60, false);
#line 225 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("brand", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(9969, 471, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Bộ nhớ
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(10441, 61, false);
#line 234 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("memory", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(10502, 469, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Mạng
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(10972, 62, false);
#line 243 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("network", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(11034, 468, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                SIM
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(11503, 58, false);
#line 252 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("sim", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(11561, 480, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Chống thấm nước
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(12042, 239, false);
#line 261 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.DropDownList("waterproof",
                                                           new SelectList(Enum.GetValues(typeof(ChongThamNuoc))),
                                                           new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(12281, 473, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Màn hình
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(12755, 61, false);
#line 272 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("screen", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(12816, 477, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Hệ điều hành
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(13294, 61, false);
#line 281 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("system", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(13355, 468, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Ram
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(13824, 58, false);
#line 290 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("ram", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(13882, 477, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Camera trước
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(14360, 63, false);
#line 299 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("frontCam", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(14423, 475, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Camera sau
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(14899, 64, false);
#line 308 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("behindCam", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(14963, 474, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Bluetooth
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(15438, 64, false);
#line 317 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("bluetooth", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(15502, 468, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Pin
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(15971, 62, false);
#line 326 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("battery", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(16033, 1101, true);
                WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>

                                    <br>
                                    <h4>
                                        <a data-toggle=""collapse"" href=""#productType"" role=""button""
                                           aria-expanded=""false"" aria-controls=""productType"">
                                            Loại sản phẩm <i class=""fa fa-angle-double-down""></i>
                                        </a>
                                    </h4>
                                    <br>

                                    <div class=""collapse"" id=""productType"">
                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Màu
                                            </label>
                                        ");
                WriteLiteral("    <div class=\"col-md-10\">\r\n                                                ");
                EndContext();
                BeginContext(17135, 60, false);
#line 346 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("color", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(17195, 472, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Giá bán
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(17668, 61, false);
#line 355 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("sellPrice", 0, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(17729, 472, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Giá gốc
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(18202, 57, false);
#line 364 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("price", 0, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(18259, 479, true);
                WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2"">
                                                Giá khuyến mãi
                                            </label>
                                            <div class=""col-md-10"">
                                                ");
                EndContext();
                BeginContext(18739, 65, false);
#line 373 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                           Write(Html.TextBox("discountPrice", 0, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(18804, 178, true);
                WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                ");
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
            BeginContext(18989, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 378 "F:\projects\CamPhoneShop\CamPhoneShop\WebMobileMVC\Views\Product\Create.cshtml"
                                }

#line default
#line hidden
            BeginContext(19026, 3891, true);
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>

<script src=""https://cdn.jsdelivr.net/npm/jquery@2.2.4/dist/jquery.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.14.4/dist/umd/popper.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/js/bootstrap.min.js""></script>
<script src=""assets/js/main.js""></script>

<script>
    var temp = [];

    function readURL(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var x = document.createElement(""img"");
                x.setAttribute(""src"", e.target.result);
                x.setAttribute(""class"", ""image-preview"")
                x.setAttribute(""alt"", ""image preview"");
                x.setAttribute(""id"", ""image-preview"");

                var btn = document.create");
            WriteLiteral(@"Element(""button"");
                btn.setAttribute(""class"", ""btn btn-sm btn-danger"");

                var icon = document.createElement(""i"");
                icon.className = ""fa fa-times"";
                btn.appendChild(icon);

                var cancelAction = document.createElement(""div"");
                cancelAction.setAttribute(""class"", ""cancel-action"");
                cancelAction.appendChild(btn);

                var container = document.createElement(""div"");
                container.setAttribute(""class"", ""cons"");

                container.appendChild(x);
                container.appendChild(cancelAction);

                document.getElementById(""img-preview"").appendChild(container);

                btn.addEventListener(""click"", function () {
                    container.parentNode.removeChild(container);
                });

                // thêm vô mảng với xóa mảng

            };
            reader.readAsDataURL(input.files[0]);
        }
    }

    func");
            WriteLiteral(@"tion postData() {
        var product = {
            Ten: ""san pham test"",
            IDDanhMuc: 1,
            Mota: ""Day la mo ta"",
            NoiDung: ""Noi dung"",
            Hinh: ""Hinh 1"",
            HinhCT: ""hinh 1"",
            ThoiGianBH: 10,
            TinhTrangHang: true,

            CauHinh: {
                ThuongHieu: ""samsung"",
                BoNho: ""256gb"",
                Mang: ""lte"",
                Sim: ""1 sim"",
                ChongThamNuoc: ""khong"",
                KTManHinh: ""4inch"",
                HeDieuHanh: ""android"",
                Ram: ""1gb"",
                CMRTruoc: ""khong"",
                CMRSau: ""co"",
                GPS: ""co"",
                Bluetooth: ""co"",
                Pin: ""2000mh""
            },
            PhanLoaiSP: [
                {
                    SoLuong: 3,
                    GiaKM: 600,
                    GiaBan: 12000,
                    GiaGoc: 11000,
                    Mau: ""black""
                },
     ");
            WriteLiteral(@"           {
                    SoLuong: 10,
                    GiaKM: 900,
                    GiaBan: 15000,
                    GiaGoc: 12000,
                    Mau: ""blue""
                }
            ]
        };
        
        $.ajax({
            type: 'PUT',
            url: ""http://localhost:57233/api/sanpham/add"",
            data: JSON.stringify(product),
            success: function (returnPayload) {
                console && console.log(""request succeeded"");
            },
            error: function (xhr, ajaxOptions, thrownError) {
                console && console.log(""request failed"");
            },
            dataType: ""xml"",
            contentType: ""application/json"",
            processData: false,
            async: false
        });
    }
</script>");
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