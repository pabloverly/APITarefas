#pragma checksum "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/Tarefas/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c61ba3e6f30f95320244d4b7ea3a7747d5c24ce2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefas_Index), @"mvc.1.0.view", @"/Views/Tarefas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefas/Index.cshtml", typeof(AspNetCore.Views_Tarefas_Index))]
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
#line 1 "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/_ViewImports.cshtml"
using Tarefas;

#line default
#line hidden
#line 2 "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/_ViewImports.cshtml"
using Tarefas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c61ba3e6f30f95320244d4b7ea3a7747d5c24ce2", @"/Views/Tarefas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b1d4ceb903fd790b0685a9067e34add11b7dd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(5, 39, true);
            WriteLiteral("@model Tarefa.Models.TarefaViewModel;\n\n");
            EndContext();
#line 3 "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/Tarefas/Index.cshtml"
      
        ViewData["Title"] = "Gerenciar lista de tarefas";
    

#line default
#line hidden
            BeginContext(115, 82, true);
            WriteLiteral("    <div Class=\"panel panel-default tarefa-panel\">\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(198, 17, false);
#line 7 "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/Tarefas/Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(215, 243, true);
            WriteLiteral("</div>\n    <table class=\"table table-hover\">\n        <thead>\n            <tr>\n                <td>teste</td>\n                <td>teste</td>\n                <td> Tarefa </td>\n                <td>Previsao</td>\n            </tr>\n        </thead>\n");
            EndContext();
#line 17 "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/Tarefas/Index.cshtml"
         foreach(var item in Model.TarefaItens)
        {

#line default
#line hidden
            BeginContext(516, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(546, 7, false);
#line 20 "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/Tarefas/Index.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(553, 44, true);
            WriteLiteral("</td>\n            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 597, "\"", 612, 1);
#line 21 "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/Tarefas/Index.cshtml"
WriteAttributeValue("", 604, item.Id, 604, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(613, 37, true);
            WriteLiteral(" value=\"true\"> </td>\n            <td>");
            EndContext();
            BeginContext(651, 9, false);
#line 22 "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/Tarefas/Index.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(660, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(683, 18, false);
#line 23 "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/Tarefas/Index.cshtml"
           Write(item.DataConclusao);

#line default
#line hidden
            EndContext();
            BeginContext(701, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 25 "/run/media/pabloverly/58D843C2D8439CDE/14_LINUX/Dev/REACTJS/c#/aspnetcore2/Tarefas/Views/Tarefas/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(731, 24, true);
            WriteLiteral("    </table>\n\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
