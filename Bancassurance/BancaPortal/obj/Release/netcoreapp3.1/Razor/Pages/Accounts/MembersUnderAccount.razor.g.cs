#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b2038c8f03cb18571331b5566b55a9da09d6c5"
// <auto-generated/>
#pragma warning disable 1591
namespace BancaPortal.Pages.Accounts
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/members_under_account/{Account}/{Key}")]
    public partial class MembersUnderAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "\r\n        ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-lg-12");
            __builder.AddMarkupContent(4, "\r\n            ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card card-red");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 17 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                 if (members == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                    ");
            __builder.OpenComponent<BancaPortal.Pages.Spinner>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 20 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-header");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "card-title");
            __builder.AddContent(17, "Member(s) Under Account ");
            __builder.AddContent(18, 
#nullable restore
#line 24 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                                                        Account

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.AddMarkupContent(23, "\r\n                        <div class=\"mt-2\"></div>\r\n                        ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "remove_account/" + (
#nullable restore
#line 28 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                                 Account

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 28 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                                          members.Count()

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 28 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                                                           Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "role", "button");
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddContent(28, "Remove Account");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        <div class=\"mt-2\"></div>\r\n                        ");
            __builder.OpenElement(30, "table");
            __builder.AddAttribute(31, "id", "membersUnderAccountTable");
            __builder.AddAttribute(32, "class", "table table-striped table-bordered");
            __builder.AddAttribute(33, "style", "width:100%");
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.AddMarkupContent(35, @"<thead>
                                <tr>
                                    <th>Member Name</th>
                                    <th>Phone Number</th>
                                    <th>Account Number</th>
                                    <th>Turn Over Type</th>
                                    <th>Dependants Total</th>
                                    <th></th>
                                </tr>
                            </thead>
                            ");
            __builder.OpenElement(36, "tbody");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 42 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                 foreach (var member in members)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                                    ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\r\n                                        ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 45 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                             member.CustomerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                        ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 46 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                             member.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                        ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 47 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                             member.AccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                        ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 48 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                             member.TurnOver.TurnOverType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                        ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 49 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                             member.Dependents?.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                        ");
            __builder.OpenElement(56, "td");
            __builder.AddMarkupContent(57, "\r\n                                            ");
            __builder.OpenElement(58, "span");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "href", "dependants/" + (
#nullable restore
#line 51 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                                                       member.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 51 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                                                                  Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "class", "btn btn-primary");
            __builder.AddContent(62, "Dependants");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                            ");
            __builder.OpenElement(64, "span");
            __builder.OpenElement(65, "a");
            __builder.AddAttribute(66, "href", "unsubscribe/" + (
#nullable restore
#line 52 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                                                        member.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 52 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                                                                   Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "role", "button");
            __builder.AddAttribute(68, "class", "btn btn-danger");
            __builder.AddContent(69, "Unsubscribe");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 55 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "card-footer");
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "a");
            __builder.AddAttribute(81, "href", "accounts/" + (
#nullable restore
#line 60 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                           Account

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 60 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                                                    Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "role", "button");
            __builder.AddAttribute(83, "class", "btn btn-link float-right");
            __builder.AddContent(84, "Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 62 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\MembersUnderAccount.razor"
       

    [Parameter]
    public string Account { get; set; }
    [Parameter]
    public string Key { get; set; }

    List<MemberVm> members;

    protected override async Task OnInitializedAsync()
    {
        if (SessionChecker.IsSessionMissing(Key) || SessionLifeChecker.IsExpired(Key))
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        if (!await PageAccessChecker.HasAccess("members_under_account", Key))
        {
            NavigationManager.NavigateTo($"access_denied/{Key}");
        }

        await FetchMembersByAccount();
    }


    protected async Task FetchMembersByAccount()
    {
        members = await MemberService.GetMembersAsync(MemberExpressions.FilterByAccount(Account));

        if (members == null)
        {
            NavigationManager.NavigateTo($"accounts/{Key}");
            return;
        }
    }

    protected override void OnAfterRender(bool firstRender)
    {
        ActivateTable();
    }

    private void ActivateTable()
    {
        JSRuntime.InvokeAsync<object>("ActivateDataTable", "#membersUnderAccountTable");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMemberService MemberService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPortalUserActionsService ActionsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionLifeChecker SessionLifeChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPageAccessChecker PageAccessChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfigReader ConfigReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionChecker SessionChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBridgeVmManager SessionBridgeVmManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountSettingsService AccountSettingsService { get; set; }
    }
}
#pragma warning restore 1591
