#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "856c5b7d07301365b5b0a70592e2014e9346fd4a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/remove_special_account/{Id:int}/{Key}")]
    public partial class RemoveSpecialAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-lg-12");
            __builder.AddMarkupContent(4, "\r\n        \r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card card-red");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 17 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor"
             if (specialAccount == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenComponent<BancaPortal.Pages.Spinner>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 20 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-header");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "card-title");
            __builder.AddContent(17, "Remove special account: ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "text-white");
            __builder.AddContent(20, 
#nullable restore
#line 24 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor"
                                                                                             specialAccount.AccountName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                \r\n");
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-body");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "id", "specialAccountTable");
            __builder.AddAttribute(29, "class", "table");
            __builder.AddAttribute(30, "style", "width:100%");
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.AddMarkupContent(32, "<thead>\r\n                            <tr>\r\n                                <th></th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        ");
            __builder.OpenElement(33, "tbody");
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "tr");
            __builder.AddMarkupContent(36, "\r\n                                ");
            __builder.AddMarkupContent(37, "<td>Account Name</td>\r\n                                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 39 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor"
                                     specialAccount.AccountName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "\r\n                                ");
            __builder.AddMarkupContent(44, "<td>Account Number</td>\r\n                                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 43 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor"
                                     specialAccount.AccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.OpenElement(49, "tr");
            __builder.AddMarkupContent(50, "\r\n                                ");
            __builder.AddMarkupContent(51, "<td>Date Created</td>\r\n                                ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 47 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor"
                                     specialAccount.DateCreated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "card-footer");
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-danger");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor"
                                                             () => RemoveSpecialAccountAsync(specialAccount.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "Remove");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "a");
            __builder.AddAttribute(68, "href", "white_listed_accounts/" + (
#nullable restore
#line 54 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor"
                                                    Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "role", "button");
            __builder.AddAttribute(70, "class", "btn btn-link float-right");
            __builder.AddContent(71, "Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 56 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Accounts\RemoveSpecialAccount.razor"
       
    [Parameter]
    public int Id { get; set; }
    [Parameter]
    public string Key { get; set; }

    SpecialAccountVm specialAccount;

    protected override async Task OnInitializedAsync()
    {
        if (SessionChecker.IsSessionMissing(Key) || SessionLifeChecker.IsExpired(Key))
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        if (!await PageAccessChecker.HasAccess("remove_special_account", Key))
        {
            NavigationManager.NavigateTo($"access_denied/{Key}");
        }

        await FetchSpecialAccount();
    }


    protected async Task FetchSpecialAccount()
    {
        specialAccount = await AccountSettingsService.GetAccountSettingAsync(Id);

        if (specialAccount == null)
        {
            NavigationManager.NavigateTo($"remove_special_account/{Key}");
            return;
        }
    }

    protected async Task RemoveSpecialAccountAsync(int Id)
    {
        bool removed = await AccountSettingsService.RemoveAccountSettingsAsync(Id);

        string action = removed ? $"Removed special account" : "Tried to remove special account";

        await ActionsService.AddAsync(SessionBridgeVmManager.GetFromBasket(Key),
                action, specialAccount.AccountNumber);

        NavigationManager.NavigateTo($"operation_successful/2/{Key}");
    }


#line default
#line hidden
#nullable disable
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
