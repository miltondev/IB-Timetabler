#pragma checksum "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "354db08feb1e329670de728c59b2876cbe2578cd"
// <auto-generated/>
#pragma warning disable 1591
namespace IB_Timetabler.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using IB_Timetabler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using IB_Timetabler.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using ElectronNET.API.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using ElectronNET.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using IB_Timetabler.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/_Imports.razor"
using IB_Timetabler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
using IB_Timetabler.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<IB_Timetabler.Controls.TitleComponent>(0);
            __builder.AddAttribute(1, "Page", "Weather Forecast");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n\n");
            __builder.AddMarkupContent(3, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 10 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
 if (forecasts == null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
}
else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "<thead><tr><th>Date</th>\n            <th>Temp. (C)</th>\n            <th>Temp. (F)</th>\n            <th>Summary</th></tr></thead>\n        ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 26 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
         foreach (var forecast in forecasts) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 28 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
                     forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
                     forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
                     forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
                     forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/home/noname/school/computerScience/IA/timetableCode/IB-Timetabler/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync() {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591