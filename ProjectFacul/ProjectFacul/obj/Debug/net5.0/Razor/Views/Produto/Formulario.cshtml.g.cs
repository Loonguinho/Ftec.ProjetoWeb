#pragma checksum "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75231d2ad48e5af8196db3b60451647536f6c633"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Formulario), @"mvc.1.0.view", @"/Views/Produto/Formulario.cshtml")]
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
#line 1 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\_ViewImports.cshtml"
using ProjectFacul.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\_ViewImports.cshtml"
using ProjectFacul;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75231d2ad48e5af8196db3b60451647536f6c633", @"/Views/Produto/Formulario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e519e95b8ea9720d97ed33f6003a2380263e684", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Formulario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/produto/cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
  
    ViewData["Title"] = "Formulario";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Formulario</h1>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75231d2ad48e5af8196db3b60451647536f6c6334498", async() => {
                WriteLiteral("\n        Conteudo da Sessao:  ");
#nullable restore
#line 12 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
                        Write(HttpContextAccessor.HttpContext.Session.GetString("CodigoProduto"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br />\n        <label for=\"nome\">Nome</label>\n        <input type=\"text\" id=\"nome\"");
                BeginWriteAttribute("value", " value=\"", 422, "\"", 451, 1);
#nullable restore
#line 15 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
WriteAttributeValue("", 430, ViewBag.Produto.Nome, 430, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"produto.Nome\" />\n        ");
#nullable restore
#line 16 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
   Write(Html.ValidationMessage("produto.Nome"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br />\n        <label for=\"unidade\">Unidade</label>\n        <input type=\"text\" id=\"unidade\"");
                BeginWriteAttribute("value", " value=\"", 623, "\"", 661, 1);
#nullable restore
#line 19 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
WriteAttributeValue("", 631, ViewBag.Produto.UnidadeMedida, 631, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"produto.UnidadeMedida\" />\n        <br />\n        <label for=\"quantidade\">Quantidade</label>\n        <input type=\"text\" id=\"quantidade\"");
                BeginWriteAttribute("value", " value=\"", 803, "\"", 838, 1);
#nullable restore
#line 22 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
WriteAttributeValue("", 811, ViewBag.Produto.Quantidade, 811, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"produto.Quantidade\" />\n        ");
#nullable restore
#line 23 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
   Write(Html.ValidationMessage("produto.quantidadeincorreta"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br />\n        <label for=\"categoria\">Categoria</label>\n        <select id=\"categoria\" name=\"produto.CategoriaId\">\n");
#nullable restore
#line 27 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
             foreach (var item in ViewBag.ListaCategorias)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75231d2ad48e5af8196db3b60451647536f6c6337626", async() => {
#nullable restore
#line 29 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
                                    Write(item.Descricao);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
                   WriteLiteral(item.Id);

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
                WriteLiteral("\n");
#nullable restore
#line 30 "C:\Users\Luqueta\Desktop\ProjectFacul\ProjectFacul\Views\Produto\Formulario.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\n        <br />\n\n        <input type=\"submit\" value=\"Cadastrar\" />\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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
