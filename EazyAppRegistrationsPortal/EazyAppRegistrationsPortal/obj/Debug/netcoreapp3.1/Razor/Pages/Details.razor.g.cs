#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4cd2c304f38c57be2653fcaac8924d0f43e92a5"
// <auto-generated/>
#pragma warning disable 1591
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
#line 10 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.Data;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/customer_details/{Id:long}/{Key}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "\r\n\r\n");
#nullable restore
#line 11 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
     if (customer == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
            __builder.AddContent(4, "        ");
            __builder.AddMarkupContent(5, "<a href=\"home\">Home</a>\r\n");
#nullable restore
#line 16 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "h5");
            __builder.AddContent(8, 
#nullable restore
#line 19 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
             customer.CustomerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        <br>\r\n");
            __builder.AddContent(10, "        ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-borderless");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddMarkupContent(14, "<thead>\r\n                <tr>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.AddMarkupContent(19, "<td>FirstName</td>\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 32 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                         customer.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.AddMarkupContent(26, "<td>LastName</td>\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 36 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                         customer.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.AddMarkupContent(33, "<td>Phone Number</td>\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 40 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                         customer.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.AddMarkupContent(40, "<td>Checked</td>\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.AddContent(43, 
#nullable restore
#line 45 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                         customer.Checked

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "tr");
            __builder.AddMarkupContent(48, "\r\n                    <td></td>\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 51 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                         if (customer.Checked)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                            ");
            __builder.OpenElement(52, "label");
            __builder.AddMarkupContent(53, "\r\n                                Checked by ");
            __builder.OpenElement(54, "span");
            __builder.AddAttribute(55, "class", "text-dark");
            __builder.AddContent(56, 
#nullable restore
#line 54 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                                                                    customer.CheckedBy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                ");
            __builder.AddMarkupContent(58, "<span> on </span>\r\n                                ");
            __builder.OpenElement(59, "span");
            __builder.AddAttribute(60, "class", "text-dark");
            __builder.AddContent(61, 
#nullable restore
#line 56 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                                                         customer.DateChecked.GetValueOrDefault().ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 58 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "tr");
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.AddMarkupContent(69, "<td>Approved</td>\r\n                    ");
            __builder.OpenElement(70, "td");
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.AddContent(72, 
#nullable restore
#line 64 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                         customer.Approved

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "tr");
            __builder.AddMarkupContent(77, "\r\n                    <td></td>\r\n                    ");
            __builder.OpenElement(78, "td");
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 70 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                         if (customer.Approved)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                            ");
            __builder.OpenElement(81, "label");
            __builder.AddMarkupContent(82, "\r\n                                Approved by ");
            __builder.OpenElement(83, "span");
            __builder.AddAttribute(84, "class", "text-dark");
            __builder.AddContent(85, 
#nullable restore
#line 73 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                                                                     customer.ApprovedBy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                ");
            __builder.AddMarkupContent(87, "<span> on </span>\r\n                                ");
            __builder.OpenElement(88, "span");
            __builder.AddAttribute(89, "class", "text-dark");
            __builder.AddContent(90, 
#nullable restore
#line 75 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                                                         customer.DateApproved.GetValueOrDefault().ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 77 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 101 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(98, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Details.razor"
       

    [Parameter]
    public long Id { get; set; }

    [Parameter]
    public string Key { get; set; }

    CustomerVm customer;

    protected override async Task OnInitializedAsync()
    {

        SessionBridgeVm sessionBridge = SessionBridgeVmManager.GetFromBasket(Key);
        if (sessionBridge == null)
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        if (sessionBridge.RoleId != 1 && sessionBridge.RoleId != 2)
        {
            NavigationManager.NavigateTo("access_denied");
            return;
        }

        customer = await CustomerService.GetCustomerAsync(Convert.ToString(Id));
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