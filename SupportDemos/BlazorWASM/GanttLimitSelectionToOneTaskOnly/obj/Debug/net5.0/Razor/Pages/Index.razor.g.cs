#pragma checksum "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65a486b0bdec53a1ccb65c9819139ac76924682f"
// <auto-generated/>
#pragma warning disable 1591
namespace johnNewReleaseTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using johnNewReleaseTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using johnNewReleaseTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\_Imports.razor"
using Smart.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
using Smart.Blazor.Demos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n\t\t\t.smart-gantt-chart.disabled-selection .smart-table-select-row{\r\n\t\t\t\tpointer-events: none;\r\n\t\t\t}\r\n\r\n\t\t\t.smart-gantt-chart.disabled-selection .smart-table-select-row.selected {\r\n\t\t\t\tpointer-events: initial;\r\n\t\t\t}\r\n\t\t\t\r\n\t</style>\r\n\t");
            __builder.OpenComponent<Smart.Blazor.GanttChart>(1);
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 17 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
                        ganttSelectionClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Smart.Blazor.Event>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Smart.Blazor.Event>(this, 
#nullable restore
#line 17 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
                                                                           ChangedHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
                                                                                                       Data

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnProgressChangeEnd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Smart.Blazor.Event>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Smart.Blazor.Event>(this, 
#nullable restore
#line 17 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
                                                                                                                                    ProgressChangedHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "TaskColumns", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Smart.Blazor.IGanttChartTaskColumn>>(
#nullable restore
#line 17 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
                                                                                                                                                                          taskColumns

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "DurationUnit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Smart.Blazor.Duration>(
#nullable restore
#line 17 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
                                                                                                                                                                                                     Duration.Hour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(8, (__value) => {
#nullable restore
#line 17 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
                                                    ganttChart = (Smart.Blazor.GanttChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\Index.razor"
       
	GanttChart ganttChart;

 	string ganttSelectionClass= "";

	public async void ChangedHandler(Event args)
	{
		IEnumerable<object> SelectedTasks = await ganttChart.GetSelectedTasks();
		
		List<object> tasksList = SelectedTasks.ToList();
		
		int maxCount = 1;

		if (tasksList.Count() >= maxCount) 
		{
			ganttSelectionClass= "disabled-selection";
		}
		else 
		{
			ganttSelectionClass= "";
		}
	
	}

    public void ProgressChangedHandler (Event EventObj) 
    {
        var details = EventObj["detail"];

        Console.WriteLine(details);

    }
	List<GanttChartTaskColumn> taskColumns = new List<GanttChartTaskColumn>{
		new GanttChartTaskColumn() {
			Label = "Tasks",
			Value = "label",
			Size = "60%"
		},
		new GanttChartTaskColumn() {
			Label = "Duration (hours)",
			Value = "duration"
		}
	};
	public GanttDataRecord[] Data;
	protected override async Task OnInitializedAsync()
	{
		Data = await RandomDataService.GetGanttDataAsync();
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RandomDataService RandomDataService { get; set; }
    }
}
#pragma warning restore 1591
