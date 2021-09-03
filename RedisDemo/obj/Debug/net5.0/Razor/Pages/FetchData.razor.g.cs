#pragma checksum "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c816913785ca485355a67c844dff5a2924b3977e"
// <auto-generated/>
#pragma warning disable 1591
namespace RedisDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using RedisDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using RedisDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\_Imports.razor"
using Microsoft.Extensions.Caching.Distributed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
using RedisDemo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
using RedisDemo.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
                                          LoadForeCast

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Load Forecast");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
 if (forecasts is null && loadLocation == "")
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Click the button to load the forecast...</em></p>");
#nullable restore
#line 18 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
}
else if (forecasts is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 22 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "h3" + " " + (
#nullable restore
#line 26 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
                    isCachedData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, 
#nullable restore
#line 27 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
         loadLocation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table");
            __builder.AddMarkupContent(13, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 40 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 43 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 44 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 45 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 46 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Daniel\source\repos\RedisDemo\RedisDemo\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;
    private string loadLocation = "";
    private string isCachedData = "";

    //protected override async Task OnInitializedAsync()
    //{
    //    forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    //}

    private async Task LoadForeCast()
    {
        forecasts = null;
        loadLocation = null;
        string recordKey = "WeatherForecast_" + DateTime.Now.ToString("yyyyMMdd_hhmm");

        forecasts = await cache.GetRecordAsync<WeatherForecast[]>(recordKey);

        if (forecasts is null)
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);

            loadLocation = $"Loaded from API at {DateTime.Now}";

            isCachedData = "";

            await cache.SetRecordAsync(recordKey, forecasts);
        }
        else
        {
            loadLocation = $"Loaded from the cache at {DateTime.Now}";
            isCachedData = "text-danger";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDistributedCache cache { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
