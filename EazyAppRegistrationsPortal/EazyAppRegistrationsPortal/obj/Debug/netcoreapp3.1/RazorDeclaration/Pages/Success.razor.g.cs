#pragma checksum "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Success.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3dc84cc87a88ee23105371a250c324226bd1829"
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
#line 1 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\_Imports.razor"
using EazyAppRegistrationsPortal.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{Id:guid}")]
    public partial class Success : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\kadzitaye.m\Documents\Visual Studio 2019\Projects\eazyappregistrationportal\EazyAppRegistrationsPortal\EazyAppRegistrationsPortal\Pages\Success.razor"
       

    [Parameter]
    public Guid Id { get; set; }

    public SessionBridgeVm sessionBridge = null;

    protected override async Task OnInitializedAsync()
    {
        sessionBridge = SessionBridgeVmManager.GetFromBasket();

        if (sessionBridge == null)
        {
            sessionBridge = await SessionBridgeService.ValidateId(Id);

            if (sessionBridge == null)
                return;

            SessionBridgeVmManager.PutInBasket(sessionBridge);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBridgeVmManager SessionBridgeVmManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionBridgeService SessionBridgeService { get; set; }
    }
}
#pragma warning restore 1591
