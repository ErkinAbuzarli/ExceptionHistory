#pragma checksum "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b062855199cd074345817b376f78379d3277762e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExceptionHistory.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ExceptionHistory.Pages
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
#line 1 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\_ViewImports.cshtml"
using ExceptionHistory;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b062855199cd074345817b376f78379d3277762e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8208fbce0d1f4a1c3ae44b97b2cf48f02a014c9c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    var today = DateTime.Today.ToString("yyyy-MM-dd");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row "">
  <div class="" col-4"">
    <label for=""exampleFormControlInput1"" class=""form-label""
      >Project Name</label
    >
    <input
      type=""email""
      class=""form-control""
      id=""exampleFormControlInput1""
    />
  </div>
    <div class=""col-4"">
    <label for=""exampleDataList"" class=""form-label"">Catagory</label>
    <input
      class=""form-control""
      list=""datalistOptions""
      id=""exampleDataList""
      placeholder=""Tap to get hint""
    />
    <datalist id=""datalistOptions"">
");
#nullable restore
#line 28 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
     foreach (var item in Model.Records){


#line default
#line hidden
#nullable disable
            WriteLiteral("      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b062855199cd074345817b376f78379d3277762e3868", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
         WriteLiteral(item.Catagory);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </datalist>\r\n  </div>\r\n  <div class=\"col-4\">\r\n    <label for=\"start\" class=\"form-label\">Date</label>\r\n    <input\r\n      class=\"form-control\"\r\n      type=\"date\"\r\n      id=\"start\"\r\n      name=\"trip-start\"");
            BeginWriteAttribute("value", "\r\n      value=\"", 959, "\"", 980, 1);
#nullable restore
#line 41 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
WriteAttributeValue("", 974, today, 974, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n      min=\"2018-01-01\"");
            BeginWriteAttribute("max", "\r\n      max=\"", 1005, "\"", 1024, 1);
#nullable restore
#line 43 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
WriteAttributeValue("", 1018, today, 1018, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
    />
  </div>

</div>

<div class=""mb-md-3 mt-md-3 mx-auto"">
  <label for=""exampleFormControlTextarea1"" class=""form-label""
    >Note</label
  >
  <textarea
    class=""form-control""
    id=""exampleFormControlTextarea1""
    rows=""3""
  ></textarea>
</div>

  <div class=""col-md-4 mx-auto mb-3"">
    <button type=""button"" class=""btn text btn-primary btn-block"">Add New Exception</button>
  </div>
  

   <table class=""table"">     
   <thead>
        <tr>
            <th >
                ");
#nullable restore
#line 69 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Records[0].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
#nullable restore
#line 72 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Records[0].ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th> \r\n            <th >\r\n                ");
#nullable restore
#line 75 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Records[0].DateOfException));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
#nullable restore
#line 78 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Records[0].Catagory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
#nullable restore
#line 81 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Records[0].Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n   <tbody>\r\n");
#nullable restore
#line 86 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
 foreach (var item in Model.Records) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 96 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfException));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 99 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Catagory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 102 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 105 "C:\Users\Erkin\Desktop\ExceptionHistory\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591