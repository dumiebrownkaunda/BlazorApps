#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142d262d7c199951e0908f4df5be5949980fb490"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkedapprovals/{Key}")]
    public partial class CheckedApprovals : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "\r\n");
#nullable restore
#line 10 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
         if (customers == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "            ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "            ");
            __builder.AddMarkupContent(5, "<h3>Unapproved Customers</h3>\r\n");
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "id", "uncheckedCustomersTable");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddAttribute(10, "style", "width: 100%");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, @"<thead>
                    <tr>
                        <th>Account Number</th>
                        <th>Account Name</th>
                        <th>Phone Number</th>
                        <th>Reg Date</th>
                        <th>Status</th>
                        <th></th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 30 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
                     foreach (var customer in customers)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                    ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 33 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
                             customer.AcAccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 34 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
                             customer.AcAccountName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 35 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
                             customer.AcPhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 36 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
                             customer.AcRegistrationDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 37 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
                             customer.AcStatus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-outline-info");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
                                                                           () => ApproveAsync(customer.AcCustomerNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Approve");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn btn-outline-info");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
                                                                           () => DenyAsync(customer.AcCustomerNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Deny");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 43 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 46 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyMobileRegistrationPortal\EazyMobileRegPortal\EazyMobileRegPortal\Pages\CheckedApprovals.razor"
       

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

        if (sessionBridge.RoleId != 1)
        {
            NavigationManager.NavigateTo($"access_denied/{Key}");
            return;
        }

        customers = await CustomerService.GetCheckedCustomers();
    }

    protected async Task ApproveAsync(string customerNumber)
    {
        await CustomerService.ApproveCustomerAsync(Key, customerNumber);

        NavigationManager.NavigateTo($"operation_successful/4/{Key}");
    }

    protected async Task DenyAsync(string customerNumber)
    {
        await CustomerService.DenyCustomerAsync(Key, customerNumber);

        NavigationManager.NavigateTo($"operation_successful/4/{Key}");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        CallAddTable();
    }

    protected void CallAddTable()
    {
        JSRuntime.InvokeAsync<bool>("ActivateDataTable", "#uncheckedCustomersTable");
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
