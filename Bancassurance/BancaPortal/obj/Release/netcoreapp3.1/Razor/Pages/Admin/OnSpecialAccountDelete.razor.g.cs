#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Admin\OnSpecialAccountDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1bc6c047a20e452960472a889771c4bca98eb99"
// <auto-generated/>
#pragma warning disable 1591
namespace BancaPortal.Pages.Admin
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/on_special_account_delete_setting/{Key}")]
    public partial class OnSpecialAccountDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-lg-12");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 14 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Admin\OnSpecialAccountDelete.razor"
         if (!added)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "            ");
            __builder.AddMarkupContent(6, @"<div class=""alert alert-danger alert-dismissible"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
                <h5><i class=""icon fas fa-ban""></i> Alert!</h5>
                setting not applied, please try again later
            </div>
");
#nullable restore
#line 21 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Admin\OnSpecialAccountDelete.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "        \r\n        \r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card card-red");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<div class=\"card-header\">\r\n                <h5 class=\"card-title\">Settings</h5>\r\n            </div>\r\n            \r\n            \r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Admin\OnSpecialAccountDelete.razor"
                              _settings

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 30 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Admin\OnSpecialAccountDelete.razor"
                                                        HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "Class", "form-horizontal");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "card-body");
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "\r\n                        <label></label>\r\n                        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-sm-10");
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(29);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n                    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group row");
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "label");
                __builder2.AddAttribute(37, "for", "ShowDateOnAdd");
                __builder2.AddAttribute(38, "class", "col-sm-2 col-form-label");
                __builder2.AddContent(39, 
#nullable restore
#line 41 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Admin\OnSpecialAccountDelete.razor"
                                                                                    _settings.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-sm-2");
                __builder2.AddMarkupContent(43, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(44);
                __builder2.AddAttribute(45, "id", "ShowDateOnAdd");
                __builder2.AddAttribute(46, "class", "form-check-label");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Admin\OnSpecialAccountDelete.razor"
                                                        _settings.Value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _settings.Value = __value, _settings.Value))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => _settings.Value));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                \r\n                ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "card-footer");
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.AddMarkupContent(57, "<button type=\"submit\" class=\"btn btn-primary\">Apply</button>\r\n                    ");
                __builder2.OpenElement(58, "a");
                __builder2.AddAttribute(59, "href", "all_settings/" + (
#nullable restore
#line 50 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Admin\OnSpecialAccountDelete.razor"
                                           Key

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "class", "float-right");
                __builder2.AddContent(61, "Back");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                \r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Admin\OnSpecialAccountDelete.razor"
       

    [Parameter]
    public string Key { get; set; }

    private bool added = true;

    SystemSettingsVm _settings = new SystemSettingsVm();

    protected override async Task OnInitializedAsync()
    {
        if (SessionChecker.IsSessionMissing(Key) || SessionLifeChecker.IsExpired(Key))
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        if (!await PageAccessChecker.HasAccess("settings", Key))
        {
            NavigationManager.NavigateTo($"access_denied/{Key}");
        }

        var onDeleteSetting = await SystemSettingsService.GetSystemSettingByCodeAsync(SystemSettingsExpression.Filter(3));

        if (onDeleteSetting == null) return;

        _settings = onDeleteSetting;
    }

    protected async Task HandleValidSubmit()
    {
        added = await SystemSettingsService.UpdateSystemSettingAsync(Mapper.Map<SystemSettings>(_settings));

        if (added)
        {
            NavigationManager.NavigateTo($"home/{Key}");
            return;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionLifeChecker SessionLifeChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISystemSettingsService SystemSettingsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPageAccessChecker PageAccessChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfigReader ConfigReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionChecker SessionChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AutoMapper.IMapper Mapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
