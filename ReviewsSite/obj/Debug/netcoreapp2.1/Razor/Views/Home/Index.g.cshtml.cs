#pragma checksum "C:\Users\WeCanCodeIT\source\repos\ReviewsSite\ReviewsSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87d2d7b37e5e2cd7c91bcfa8de0e713b173277f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87d2d7b37e5e2cd7c91bcfa8de0e713b173277f1", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReviewsSite.Models.Review>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\WeCanCodeIT\source\repos\ReviewsSite\ReviewsSite\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(74, 19, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n");
            EndContext();
            BeginContext(94, 5, false);
#line 7 "C:\Users\WeCanCodeIT\source\repos\ReviewsSite\ReviewsSite\Views\Home\Index.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(99, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(109, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69e17b3b3824415490aa05b09e7e37bf", async() => {
                BeginContext(115, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(209, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(211, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c41cd237687f40b4ac2bf840917fd0e8", async() => {
                BeginContext(217, 29, true);
                WriteLiteral("\r\n    <h1>My Reviews</h1>\r\n\r\n");
                EndContext();
#line 16 "C:\Users\WeCanCodeIT\source\repos\ReviewsSite\ReviewsSite\Views\Home\Index.cshtml"
     foreach (var review in Model)
    {

#line default
#line hidden
                BeginContext(289, 29, true);
                WriteLiteral("        <div>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 318, "\"", 349, 2);
                WriteAttributeValue("", 325, "/Home/Details/", 325, 14, true);
#line 19 "C:\Users\WeCanCodeIT\source\repos\ReviewsSite\ReviewsSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 339, review.Id, 339, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(350, 19, true);
                WriteLiteral(">\r\n                ");
                EndContext();
                BeginContext(370, 11, false);
#line 20 "C:\Users\WeCanCodeIT\source\repos\ReviewsSite\ReviewsSite\Views\Home\Index.cshtml"
           Write(review.Name);

#line default
#line hidden
                EndContext();
                BeginContext(381, 36, true);
                WriteLiteral("\r\n            </a>\r\n        </div>\r\n");
                EndContext();
#line 23 "C:\Users\WeCanCodeIT\source\repos\ReviewsSite\ReviewsSite\Views\Home\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(424, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(433, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReviewsSite.Models.Review>> Html { get; private set; }
    }
}
#pragma warning restore 1591