#pragma checksum "C:\Users\Luqueta\Documents\Projeto WEB FTEC\Ftec.ProjetoWeb.GitHub\ProjectFacul\ProjectFacul\Views\Login\password.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bff5c5b8373ae08fdb5855a823cecaa2015095c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_password), @"mvc.1.0.view", @"/Views/Login/password.cshtml")]
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
#line 1 "C:\Users\Luqueta\Documents\Projeto WEB FTEC\Ftec.ProjetoWeb.GitHub\ProjectFacul\ProjectFacul\Views\_ViewImports.cshtml"
using ProjectFacul.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luqueta\Documents\Projeto WEB FTEC\Ftec.ProjetoWeb.GitHub\ProjectFacul\ProjectFacul\Views\_ViewImports.cshtml"
using ProjectFacul;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bff5c5b8373ae08fdb5855a823cecaa2015095c", @"/Views/Login/password.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e519e95b8ea9720d97ed33f6003a2380263e684", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_password : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bff5c5b8373ae08fdb5855a823cecaa2015095c4019", async() => {
                WriteLiteral("\n        <meta charset=\"utf-8\" />\n        <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n        <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 270, "\"", 280, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n        <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 312, "\"", 322, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n        <title>Password Reset - SB Admin</title>\n        <link href=\"css/styles.css\" rel=\"stylesheet\" />\n        <script src=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js\" crossorigin=\"anonymous\"></script>\n    ");
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
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bff5c5b8373ae08fdb5855a823cecaa2015095c5826", async() => {
                WriteLiteral(@"
        <div id=""layoutAuthentication"">
            <div id=""layoutAuthentication_content"">
                <main>
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-5"">
                                <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                                    <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Password Recovery</h3></div>
                                    <div class=""card-body"">
                                        <div class=""small mb-3 text-muted"">Enter your email address and we will send you a link to reset your password.</div>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bff5c5b8373ae08fdb5855a823cecaa2015095c6858", async() => {
                    WriteLiteral(@"
                                            <div class=""form-floating mb-3"">
                                                <input class=""form-control"" id=""inputEmail"" type=""email"" placeholder=""name@example.com"" />
                                                <label for=""inputEmail"">Email address</label>
                                            </div>
                                            <div class=""d-flex align-items-center justify-content-between mt-4 mb-0"">
                                                <a ");
                    WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\Luqueta\Documents\Projeto WEB FTEC\Ftec.ProjetoWeb.GitHub\ProjectFacul\ProjectFacul\Views\Login\password.cshtml"
                                                                Write(Html.ActionLink("Voltar pro Login", "Home", "Home"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\n                                                <a ");
                    WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\Luqueta\Documents\Projeto WEB FTEC\Ftec.ProjetoWeb.GitHub\ProjectFacul\ProjectFacul\Views\Login\password.cshtml"
                                                                          Write(Html.ActionLink("Resetar senha", "Home", "Home"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\n                                            </div>\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    </div>\n                                    <div class=\"card-footer text-center py-3\">\n                                        <div class=\"small\">\n                                            <a ");
#nullable restore
#line 37 "C:\Users\Luqueta\Documents\Projeto WEB FTEC\Ftec.ProjetoWeb.GitHub\ProjectFacul\ProjectFacul\Views\Login\password.cshtml"
                                          Write(Html.ActionLink("Precisa de uma conta?", "Cadastro", "Cadastro"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
            <div id=""layoutAuthentication_footer"">
                <footer class=""py-4 bg-light mt-auto"">
                    <div class=""container-fluid px-4"">
                        <div class=""d-flex align-items-center justify-content-between small"">
                            <div class=""text-muted"">Copyright &copy; Your Website 2021</div>
                            <div>
                                <a href=""#"">Privacy Policy</a>
                                &middot;
                                <a href=""#"">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
        <script src=""https://cdn.jsdelivr.ne");
                WriteLiteral("t/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js\" crossorigin=\"anonymous\"></script>\n        <script src=\"js/scripts.js\"></script>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
