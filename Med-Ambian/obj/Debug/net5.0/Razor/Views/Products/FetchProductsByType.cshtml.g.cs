#pragma checksum "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6f610693dca4cce084fa9bd794b00e26a8b20a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_FetchProductsByType), @"mvc.1.0.view", @"/Views/Products/FetchProductsByType.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\_ViewImports.cshtml"
using Med_Ambian;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\_ViewImports.cshtml"
using Med_Ambian.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
using Dtos.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6f610693dca4cce084fa9bd794b00e26a8b20a6", @"/Views/Products/FetchProductsByType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c52103ee359d3b5267ecf1fb5d3da13e6f0e345", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_FetchProductsByType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductByTypeDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/cart/cart.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""site-wrap"">


   

    <!-- product section -->
    <div class=""product-section layout_padding"" data-aos=""fade-up"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 offset-lg-2 text-center"">
                    <div class=""section-title"">
                        <h3><span class=""blue-text"">ANTI-</span>ANXIETY</h3>

                    </div>
                </div>
            </div>

            <div class=""row"">
");
#nullable restore
#line 26 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
                 if (Model.Any())
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-3 col-md-4 col-sm-12\">\r\n                            <div class=\"Jewellery-box\">\r\n                        <h5>$ ");
#nullable restore
#line 32 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <i>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1037, "\"", 1108, 1);
#nullable restore
#line 34 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
WriteAttributeValue("", 1044, Url.Action("Product_Details","Products",new{productId=item.Id}), 1044, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d6f610693dca4cce084fa9bd794b00e26a8b20a66291", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1133, "~/Product/", 1133, 10, true);
#nullable restore
#line 34 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
AddHtmlAttributeValue("", 1143, item.Image, 1143, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        </i>\r\n                        <h3>");
#nullable restore
#line 36 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                          <a style=\"color:#fff!important;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1297, "\"", 1354, 3);
            WriteAttributeValue("", 1307, "location.href=\'", 1307, 15, true);
#nullable restore
#line 37 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
WriteAttributeValue("", 1322, Url.Action("SignUp","Account"), 1322, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1353, "\'", 1353, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"test-btn\">\r\n");
            WriteLiteral("                            Add to Cart\r\n                        </a>\r\n                    </div>  </div>\r\n");
#nullable restore
#line 42 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
                    }}else{
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-3 col-md-4 col-sm-12\">\r\n                            <div class=\"Jewellery-box\">\r\n\r\n                                <p>No product found under this type</p>\r\n                            </div></div>\r\n");
#nullable restore
#line 49 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"view-more-products\">\r\n                    <a link asp-append-version=\"true\" rel=\"stylesheet\"");
            BeginWriteAttribute("href", " href=\"", 2107, "\"", 2155, 1);
#nullable restore
#line 51 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
WriteAttributeValue("", 2114, Url.Action("Filter_Products","Products"), 2114, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        View More
                    </a>
                </div>
            </div>
        </div>
    </div>
    <!-- end product section -->

</div>
 <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.4/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/screenfull.js/3.2.0/screenfull.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6f610693dca4cce084fa9bd794b00e26a8b20a610863", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 65 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Products\FetchProductsByType.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductByTypeDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
