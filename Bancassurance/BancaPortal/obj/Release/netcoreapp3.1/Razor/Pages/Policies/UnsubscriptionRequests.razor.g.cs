#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae2e5dd56fdd0270ef3a35bdb0baa30450efadb"
// <auto-generated/>
#pragma warning disable 1591
namespace BancaPortal.Pages.Policies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancaPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancaPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancaPortal.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.Mappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceApi.Expressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BancassuranceLib.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/unsubscriptions/{Key}")]
    public partial class UnsubscriptionRequests : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-lg-12");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card card-red");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 15 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
             if (unSubscriptionRequests == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenComponent<BancaPortal.Pages.Spinner>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 18 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.AddMarkupContent(12, "<div class=\"card-header\">\r\n                    <h5 class=\"card-title\">Unsubscriptions</h5>\r\n                </div>\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "id", "requestsTable");
            __builder.AddAttribute(18, "class", "table table-striped table-bordered");
            __builder.AddAttribute(19, "style", "width:100%");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.AddMarkupContent(21, @"<thead>
                            <tr>
                                <th>Main Member</th>
                                <th>Premium</th>
                                <th>Account</th>
                                <th>Reason</th>
                                <th>Options</th>
                            </tr>
                        </thead>
                        ");
            __builder.OpenElement(22, "tbody");
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 36 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                             foreach (var request in unSubscriptionRequests)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "                                ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\r\n                                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 39 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                                         request.CustomerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 40 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                                         request.TurnOver.TurnOverType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 41 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                                         request.AccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 42 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                                         request.VoidReason

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                    ");
            __builder.OpenElement(39, "td");
            __builder.AddMarkupContent(40, "\r\n                                        ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "href", "accept_unsubscription/" + (
#nullable restore
#line 44 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                                                                        request.id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 44 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                                                                                    Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "role", "button");
            __builder.AddAttribute(44, "class", "btn btn-primary");
            __builder.AddContent(45, "Accept");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                        ");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "href", "reject_unsubscription/" + (
#nullable restore
#line 45 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                                                                        request.id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 45 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                                                                                    Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "role", "button");
            __builder.AddAttribute(50, "class", "btn btn-danger");
            __builder.AddContent(51, "Reject");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 48 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "card-footer");
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "href", "home/" + (
#nullable restore
#line 53 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
                                   Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, "Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 55 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnsubscriptionRequests.razor"
       

    [Parameter]
    public string Key { get; set; }

    List<UnSubscriptionRequest> unSubscriptionRequests;

    protected override async Task OnInitializedAsync()
    {
        if (SessionChecker.IsSessionMissing(Key) || SessionLifeChecker.IsExpired(Key))
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        if (!await PageAccessChecker.HasAccess("unsubscriptions", Key))
        {
            NavigationManager.NavigateTo($"access_denied/{Key}");
            return;
        }

        unSubscriptionRequests = await UnsubscriptionService.GetPendingUnsubscriptionsAsync();
    }

    protected override void OnAfterRender(bool firstRender)
    {
        ActivateTable();
    }

    private void ActivateTable()
    {
        JSRuntime.InvokeAsync<object>("ActivateDataTable", "#requestsTable");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionLifeChecker SessionLifeChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBridgeVmManager SessionBridgeVmManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPageAccessChecker PageAccessChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfigReader ConfigReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionChecker SessionChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnsubscriptionService UnsubscriptionService { get; set; }
    }
}
#pragma warning restore 1591