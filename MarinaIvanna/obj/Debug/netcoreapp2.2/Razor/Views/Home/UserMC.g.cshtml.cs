#pragma checksum "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d851da1dbd95ed4fb4791a8abbfadec3393f82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserMC), @"mvc.1.0.view", @"/Views/Home/UserMC.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserMC.cshtml", typeof(AspNetCore.Views_Home_UserMC))]
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
#line 1 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\_ViewImports.cshtml"
using MarinaIvanna;

#line default
#line hidden
#line 2 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\_ViewImports.cshtml"
using MarinaIvanna.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d851da1dbd95ed4fb4791a8abbfadec3393f82", @"/Views/Home/UserMC.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231cba1d2428d0fd11af927c094ed2eec31abcd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserMC : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MarinaIvanna.Models.UserRequest>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/mc.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/AuthorizationUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("texit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = null;

#line default
#line hidden
            BeginContext(118, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(143, 251, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d851da1dbd95ed4fb4791a8abbfadec3393f825476", async() => {
                BeginContext(149, 114, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                EndContext();
                BeginContext(263, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49d851da1dbd95ed4fb4791a8abbfadec3393f825981", async() => {
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
                EndContext();
                BeginContext(308, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(314, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49d851da1dbd95ed4fb4791a8abbfadec3393f827313", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(385, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(394, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(396, 2536, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d851da1dbd95ed4fb4791a8abbfadec3393f829442", async() => {
                BeginContext(402, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(408, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d851da1dbd95ed4fb4791a8abbfadec3393f829827", async() => {
                    BeginContext(457, 5, true);
                    WriteLiteral("Выход");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(466, 209, true);
                WriteLiteral("\r\n    <div class=\"container main\">\r\n        <div class=\"row\">\r\n            <div class=\"col-8\">\r\n                <div class=\"mz\">Мои Заявки</div>\r\n                <div class=\"accordion\" id=\"accordionExample\">\r\n");
                EndContext();
#line 21 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                     foreach (var v in Model)
                    {

#line default
#line hidden
                BeginContext(745, 99, true);
                WriteLiteral("                        <div class=\"card za\">\r\n                            <div class=\"card-header\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 844, "\"", 855, 2);
                WriteAttributeValue("", 849, "!", 849, 1, true);
#line 24 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
WriteAttributeValue("", 850, v.Id, 850, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(856, 156, true);
                WriteLiteral(">\r\n                                <h5 class=\"mb-0\">\r\n                                    <button class=\"btn btn-link\" data-toggle=\"collapse\" data-target=\"#");
                EndContext();
                BeginContext(1013, 4, false);
#line 26 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                                                                                                 Write(v.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1017, 23, true);
                WriteLiteral("\" aria-expanded=\"false\"");
                EndContext();
                BeginWriteAttribute("aria-controls", " aria-controls=\"", 1040, "\"", 1061, 1);
#line 26 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
WriteAttributeValue("", 1056, v.Id, 1056, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1062, 69, true);
                WriteLiteral(">\r\n                                        <div class=\"acch\">Заявка №");
                EndContext();
                BeginContext(1132, 4, false);
#line 27 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                                                             Write(v.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1136, 81, true);
                WriteLiteral("</div>\r\n                                        <div class=\"acch\">Статус заявки: ");
                EndContext();
                BeginContext(1218, 8, false);
#line 28 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                                                                    Write(v.Status);

#line default
#line hidden
                EndContext();
                BeginContext(1226, 164, true);
                WriteLiteral("</div>\r\n                                    </button>\r\n                                </h5>\r\n                            </div>\r\n\r\n                            <div");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1390, "\"", 1400, 1);
#line 33 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
WriteAttributeValue("", 1395, v.Id, 1395, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1401, 22, true);
                WriteLiteral(" class=\"collapse hide\"");
                EndContext();
                BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1423, "\"", 1447, 2);
                WriteAttributeValue("", 1441, "!", 1441, 1, true);
#line 33 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
WriteAttributeValue("", 1442, v.Id, 1442, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1448, 230, true);
                WriteLiteral(" data-parent=\"#accordionExample\">\r\n                                <div class=\"card-body\">\r\n                                    <div class=\"binz\">Заявитель</div>\r\n                                    <div class=\"linz\">Направление: ");
                EndContext();
                BeginContext(1679, 6, false);
#line 36 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                                                              Write(v.Type);

#line default
#line hidden
                EndContext();
                BeginContext(1685, 70, true);
                WriteLiteral("</div>\r\n                                    <div class=\"linz\">E-mail: ");
                EndContext();
                BeginContext(1756, 7, false);
#line 37 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                                                         Write(v.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1763, 69, true);
                WriteLiteral("</div>\r\n                                    <div class=\"linz\">Адрес: ");
                EndContext();
                BeginContext(1833, 9, false);
#line 38 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                                                        Write(v.Address);

#line default
#line hidden
                EndContext();
                BeginContext(1842, 132, true);
                WriteLiteral("</div>\r\n                                    <div class=\"binz\">Проблема</div>\r\n                                    <div class=\"mess\">");
                EndContext();
                BeginContext(1975, 9, false);
#line 40 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                                                 Write(v.Message);

#line default
#line hidden
                EndContext();
                BeginContext(1984, 144, true);
                WriteLiteral("</div>\r\n                                    <div class=\"binz\">Управляющая компания</div>\r\n                                    <div class=\"linz\">");
                EndContext();
                BeginContext(2129, 9, false);
#line 42 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                                                 Write(v.Company);

#line default
#line hidden
                EndContext();
                BeginContext(2138, 77, true);
                WriteLiteral("</div>\r\n                                    <div class=\"linz\">Ответственный: ");
                EndContext();
                BeginContext(2216, 14, false);
#line 43 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                                                                Write(ViewBag.M_name);

#line default
#line hidden
                EndContext();
                BeginContext(2230, 317, true);
                WriteLiteral(@"</div>
                                    <div><button class=""b_success"">Принят в работу</button></div>
                                    <div><button class=""b_error"">Ошибка маршрутизации</button></div>
                                </div>
                            </div>
                        </div>
");
                EndContext();
#line 49 "C:\Users\nobyA\trpr\Traktorina\MarinaIvanna\Views\Home\UserMC.cshtml"
                    }

#line default
#line hidden
                BeginContext(2570, 355, true);
                WriteLiteral(@"                </div>
            </div>
        </div>
    </div>

    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
");
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
            BeginContext(2932, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MarinaIvanna.Models.UserRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591
