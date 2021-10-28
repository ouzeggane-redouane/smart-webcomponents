// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace latestBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using latestBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using latestBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using Smart.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
using Smart.Blazor.Demos.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/scheduler-with-mudblazor")]
    public partial class SchedulerWithMudBlazor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
       
    private List<SchedulerDataSource> dataRecords = new List<SchedulerDataSource>();
    private DateTime dateCurrent = new DateTime(2021, 1, 25);
    private IEnumerable<SchedulerViewType> views = new List<SchedulerViewType>()
    {
        SchedulerViewType.Day,
        SchedulerViewType.Week,
        SchedulerViewType.Month
    };
    protected override void OnInitialized()
    {
        base.OnInitialized();

        dataService.GenerateSchedulerData().ForEach((SchedulerDataRecord record) =>
        {
            SchedulerDataSource schedulerDataItem = new SchedulerDataSource()
            {
                Label = record.Label,
                DateStart = record.DateStart,
                DateEnd = record.DateEnd,
                BackgroundColor = record.BackgroundColor,
                AllDay = record.AllDay
            };
            dataRecords.Add(schedulerDataItem);
        });
    }
  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RandomDataService dataService { get; set; }
    }
}
#pragma warning restore 1591
