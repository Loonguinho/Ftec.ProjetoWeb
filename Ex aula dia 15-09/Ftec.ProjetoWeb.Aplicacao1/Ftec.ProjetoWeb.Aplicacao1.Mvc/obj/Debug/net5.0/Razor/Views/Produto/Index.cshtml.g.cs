#pragma checksum "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9b39d095afaf50e7a337dc796110e9bd2967c67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
#line 1 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\_ViewImports.cshtml"
using Ftec.ProjetoWeb.Aplicacao1.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\_ViewImports.cshtml"
using Ftec.ProjetoWeb.Aplicacao1.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b39d095afaf50e7a337dc796110e9bd2967c67", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba361d36140234f7bbbe7f70790d51b32a24fa00", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProdutoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Index</h1>\r\n");
#nullable restore
#line 11 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\Produto\Index.cshtml"
Write(Html.ActionLink("Adicionar Novo Produto","formulario","produto"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div>
    <table>
        <thead>
            <tr>
                <th>Nome</th>
                <th>Unidade</th>
                <th>Quantidade</th>
                <th>Ação</th>
            </tr>
        </thead>
        <tbody id=""corpo"">
            <br />
");
#nullable restore
#line 26 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\Produto\Index.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\Produto\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\Produto\Index.cshtml"
                   Write(item.UnidadeMedida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 630, "\"", 655, 2);
            WriteAttributeValue("", 635, "quantidade", 635, 10, true);
#nullable restore
#line 31 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\Produto\Index.cshtml"
WriteAttributeValue("", 645, item.Id, 645, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\Produto\Index.cshtml"
                                             Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 732, "\"", 761, 3);
            WriteAttributeValue("", 742, "Excluir(\'", 742, 9, true);
#nullable restore
#line 33 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\Produto\Index.cshtml"
WriteAttributeValue("", 751, item.Id, 751, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 759, "\')", 759, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">Excluir</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Luqueta\Desktop\Ftec.ProjetoWeb.Aplicacao1\Ftec.ProjetoWeb.Aplicacao1.Mvc\Views\Produto\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input id=\"pesquisar\" type=\"text\" onkeyup=\"FiltrarProduto()\"/>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b39d095afaf50e7a337dc796110e9bd2967c677213", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    function Excluir(id) {
        var url = ""/Produto/Excluir"";
        var parametro = { idProduto: id };
        parametro.remove();
        $.post(url, parametro, RetornaProcessamento);
    }

    function RetornaProcessamento(retorno) {
        var celula = $(""#quantidade"" + retorno.id);
        celula.html(retorno.quantidade);
    }

    function FiltrarProduto() {
        var conteudo = $(""#pesquisar"").val();
        var url = ""/Produto/Filtrar"";
        var parametro = { termo: conteudo };
        $.post(url, parametro, RetornaFiltragem);
        
    }

    function RetornaFiltragem(retorno) {
        
        var corpoTabela = $(""#corpo"");
        var strTabela = """";

        for (var i = 0; i < retorno.lenght; i++) {
            strTabela = strTabela + ""<tr>"";
            strTabela = strTabela + ""<td>"" + retorno[i].Nome + ""</td>"";
            strTabela = strTabela + ""</tr>"";
        }
        corpoTabela.html(strTabela);
        
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProdutoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591