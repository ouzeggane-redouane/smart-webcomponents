// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace johnNewReleaseTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 3 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\FetchData.razor"
using Smart.Blazor.Demos.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/f")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\macair1\Desktop\smart-tests\johnNewReleaseTest\Pages\FetchData.razor"
       

    bool CIE94 = true;

    bool CIED2000 = false;

    bool CIELab = false;

    bool CIELuv = false;

    bool CMC = false;

    bool DIN99 = false;

    bool FMC1 = false;

    bool FMC2 = false;

    bool HunterLab = false;

    string cdfInput = "10 10 10 | 20 20 20";

    string colourTemplate = "#colourTemplate";

    string cdf_Colour1 = "#FFBB44";

    string cdf_Colour2 = "#3399EE";

    private void cdf_OnRowClick(object eventObj)
    {

        //Never gets this far

        Console.WriteLine("hello from cdf_OnRowClick");

    }

  string templateID = "#quantityTemplate";
    GridSorting sorting = new GridSorting() { Enabled = true };
    GridAppearance appearance = new GridAppearance() { AlternationCount = 2 };
    GridSelection selection = new GridSelection()
    {
        Enabled = true,
        Mode = GridSelectionMode.Extended,
        CheckBoxes = new GridSelectionCheckBoxes()
        {
            Enabled = true
        }
    };
    private List<DataRecord> dataRecords;
    protected override void OnInitialized()
    {
        base.OnInitialized();
        dataRecords = dataService.GenerateData(1000);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RandomDataService dataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
