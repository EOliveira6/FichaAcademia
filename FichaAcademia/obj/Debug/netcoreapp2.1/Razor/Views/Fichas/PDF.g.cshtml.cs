#pragma checksum "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5daa0e57fc75dde54f6fbd23ea1a54e9e9fca33b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fichas_PDF), @"mvc.1.0.view", @"/Views/Fichas/PDF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fichas/PDF.cshtml", typeof(AspNetCore.Views_Fichas_PDF))]
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
#line 1 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\_ViewImports.cshtml"
using FichaAcademia;

#line default
#line hidden
#line 2 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\_ViewImports.cshtml"
using FichaAcademia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5daa0e57fc75dde54f6fbd23ea1a54e9e9fca33b", @"/Views/Fichas/PDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13081fbd4135203d621391681268fce7feedca99", @"/Views/_ViewImports.cshtml")]
    public class Views_Fichas_PDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FichaAcademia.Dominio.Models.Ficha>
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
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(67, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(92, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9573288d6cb849119b060fdd84b7ff7a", async() => {
                BeginContext(98, 198, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css\">\n    <title>PDF</title>\n");
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
            BeginContext(303, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(304, 650, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c179596f6454277a69877c286a4bd3f", async() => {
                BeginContext(310, 80, true);
                WriteLiteral("\n    <div class=\"collection\">\n        <div class=\"collection-item\">\n            ");
                EndContext();
                BeginContext(391, 56, false);
#line 18 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml"
       Write(await Component.InvokeAsync("DadosAluno", Model.AlunoId));

#line default
#line hidden
                EndContext();
                BeginContext(447, 139, true);
                WriteLiteral("\n        </div>\n\n        <div class=\"row collection-item\">\n            <div class=\"col s6\">\n                <p><strong>Cadastro : </strong>");
                EndContext();
                BeginContext(587, 14, false);
#line 23 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml"
                                          Write(Model.Cadastro);

#line default
#line hidden
                EndContext();
                BeginContext(601, 105, true);
                WriteLiteral("</p>\n            </div>\n\n            <div class=\"col s6\">\n                <p><strong>Validade : </strong>");
                EndContext();
                BeginContext(707, 14, false);
#line 27 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml"
                                          Write(Model.Validade);

#line default
#line hidden
                EndContext();
                BeginContext(721, 130, true);
                WriteLiteral("</p>\n            </div>\n        </div>\n    </div>\n\n    <div class=\"collection\">\n        <div class=\"collection-item\">\n            ");
                EndContext();
                BeginContext(852, 68, false);
#line 34 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml"
       Write(await Component.InvokeAsync("ListagemExercicioFicha", Model.FichaId));

#line default
#line hidden
                EndContext();
                BeginContext(920, 27, true);
                WriteLiteral("\n        </div>\n    </div>\n");
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
            BeginContext(954, 10, true);
            WriteLiteral("\n</html>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FichaAcademia.Dominio.Models.Ficha> Html { get; private set; }
    }
}
#pragma warning restore 1591