#pragma checksum "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f296d20131af0aad20563cfb86f7e01e3359af1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_SeeBook), @"mvc.1.0.view", @"/Views/Book/SeeBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/SeeBook.cshtml", typeof(AspNetCore.Views_Book_SeeBook))]
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
#line 1 "C:\Users\RX\source\repos\laboration3\laboration3\Views\_ViewImports.cshtml"
using laboration3;

#line default
#line hidden
#line 2 "C:\Users\RX\source\repos\laboration3\laboration3\Views\_ViewImports.cshtml"
using laboration3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f296d20131af0aad20563cfb86f7e01e3359af1b", @"/Views/Book/SeeBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e575167c8420b6e92835368c7899fb4d63b8b26", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_SeeBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<laboration3.Models.BookDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Booklist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
  
    ViewData["Title"] = "SeeBook";

#line default
#line hidden
            BeginContext(83, 133, true);
            WriteLiteral("\r\n<h1>SeeBook</h1>\r\n\r\n<div>\r\n    <h4>BookDetail</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(217, 38, false);
#line 14 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(255, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(319, 34, false);
#line 17 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(353, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(416, 41, false);
#line 20 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(457, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(521, 37, false);
#line 23 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(558, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(621, 47, false);
#line 26 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(668, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(732, 43, false);
#line 29 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(775, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(838, 41, false);
#line 32 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(879, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(943, 37, false);
#line 35 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(980, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1043, 42, false);
#line 38 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
       Write(Html.DisplayNameFor(model => model.Usr_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1149, 38, false);
#line 41 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
       Write(Html.DisplayFor(model => model.Usr_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 43, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 46 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
     if (ViewBag.error != "")
    {

#line default
#line hidden
            BeginContext(1268, 31, true);
            WriteLiteral("        <p style=\"color: red;\">");
            EndContext();
            BeginContext(1300, 13, false);
#line 48 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
                          Write(ViewBag.error);

#line default
#line hidden
            EndContext();
            BeginContext(1313, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 49 "C:\Users\RX\source\repos\laboration3\laboration3\Views\Book\SeeBook.cshtml"
    }

#line default
#line hidden
            BeginContext(1326, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1330, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f296d20131af0aad20563cfb86f7e01e3359af1b8909", async() => {
                BeginContext(1355, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1371, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<laboration3.Models.BookDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
