#pragma checksum "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\ProductType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56b5b76b16b8a8d308b47988daefee0aaa1e61ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductType_Index), @"mvc.1.0.view", @"/Views/ProductType/Index.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\ProductType\Index.cshtml"
using DataModels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b5b76b16b8a8d308b47988daefee0aaa1e61ab", @"/Views/ProductType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c52103ee359d3b5267ecf1fb5d3da13e6f0e345", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ProductType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductType>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminAssets/CustomCss/ProductType.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminAssets/CustomJs/ProductType.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\ProductType\Index.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56b5b76b16b8a8d308b47988daefee0aaa1e61ab5626", async() => {
                WriteLiteral(@"
        <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.4/jquery.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/screenfull.js/3.2.0/screenfull.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js""></script>
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css"">

    <style id=""compiled-css"" type=""text/css"">
        /*  html, body {
            position: relative;
            width: 100%;
            height: 100%;
            margin: 0;
            padding: 0
        }*/

        #content {
            display: inline-block;
            width: auto;
            height: auto;
            position: relative;
            background-color: #00f;
            text-align: center;
            padding: 100px;
            box-sizing: border-box
        }

        ");
                WriteLiteral(@"    #content.fullscreen {
                display: block;
                position: absolute;
                width: 100%;
                height: 100%;
                top: 0;
                left: 0
            }

        #showtoast {
            margin-left: 20px
        }

        #content p {
            color: #fff;
            font-weight: bold;
            text-align: center;
            max-width: 400px;
            margin-left: auto;
            margin-right: auto
        }
        .w-100{
            width:100%;
        }
        /* EOS */
    </style>






");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56b5b76b16b8a8d308b47988daefee0aaa1e61ab7571", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.0/css/all.min.css"" integrity=""sha512-10/jx2EXwxxWqCLX/hHth/vu2KY3jCF70dCQB8TSgNjbCVAC/8vai53GfMDrO2Emgwccf2pJqxct9ehpzG+MTw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
 
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""container-fluid"">
                <div class=""row justify-content-center"">
                    <div class=""col-12"">
                        <div class=""row align-items-center "">
                             <div class=""col my-4"">
                                <h2 class=""h3 mb-0 page-title"">Manage Product Types</h2>
                            </div>
                        </div>
                     
                       <div class=""col-md-12"">

                                 <div class="" "" id=""AddOrUpdate"">

                                       ");
