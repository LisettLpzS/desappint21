#pragma checksum "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81873d6262e440443465646ebb50c59443bd0cb7"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.Departamento
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\desappint21\p25-universidadv5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\desappint21\p25-universidadv5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\desappint21\p25-universidadv5\_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\desappint21\p25-universidadv5\_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Departamentos")]
    public partial class Departamentos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Informacion de Departamentos</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AgregarDepartamentos");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\">Agregar Nuevo</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.AddMarkupContent(7, "<label>Buscar por nombre:</label>\n");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
                                (e) => Filtro(e) 

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 16 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
 if(obj is null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<p>Cargando ...</p>");
#nullable restore
#line 18 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "<thead><th>Depatamento Id</th>\n            <th>Nombre</th>\n            <th>Presupuesto</th>\n            <th>Fecha de Inicio</th>\n            <th>Instructor</th></thead>\n    \n    ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 29 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
         foreach (var i in obj)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 32 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
                     i.DepartamentoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 33 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
                     i.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 34 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
                     i.Presupuesto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 35 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
                     i.FechaDeInicio.ToString("yyy-MMM-dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 36 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
                     i.Instructor.NombreCompleto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "class", "nav-link");
            __builder.AddAttribute(35, "href", "EditarDepartamentos/" + (
#nullable restore
#line 38 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
                                                                   i.DepartamentoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "<span class=\"oi oi-pencil\">Editar</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                     ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", "EliminarDepartamentos/" + (
#nullable restore
#line 41 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
                                                                      i.DepartamentoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "<span class=\"oi oi-pencil\">Eliminar</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
        } 

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\desappint21\p25-universidadv5\Pages\Departamento\Departamentos.razor"
       
    List<Departamento> obj;
 
    protected override void OnInitialized() {
        obj = serv.ObtenerTodo("");

    }

    protected void Filtro(ChangeEventArgs e) {
        string cadenabuscar = e.Value.ToString();
        obj = serv.ObtenerTodo(cadenabuscar);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioDepartamentos serv { get; set; }
    }
}
#pragma warning restore 1591