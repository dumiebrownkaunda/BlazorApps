#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7253a523ec3540277155bc53294027e1d2b2f0b2"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/unsubscribe/{Id:long}/{Key}")]
    public partial class UnSubscribeMember : Microsoft.AspNetCore.Components.ComponentBase
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
#line 18 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
             if (member == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenComponent<BancaPortal.Pages.Spinner>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 21 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
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
            __builder.AddContent(17, "Request Unsubscription of ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "text-white");
            __builder.AddContent(20, 
#nullable restore
#line 25 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
                                                                                               _unsubscribeForm.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                \r\n                \r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(23);
            __builder.AddAttribute(24, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 29 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
                                  _unsubscribeForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 29 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
                                                                   HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "Class", "form-horizontal");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(29);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "card-body");
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group row");
                __builder2.AddMarkupContent(36, "\r\n                            <label></label>\r\n                            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-sm-10");
                __builder2.AddMarkupContent(39, "\r\n                                ");
                __builder2.OpenElement(40, "label");
                __builder2.AddAttribute(41, "class", "text-info");
                __builder2.AddContent(42, 
#nullable restore
#line 35 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
                                                          message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(44);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n                        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group row");
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.AddMarkupContent(51, "<label for=\"lastName\" class=\"col-sm-6 col-form-label\">Member Name</label>\r\n                            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-sm-10");
                __builder2.AddMarkupContent(54, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "id", "lastName");
                __builder2.AddAttribute(57, "Class", "form-control");
                __builder2.AddAttribute(58, "ReadOnly", "true");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
                                                                      _unsubscribeForm.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _unsubscribeForm.FullName = __value, _unsubscribeForm.FullName))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _unsubscribeForm.FullName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n                        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group row");
                __builder2.AddMarkupContent(67, "\r\n                            ");
                __builder2.AddMarkupContent(68, "<label for=\"phoneNumber\" class=\"col-sm-6 col-form-label\">Phone Number</label>\r\n                            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col-sm-10");
                __builder2.AddMarkupContent(71, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "id", "phoneNumber");
                __builder2.AddAttribute(74, "Class", "form-control");
                __builder2.AddAttribute(75, "ReadOnly", "true");
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
                                                                         _unsubscribeForm.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _unsubscribeForm.PhoneNumber = __value, _unsubscribeForm.PhoneNumber))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _unsubscribeForm.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n                        ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group row");
                __builder2.AddMarkupContent(84, "\r\n                            ");
                __builder2.AddMarkupContent(85, "<label for=\"accountNumber\" class=\"col-sm-6 col-form-label\">Account Number</label>\r\n                            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "col-sm-10");
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(89);
                __builder2.AddAttribute(90, "id", "accountNumber");
                __builder2.AddAttribute(91, "Class", "form-control");
                __builder2.AddAttribute(92, "ReadOnly", "true");
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
                                                                           _unsubscribeForm.AccountNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _unsubscribeForm.AccountNumber = __value, _unsubscribeForm.AccountNumber))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _unsubscribeForm.AccountNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n\r\n                        ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group row");
                __builder2.AddMarkupContent(101, "\r\n                            ");
                __builder2.AddMarkupContent(102, "<label for=\"reason\" class=\"col-sm-6 col-form-label\">Reason</label>\r\n                            ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "col-sm-10");
                __builder2.AddMarkupContent(105, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(106);
                __builder2.AddAttribute(107, "id", "reason");
                __builder2.AddAttribute(108, "Class", "form-control");
                __builder2.AddAttribute(109, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
                                                                        _unsubscribeForm.Reason

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _unsubscribeForm.Reason = __value, _unsubscribeForm.Reason))));
                __builder2.AddAttribute(111, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _unsubscribeForm.Reason));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(112, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                    \r\n                    ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "card-footer");
                __builder2.AddMarkupContent(118, "\r\n                        ");
                __builder2.AddMarkupContent(119, "<button type=\"submit\" class=\"btn btn-primary\">Request Unsubscription</button>\r\n                        ");
                __builder2.OpenElement(120, "a");
                __builder2.AddAttribute(121, "href", "members/" + (
#nullable restore
#line 71 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
                                          Key

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "class", "float-right");
                __builder2.AddContent(123, "Back");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n                    \r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(126, "\r\n                \r\n");
#nullable restore
#line 76 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Policies\UnSubscribeMember.razor"
       

    [Parameter]
    public long Id { get; set; }
    [Parameter]
    public string Key { get; set; }

    private UnsubscribeForm _unsubscribeForm = new UnsubscribeForm();

    string message;
    MemberVm member;
    SessionBridgeVm sessionBridge;

    protected override async Task OnInitializedAsync()
    {
        if (SessionChecker.IsSessionMissing(Key) || SessionLifeChecker.IsExpired(Key))
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        if (!await PageAccessChecker.HasAccess("unsubscribe", Key))
        {
            NavigationManager.NavigateTo($"access_denied/{Key}");
            return;
        }

        sessionBridge = SessionBridgeVmManager.GetFromBasket(Key);

        await FetchMember(Id);
    }

    protected async Task FetchMember(long memberId)
    {
        member = await MemberService.GetMemberAsync(Id);

        if (member != null)
        {
            _unsubscribeForm = Mapper.Map<UnsubscribeForm>(member);
            _unsubscribeForm.LastName = member.SurName;
            _unsubscribeForm.FullName = $"{member.FirstName} {member.SurName}";
        }
        else
        {
            RedirectToMembers();
        }
    }

    protected void RedirectToMembers()
    {
        NavigationManager.NavigateTo($"members/{Key}");
    }

    protected async Task HandleValidSubmit()
    {
        if (await RequestUnSubscrptionAsync(Id, sessionBridge.Username, _unsubscribeForm.Reason))
        {
            RedirectToMembers();
            return;
        }

        _unsubscribeForm = new UnsubscribeForm();
    }

    protected async Task<bool> RequestUnSubscrptionAsync(long memberId, string requester, string reason)
    {
        bool submitted = await UnsubscriptionService.RequestUnSubscriptionAsync(memberId, requester, reason);

        return submitted;
    }

    protected override void OnAfterRender(bool firstRender)
    {
        ActivateTable();
    }

    private void ActivateTable()
    {
        JSRuntime.InvokeAsync<object>("ActivateDataTable", "#membersTable");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionLifeChecker SessionLifeChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBridgeVmManager SessionBridgeVmManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPageAccessChecker PageAccessChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfigReader ConfigReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionChecker SessionChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AutoMapper.IMapper Mapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnsubscriptionService UnsubscriptionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMemberService MemberService { get; set; }
    }
}
#pragma warning restore 1591
