#pragma checksum "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Review\_AddPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5bc1f856215731246f8abdd5ccf918b23ff7e1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Review__AddPartial), @"mvc.1.0.view", @"/Views/Review/_AddPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5bc1f856215731246f8abdd5ccf918b23ff7e1c", @"/Views/Review/_AddPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c52103ee359d3b5267ecf1fb5d3da13e6f0e345", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Review__AddPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Review\_AddPartial.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-12"">
    <div class=""card shadow "">
        <div class=""form-row card-body"">

            <div class=""form-group col-md-4"">
                <label for=""firstname"">First Name</label>
                <input type=""text"" id=""FirstName"" class=""form-control"" onkeyup=""resetValidationSingle(event)"">
                <small id=""FirstNameErr"" class=""text-danger""></small>
            </div>
            <div class=""form-group col-md-4"">
                                    <label for=""inputLang"">Last Name</label>
                                    <input id=""LastName"" type=""text""");
            BeginWriteAttribute("onchange", " onchange=\"", 753, "\"", 764, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color: #000;""  class=""form-control""  />
                                    <small class=""text-danger"" id=""LastNameErr""></small>
                                </div>
                                 <div class=""form-group col-md-4"">
                                    <label for=""inputLang"">Email</label>
                                    <input id=""Email"" type=""text""");
            BeginWriteAttribute("onchange", " onchange=\"", 1151, "\"", 1162, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color: #000;""  class=""form-control""  />
                                    <small class=""text-danger"" id=""EmailErr""></small>
                                </div>
                                 <div class=""form-group col-md-4"">
                                    <label for=""inputLang"">Rating</label>
                                    <input id=""Rating"" type=""text""");
            BeginWriteAttribute("onchange", " onchange=\"", 1548, "\"", 1559, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color: #000;""  class=""form-control""  />
                                    <small class=""text-danger"" id=""RatingErr""></small>
                                </div>
                                 <div class=""form-group col-md-4"">
                                    <label for=""inputLang"">Reviews</label>
                                    <input id=""Reviews"" type=""text""");
            BeginWriteAttribute("onchange", " onchange=\"", 1948, "\"", 1959, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color: #000;""  class=""form-control""  />
                                    <small class=""text-danger"" id=""ReviewsErr""></small>
                                </div>
            <div class=""form-group col-md-2 text-center p-35"">
                <div class=""custom-control custom-checkbox"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""active"" checked>
                    <label class=""custom-control-label"" for=""active"">Active</label>
                </div>
            </div>
            <div class=""col-md-1 text-left p-28 "">
                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2562, "\"", 2619, 3);
            WriteAttributeValue("", 2572, "SaveReview(\'", 2572, 12, true);
#nullable restore
#line 45 "C:\Users\DELL\Desktop\New folder (2)\Med-Ambian\Views\Review\_AddPartial.cshtml"
WriteAttributeValue("", 2584, Url.Action("AddOrEdit","Review"), 2584, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2617, "\')", 2617, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-primary"">Submit</button>
            </div>
            <div class=""col-md-2 text-left p-28"">
                <button type=""button"" onclick=""Clear()"" class=""btn btn-secondary"">Reset</button>
            </div>
            
        </div>
    </div>
</div>
   
      
                      
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
