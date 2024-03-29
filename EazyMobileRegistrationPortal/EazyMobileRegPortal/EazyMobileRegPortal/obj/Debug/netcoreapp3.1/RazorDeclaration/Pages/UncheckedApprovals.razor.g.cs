#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\UncheckedApprovals.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7af27981bfc2b3be602475ae3a370aa94e2d3a7c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EazyMobileRegPortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\_Imports.razor"
using EazyMobileRegPortal.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/uncheckedapprovals/{Key}")]
    public partial class UncheckedApprovals : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\UncheckedApprovals.razor"
       

    [Parameter]
    public string Key { get; set; }

    List<TbSelfRegistrationVm> customers;

    protected override async Task OnInitializedAsync()
    {
        SessionBridgeVm sessionBridge = SessionBridgeVmManager.GetFromBasket(Key);
        if (sessionBridge == null)
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        if (sessionBridge.RoleId != 2)
        {
            NavigationManager.NavigateTo($"access_denied/{Key}");
            return;
        }

        customers = await CustomerService.GetUncheckedCustomers();
    }

    protected async Task InitiateApproveAsync(string customerNumber)
    {
        await CustomerService.CheckCustomerAsync(Key, customerNumber);

        NavigationManager.NavigateTo($"operation_successful/2/{Key}");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        CallAddTable();
    }

    protected void CallAddTable()
    {
        JSRuntime.InvokeAsync<object>("ActivateDataTable", "#uncheckedTable");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfigReader ConfigReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBridgeVmManager SessionBridgeVmManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomerService CustomerService { get; set; }
    }
}
#pragma warning restore 1591
