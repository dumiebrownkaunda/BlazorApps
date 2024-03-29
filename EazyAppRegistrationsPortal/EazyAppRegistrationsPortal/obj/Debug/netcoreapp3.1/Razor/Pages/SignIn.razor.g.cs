#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\SignIn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2581624ffd28f479b6d0a130cb6e0dc7a6d490b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignIn")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignIn/{Id}")]
    public partial class SignIn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<body>\r\n</body>");
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\EazyAppSelfRegistration\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\SignIn.razor"
       

    [Parameter]
    public string Id { get; set; }

    SessionBridgeVm sessionBridge = null;

    protected override async Task OnInitializedAsync()
    {
        if (string.IsNullOrEmpty(Id))
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        sessionBridge = SessionBridgeVmManager.GetFromBasket(Id);

        if (sessionBridge == null)
        {
            sessionBridge = await SessionBridgeService.ValidateId(Id);

            if (sessionBridge == null)
            {
                NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
                return;
            }

            SessionBridgeVmManager.PutInBasket(sessionBridge);
            NavigationManager.NavigateTo($"home/{Id}");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfigReader ConfigReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBridgeVmManager SessionBridgeVmManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionBridgeService SessionBridgeService { get; set; }
    }
}
#pragma warning restore 1591
