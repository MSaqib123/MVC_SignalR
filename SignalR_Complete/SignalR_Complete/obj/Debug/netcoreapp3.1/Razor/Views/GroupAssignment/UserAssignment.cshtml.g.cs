#pragma checksum "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\GroupAssignment\UserAssignment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "732721e62b7875094f0fdf495c6dc2fcd4ab9dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroupAssignment_UserAssignment), @"mvc.1.0.view", @"/Views/GroupAssignment/UserAssignment.cshtml")]
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
#line 1 "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\_ViewImports.cshtml"
using SignalR_Complete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\_ViewImports.cshtml"
using SignalR_Complete.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"732721e62b7875094f0fdf495c6dc2fcd4ab9dfa", @"/Views/GroupAssignment/UserAssignment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c097ad0d4a0f6d5b79a8c964eea5a476245652", @"/Views/_ViewImports.cshtml")]
    public class Views_GroupAssignment_UserAssignment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupAssignmentViewModel>
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
            WriteLiteral("\r\n<h2>Group Assignment - User Assignment</h2>\r\n\r\n");
#nullable restore
#line 5 "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\GroupAssignment\UserAssignment.cshtml"
 using (Html.BeginForm("AssignUsers", "GroupAssignment", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <label for=\"groupId\">Selected Group:</label>\r\n        <label><b>");
#nullable restore
#line 9 "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\GroupAssignment\UserAssignment.cshtml"
              Write(Model.SelectedGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></label>\r\n        <input type=\"text\" id=\"selectedGroup\" name=\"selectedGroup\"");
            BeginWriteAttribute("value", " value=\"", 346, "\"", 374, 1);
#nullable restore
#line 10 "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\GroupAssignment\UserAssignment.cshtml"
WriteAttributeValue("", 354, Model.SelectedGroup, 354, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden/>\r\n    </div>\r\n    <div>\r\n        <label for=\"userId\">Select Users:</label>\r\n        <select name=\"userIds\" id=\"userId\" multiple>\r\n");
#nullable restore
#line 15 "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\GroupAssignment\UserAssignment.cshtml"
             foreach (var user in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "732721e62b7875094f0fdf495c6dc2fcd4ab9dfa4796", async() => {
#nullable restore
#line 17 "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\GroupAssignment\UserAssignment.cshtml"
                                    Write(user.UserName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\GroupAssignment\UserAssignment.cshtml"
                   WriteLiteral(user.Id);

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
#line 18 "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\GroupAssignment\UserAssignment.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>\r\n    </div>\r\n    <div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Assign Users</button>\r\n    </div>\r\n");
#nullable restore
#line 24 "D:\PK\Evolve\UI .net\SignalR_Complete\SignalR_Complete\Views\GroupAssignment\UserAssignment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script>\r\n<script>\r\n    \r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupAssignmentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
