#pragma checksum "D:\PK\Evolve\UI .net\signalR_GPT\signalR_GPT\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305396ae4d40d81be7c66e84646b94c18f6c4e5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
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
#line 1 "D:\PK\Evolve\UI .net\signalR_GPT\signalR_GPT\Views\_ViewImports.cshtml"
using signalR_GPT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PK\Evolve\UI .net\signalR_GPT\signalR_GPT\Views\_ViewImports.cshtml"
using signalR_GPT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305396ae4d40d81be7c66e84646b94c18f6c4e5b", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce4ccdfc18f1b3de532c6b144b00ad46f423122", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/designM.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "305396ae4d40d81be7c66e84646b94c18f6c4e5b4158", async() => {
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
            WriteLiteral("\r\n\r\n<h1>Private Chat</h1>\r\n<h3>");
#nullable restore
#line 6 "D:\PK\Evolve\UI .net\signalR_GPT\signalR_GPT\Views\Chat\Index.cshtml"
Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<div class=\"page-content page-container\" id=\"page-content\">\r\n    <div class=\"padding\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n");
#nullable restore
#line 12 "D:\PK\Evolve\UI .net\signalR_GPT\signalR_GPT\Views\Chat\Index.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""list list-row block"">
                        <div class=""list-item"" data-id=""19"">
                            <div><a href=""#"" data-abc=""true""><span class=""w-48 avatar gd-warning"">S</span></a></div>
                            <div class=""flex"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 667, "\"", 731, 1);
#nullable restore
#line 18 "D:\PK\Evolve\UI .net\signalR_GPT\signalR_GPT\Views\Chat\Index.cshtml"
WriteAttributeValue("", 674, Url.Action("Conversation", new { receiverId = user.Id }), 674, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"item-author text-color\" data-abc=\"true\">");
#nullable restore
#line 18 "D:\PK\Evolve\UI .net\signalR_GPT\signalR_GPT\Views\Chat\Index.cshtml"
                                                                                                                                              Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <div class=\"item-except text-muted text-sm h-1x\">");
#nullable restore
#line 19 "D:\PK\Evolve\UI .net\signalR_GPT\signalR_GPT\Views\Chat\Index.cshtml"
                                                                            Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""no-wrap"">
                                <div class=""item-date text-muted text-sm d-none d-md-block"">13/12 18</div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 26 "D:\PK\Evolve\UI .net\signalR_GPT\signalR_GPT\Views\Chat\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n    \r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305396ae4d40d81be7c66e84646b94c18f6c4e5b8195", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();

            connection.start().then(function () {
                console.log(""SignalR connected."");
            }).catch(function (err) {
                return console.error(err.toString());
            });

            $(""form"").on(""submit"", function (event) {
                event.preventDefault();
                var receiverId = $(""#receiverId"").val();
                var content = $(""#messageInput"").val();
                connection.invoke(""SendMessage"", receiverId, content).catch(function (err) {
                    return console.error(err.toString());
                });
                $(""#messageInput"").val("""");
            });

            connection.on(""ReceiveMessage"", function (senderName, content, isSender) {
                var messageClass = isSender ? ""text-right"" : ""text-left"";
                var messageContent = ""<p ");
                WriteLiteral("class=\'\" + messageClass + \"\'>\" + senderName + \": \" + content + \"</p>\";\r\n                $(\"#messageContainer\").append(messageContent);\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
