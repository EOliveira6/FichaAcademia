#pragma checksum "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3649647644836602e174089f9d77e24fc7654fcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DadosAluno_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DadosAluno/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/DadosAluno/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_DadosAluno_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3649647644836602e174089f9d77e24fc7654fcd", @"/Views/Shared/Components/DadosAluno/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13081fbd4135203d621391681268fce7feedca99", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DadosAluno_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FichaAcademia.Dominio.Models.Aluno>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 137, true);
            WriteLiteral("\n<div>\n    <h5>Dados do Aluno</h5>\n    <hr />\n\n    <div class=\"row\">\n        <div class=\"col s4\">\n            <p><strong>Nome : </strong>");
            EndContext();
            BeginContext(180, 18, false);
#line 9 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                  Write(Model.NomeCompleto);

#line default
#line hidden
            EndContext();
            BeginContext(198, 90, true);
            WriteLiteral("</p>\n        </div>\n\n        <div class=\"col s4\">\n            <p><strong>Idade : </strong>");
            EndContext();
            BeginContext(289, 11, false);
#line 13 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                   Write(Model.Idade);

#line default
#line hidden
            EndContext();
            BeginContext(300, 89, true);
            WriteLiteral("</p>\n        </div>\n\n        <div class=\"col s4\">\n            <p><strong>Peso : </strong>");
            EndContext();
            BeginContext(390, 10, false);
#line 17 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                  Write(Model.Peso);

#line default
#line hidden
            EndContext();
            BeginContext(400, 126, true);
            WriteLiteral("</p>\n        </div>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col s4\">\n            <p><strong>Objetivo : </strong>");
            EndContext();
            BeginContext(527, 19, false);
#line 23 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                      Write(Model.Objetivo.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(546, 94, true);
            WriteLiteral("</p>\n        </div>\n\n        <div class=\"col s4\">\n            <p><strong>Descrição : </strong>");
            EndContext();
            BeginContext(641, 24, false);
#line 27 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                       Write(Model.Objetivo.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(665, 94, true);
            WriteLiteral("</p>\n        </div>\n\n        <div class=\"col s4\">\n            <p><strong>Professor : </strong>");
            EndContext();
            BeginContext(760, 20, false);
#line 31 "C:\Users\Pri\source\repos\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                       Write(Model.Professor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(780, 38, true);
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FichaAcademia.Dominio.Models.Aluno> Html { get; private set; }
    }
}
#pragma warning restore 1591