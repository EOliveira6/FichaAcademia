#pragma checksum "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8703afd613a72db426d42f82548af0b4727579eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ListagemExercicioFicha_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ListagemExercicioFicha/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ListagemExercicioFicha/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ListagemExercicioFicha_Default))]
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
#line 1 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\_ViewImports.cshtml"
using FichaAcademia;

#line default
#line hidden
#line 2 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\_ViewImports.cshtml"
using FichaAcademia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8703afd613a72db426d42f82548af0b4727579eb", @"/Views/Shared/Components/ListagemExercicioFicha/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13081fbd4135203d621391681268fce7feedca99", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ListagemExercicioFicha_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FichaAcademia.Dominio.Models.ListaExercicio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 212, true);
            WriteLiteral("<div>\r\n    <h5>Exercicios</h5>\r\n    <hr />\r\n    <div>\r\n        <table class=\"table hover striped highlight centered\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(278, 45, false);
#line 10 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml"
                   Write(Html.DisplayNameFor(model => model.Exercicio));

#line default
#line hidden
            EndContext();
            BeginContext(323, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(403, 46, false);
#line 13 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml"
                   Write(Html.DisplayNameFor(model => model.Frequencia));

#line default
#line hidden
            EndContext();
            BeginContext(449, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(529, 46, false);
#line 16 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml"
                   Write(Html.DisplayNameFor(model => model.Repeticoes));

#line default
#line hidden
            EndContext();
            BeginContext(575, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(655, 41, false);
#line 19 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml"
                   Write(Html.DisplayNameFor(model => model.Carga));

#line default
#line hidden
            EndContext();
            BeginContext(696, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(856, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(941, 49, false);
#line 28 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Exercicio.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(990, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1082, 45, false);
#line 31 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Frequencia));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1219, 45, false);
#line 34 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Repeticoes));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1356, 40, false);
#line 37 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Carga));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Eleni Oliveira\Desktop\ftt\5 semestre\Eleni-LIP-BDO\FichaAcademia (2)\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExercicioFicha\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1475, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FichaAcademia.Dominio.Models.ListaExercicio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