#nullable restore
#line 84 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\ProductType\Index.cshtml"
                                  Write(await Html.PartialAsync("_AddPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                 </div>
                           </div>

               

                            <div class=""col-md-12"">
                                <div class=""row"">
                                    <!-- Small table -->
                                    <div class=""col-md-12 my-4"" id=""view-all"">

                                    
                                                <!-- table -->
                                                ");
#nullable restore
#line 97 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\ProductType\Index.cshtml"
                                           Write(await Html.PartialAsync("_ViewAll"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                             
                                           
                                   
                                    </div> <!-- customized table -->
                                </div> <!-- end section -->
                            </div>
                        </div>
                    </div> <!-- .col-12 -->
                </div> <!-- .row -->
            </div> <!-- .container-fluid -->
            <div class=""modal fade modal-notif modal-slide"" tabindex=""-1"" role=""dialog""
                aria-labelledby=""defaultModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog modal-sm"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""defaultModalLabel"">Notifications</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                ");
            WriteLiteral(@"<span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"">
                            <div class=""list-group list-group-flush my-n3"">
                                <div class=""list-group-item bg-transparent"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-auto"">
                                            <span class=""fe fe-box fe-24""></span>
                                        </div>
                                        <div class=""col"">
                                            <small><strong>Package has uploaded successfull</strong></small>
                                            <div class=""my-0 text-muted small"">Package is zipped and uploaded</div>
                                            <small class=""badge badge-pill badge-light text-muted"">1m ago</small>
                                     ");
            WriteLiteral(@"   </div>
                                    </div>
                                </div>
                                <div class=""list-group-item bg-transparent"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-auto"">
                                            <span class=""fe fe-download fe-24""></span>
                                        </div>
                                        <div class=""col"">
                                            <small><strong>Widgets are updated successfull</strong></small>
                                            <div class=""my-0 text-muted small"">Just create new layout Index, form, table
                                            </div>
                                            <small class=""badge badge-pill badge-light text-muted"">2m ago</small>
                                        </div>
                                    </div>
                            ");
            WriteLiteral(@"    </div>
                                <div class=""list-group-item bg-transparent"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-auto"">
                                            <span class=""fe fe-inbox fe-24""></span>
                                        </div>
                                        <div class=""col"">
                                            <small><strong>Notifications have been sent</strong></small>
                                            <div class=""my-0 text-muted small"">Fusce dapibus, tellus ac cursus commodo
                                            </div>
                                            <small class=""badge badge-pill badge-light text-muted"">30m ago</small>
                                        </div>
                                    </div> <!-- / .row -->
                                </div>
                                <div class=""list-group-item bg");
            WriteLiteral(@"-transparent"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-auto"">
                                            <span class=""fe fe-link fe-24""></span>
                                        </div>
                                        <div class=""col"">
                                            <small><strong>Link was attached to menu</strong></small>
                                            <div class=""my-0 text-muted small"">New layout has been attached to the menu
                                            </div>
                                            <small class=""badge badge-pill badge-light text-muted"">1h ago</small>
                                        </div>
                                    </div>
                                </div> <!-- / .row -->
                            </div> <!-- / .list-group -->
                        </div>
                        <div class=""modal-footer""");
            WriteLiteral(@">
                            <button type=""button"" class=""btn btn-secondary btn-block"" data-dismiss=""modal"">Clear
                                All</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal fade modal-shortcut modal-slide"" tabindex=""-1"" role=""dialog""
                aria-labelledby=""defaultModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""defaultModalLabel"">Shortcuts</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body px-5"">
                            <div cl");
            WriteLiteral(@"ass=""row align-items-center"">
                                <div class=""col-6 text-center"">
                                    <div class=""squircle bg-success justify-content-center"">
                                        <i class=""fe fe-cpu fe-32 align-self-center text-white""></i>
                                    </div>
                                    <p>Control area</p>
                                </div>
                                <div class=""col-6 text-center"">
                                    <div class=""squircle bg-primary justify-content-center"">
                                        <i class=""fe fe-activity fe-32 align-self-center text-white""></i>
                                    </div>
                                    <p>Activity</p>
                                </div>
                            </div>
                            <div class=""row align-items-center"">
                                <div class=""col-6 text-center"">
                     ");
            WriteLiteral(@"               <div class=""squircle bg-primary justify-content-center"">
                                        <i class=""fe fe-droplet fe-32 align-self-center text-white""></i>
                                    </div>
                                    <p>Droplet</p>
                                </div>
                                <div class=""col-6 text-center"">
                                    <div class=""squircle bg-primary justify-content-center"">
                                        <i class=""fe fe-upload-cloud fe-32 align-self-center text-white""></i>
                                    </div>
                                    <p>Upload</p>
                                </div>
                            </div>
                            <div class=""row align-items-center"">
                                <div class=""col-6 text-center"">
                                    <div class=""squircle bg-primary justify-content-center"">
                                        <i ");
            WriteLiteral(@"class=""fe fe-users fe-32 align-self-center text-white""></i>
                                    </div>
                                    <p>Users</p>
                                </div>
                                <div class=""col-6 text-center"">
                                    <div class=""squircle bg-primary justify-content-center"">
                                        <i class=""fe fe-settings fe-32 align-self-center text-white""></i>
                                    </div>
                                    <p>Settings</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"   
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js"" integrity=""sha512-VEd+nq25CkR676O+pLBnDW09R7VQX9Mdiij052gVCp5yVH3jGtH70Ho/UUv4mJDsEdTvqRCFZg0NKGiojGnUCw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
 
");
#nullable restore
#line 240 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\ProductType\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56b5b76b16b8a8d308b47988daefee0aaa1e61ab21460", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#nullable restore
#line 246 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\ProductType\Index.cshtml"
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56b5b76b16b8a8d308b47988daefee0aaa1e61ab23054", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#nullable restore
#line 247 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\ProductType\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


            <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <script type=""text/javascript"">

        toastr.options = {
            ""closeButton"": false,
            ""debug"": false,
            ""newestOnTop"": false,
            ""progressBar"": true,
            ""positionClass"": ""toast-top-center"",
            ""preventDuplicates"": false,
            ""onclick"": null,
            ""showDuration"": ""300"",
            ""hideDuration"": ""1000"",
            ""timeOut"": ""5000"",
            ""extendedTimeOut"": ""1000"",
            ""showEasing"": ""swing"",
            ""hideEasing"": ""linear"",
            ""showMethod"": ""fadeIn"",
            ""hideMethod"": ""fadeOut""
        };
       

    </script>
       
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56b5b76b16b8a8d308b47988daefee0aaa1e61ab25477", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductType>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
