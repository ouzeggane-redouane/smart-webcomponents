#pragma checksum "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc19cebd029cd66ed50ae5a4ac1fee65218d345a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<style>\r\n    smart-scheduler {\r\n        width: 80%; \r\n        height:30%; \r\n        margin-bottom: 50px;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "Example");
            __builder.AddAttribute(2, "Name", "Scheduler");
            __builder.OpenComponent<MudBlazor.MudTabs>(3);
            __builder.AddAttribute(4, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
                            2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Rounded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ApplyEffectsToContainer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "PanelClass", "pa-6");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(9);
                __builder2.AddAttribute(10, "Text", "Tab One");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Smart.Blazor.Scheduler>(12);
                    __builder3.AddAttribute(13, "DateCurrent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
                                 dateCurrent

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "TimelineDayScale", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Smart.Blazor.SchedulerTimelineDayScale>(
#nullable restore
#line 18 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
                                      SchedulerTimelineDayScale.HalfHour

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Views", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Smart.Blazor.SchedulerViewType>>(
#nullable restore
#line 19 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
                            views

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "View", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Smart.Blazor.SchedulerViewType>(
#nullable restore
#line 19 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
                                         SchedulerViewType.Week

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Smart.Blazor.ISchedulerDataSource>>(
#nullable restore
#line 20 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
                                dataRecords

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(19);
                __builder2.AddAttribute(20, "Text", "Tab Two");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(22);
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(24, "Content of second tab");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(26);
                __builder2.AddAttribute(27, "Text", "Tab Three");
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(29);
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, "Content Three");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(33);
                __builder2.AddAttribute(34, "Text", "Tab Disabled");
                __builder2.AddAttribute(35, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\macair1\Desktop\smart-tests\latestBlazor\Pages\SchedulerWithMudBlazor.razor"
                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(37);
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(39, "Content Disabled");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
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
