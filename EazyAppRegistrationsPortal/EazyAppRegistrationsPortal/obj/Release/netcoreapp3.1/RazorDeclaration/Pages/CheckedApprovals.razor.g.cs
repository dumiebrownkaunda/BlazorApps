#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\CheckedApprovals.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b258286111d8f6c1b3bdba5b29502e51dbafa97"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EazyAppRegistrationsPortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\CheckedApprovals.razor"
using EazyAppRegistrationsPortal.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkedapprovals/{Id}")]
    public partial class CheckedApprovals : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\CheckedApprovals.razor"
       

    [Parameter]
    public string Id { get; set; }

    int delayMillSec;
    bool refreshOnAdd;
    List<CustomerVm> customers;

    protected override async Task OnInitializedAsync()
    {
        SessionBridgeVm sessionBridge = SessionBridgeVmManager.GetFromBasket(Id);
        if (sessionBridge == null)
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        if (sessionBridge.RoleId != 1)
        {
            NavigationManager.NavigateTo($"access_denied/{Id}");
            return;
        }

        delayMillSec = Convert.ToInt32(ConfigReader.Read("DelayMs"));
        refreshOnAdd = Convert.ToBoolean(ConfigReader.Read("RefreshOnAdd"));
        customers = await CustomerService.GetCheckedCustomers();
    }

    protected override void OnAfterRender(bool firstRender)
    {

        CallAddTable();

    }

    protected void CallAddTable()
    {
        JSRuntime.InvokeAsync<bool>("TestDataTablesAdd", "#example");
    }

    protected async Task ApproveCustomer(string customerNumber)
    {
        await CustomerService.ApproveCustomer(Id, customerNumber);

        if (refreshOnAdd)
        {
            NavigationManager.NavigateTo($"operation_successful/4/{Id}");
        }
        else
        {
            var customer = customers.FirstOrDefault(c => c.CustomerNumber == customerNumber);

            if (customer != null)
            {
                customers.Remove(customer);
                await Task.Delay(delayMillSec);
            }
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfigReader ConfigReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBridgeVmManager SessionBridgeVmManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomerService CustomerService { get; set; }
    }
}
#pragma warning restore 1591
