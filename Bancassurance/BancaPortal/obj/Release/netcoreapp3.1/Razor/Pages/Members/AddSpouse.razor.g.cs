#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa412c4bf07a4823ff49c2adbc88c7cde715501"
// <auto-generated/>
#pragma warning disable 1591
namespace BancaPortal.Pages.Members
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/add_spouse/{Id:long}/{Key}")]
    public partial class AddSpouse : Microsoft.AspNetCore.Components.ComponentBase
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
#line 18 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
         if (member == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "            ");
            __builder.OpenComponent<BancaPortal.Pages.Spinner>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 21 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "            \r\n            \r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card card-red");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-header");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "card-title");
            __builder.AddContent(17, "Add spouse of ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "text-white");
            __builder.AddContent(20, 
#nullable restore
#line 28 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                                   member.CustomerName

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
#line 32 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                  _dependantForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 32 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
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
#line 38 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
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
                __builder2.AddMarkupContent(51, "<label for=\"firstName\" class=\"col-sm-6 col-form-label\">First Name</label>\r\n                            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-sm-10");
                __builder2.AddMarkupContent(54, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "id", "firstName");
                __builder2.AddAttribute(57, "Class", "form-control");
                __builder2.AddAttribute(58, "ReadOnly", 
#nullable restore
#line 46 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                                                                                 cannotAddSpouse

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                       _dependantForm.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _dependantForm.FirstName = __value, _dependantForm.FirstName))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _dependantForm.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n                        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group row");
                __builder2.AddMarkupContent(67, "\r\n                            ");
                __builder2.AddMarkupContent(68, "<label for=\"lastName\" class=\"col-sm-6 col-form-label\">Last Name</label>\r\n                            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col-sm-10");
                __builder2.AddMarkupContent(71, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "id", "lastName");
                __builder2.AddAttribute(74, "Class", "form-control");
                __builder2.AddAttribute(75, "ReadOnly", 
#nullable restore
#line 53 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                                                                              cannotAddSpouse

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                      _dependantForm.SurName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _dependantForm.SurName = __value, _dependantForm.SurName))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _dependantForm.SurName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n                        ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group row");
                __builder2.AddMarkupContent(84, "\r\n                            ");
                __builder2.AddMarkupContent(85, "<label for=\"phoneNumber\" class=\"col-sm-6 col-form-label\">Phone Number</label>\r\n                            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "col-sm-10");
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(89);
                __builder2.AddAttribute(90, "id", "phoneNumber");
                __builder2.AddAttribute(91, "Class", "form-control");
                __builder2.AddAttribute(92, "ReadOnly", 
#nullable restore
#line 60 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                                                                                     cannotAddSpouse

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                         _dependantForm.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _dependantForm.PhoneNumber = __value, _dependantForm.PhoneNumber))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _dependantForm.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n\r\n                        ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group row");
                __builder2.AddMarkupContent(101, "\r\n                            ");
                __builder2.AddMarkupContent(102, "<label for=\"age\" class=\"col-sm-6 col-form-label\">Age</label>\r\n                            ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "col-sm-10");
                __builder2.AddMarkupContent(105, "\r\n                                ");
                __Blazor.BancaPortal.Pages.Members.AddSpouse.TypeInference.CreateInputSelect_0(__builder2, 106, 107, "age", 108, "form-control", 109, 
#nullable restore
#line 67 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                                                                       cannotAddSpouse

#line default
#line hidden
#nullable disable
                , 110, 
#nullable restore
#line 67 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                   _dependantForm.Age

#line default
#line hidden
#nullable disable
                , 111, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _dependantForm.Age = __value, _dependantForm.Age)), 112, () => _dependantForm.Age, 113, (__builder3) => {
                    __builder3.AddMarkupContent(114, "\r\n                                    ");
                    __builder3.AddMarkupContent(115, "<option selected=\"selected\" disabled=\"disabled\">Select</option>\r\n");
#nullable restore
#line 69 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                     foreach (var age in ages)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(116, "                                        ");
                    __builder3.OpenElement(117, "option");
                    __builder3.AddAttribute(118, "value", 
#nullable restore
#line 71 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                        age

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(119, 
#nullable restore
#line 71 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                              age

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n");
#nullable restore
#line 72 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(121, "                                ");
                }
                );
                __builder2.AddMarkupContent(122, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n\r\n                        ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "form-group row");
                __builder2.AddMarkupContent(127, "\r\n                            ");
                __builder2.AddMarkupContent(128, "<label for=\"relationship\" class=\"col-sm-6 col-form-label\">Relationship</label>\r\n                            ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "col-sm-10");
                __builder2.AddMarkupContent(131, "\r\n                                ");
                __Blazor.BancaPortal.Pages.Members.AddSpouse.TypeInference.CreateInputSelect_1(__builder2, 132, 133, "relationship", 134, "form-control", 135, 
#nullable restore
#line 80 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                                                                                         cannotAddSpouse

#line default
#line hidden
#nullable disable
                , 136, 
#nullable restore
#line 80 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                            _dependantForm.Relationship

#line default
#line hidden
#nullable disable
                , 137, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _dependantForm.Relationship = __value, _dependantForm.Relationship)), 138, () => _dependantForm.Relationship, 139, (__builder3) => {
                    __builder3.AddMarkupContent(140, "\r\n                                    ");
                    __builder3.AddMarkupContent(141, "<option selected=\"selected\" disabled=\"disabled\">Select</option>\r\n");
#nullable restore
#line 82 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                     if (member.Gender == "FEMALE")
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(142, "                                        ");
                    __builder3.AddMarkupContent(143, "<option value=\"Husband\">Husband</option>\r\n");
#nullable restore
#line 85 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(144, "                                        ");
                    __builder3.AddMarkupContent(145, "<option value=\"Wife\">Wife</option>\r\n");
#nullable restore
#line 89 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(146, "                                ");
                }
                );
                __builder2.AddMarkupContent(147, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n\r\n                        ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "form-group row");
                __builder2.AddMarkupContent(152, "\r\n                            ");
                __builder2.AddMarkupContent(153, "<label for=\"teller\" class=\"col-sm-6 col-form-label\">Teller</label>\r\n                            ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "col-sm-10");
                __builder2.AddMarkupContent(156, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(157);
                __builder2.AddAttribute(158, "id", "teller");
                __builder2.AddAttribute(159, "Class", "form-control");
                __builder2.AddAttribute(160, "ReadOnly", "true");
                __builder2.AddAttribute(161, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 97 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                    _dependantForm.InputTeller

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(162, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _dependantForm.InputTeller = __value, _dependantForm.InputTeller))));
                __builder2.AddAttribute(163, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _dependantForm.InputTeller));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(164, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(165, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(166, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(167, "\r\n                    \r\n                    ");
                __builder2.OpenElement(168, "div");
                __builder2.AddAttribute(169, "class", "card-footer");
                __builder2.AddMarkupContent(170, "\r\n                        ");
                __builder2.OpenElement(171, "button");
                __builder2.AddAttribute(172, "type", "submit");
                __builder2.AddAttribute(173, "class", "btn btn-primary");
                __builder2.AddAttribute(174, "disabled", 
#nullable restore
#line 104 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                                                 cannotAddSpouse

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(175, "Add Spouse");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\r\n                        ");
                __builder2.OpenElement(177, "a");
                __builder2.AddAttribute(178, "href", "dependants/" + (
#nullable restore
#line 105 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                             member.Id

#line default
#line hidden
#nullable disable
                ) + "/" + (
#nullable restore
#line 105 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
                                                        Key

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(179, "class", "float-right");
                __builder2.AddContent(180, "Back");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(181, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(182, "\r\n                    \r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(183, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n            \r\n");
#nullable restore
#line 111 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(185, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\bancassurance\Bancassurance\BancaPortal\Pages\Members\AddSpouse.razor"
       
    [Parameter]
    public long Id { get; set; }
    [Parameter]
    public string Key { get; set; }

    private DependantForm _dependantForm = new DependantForm();

    MemberVm member;
    bool cannotAddSpouse;
    string message;

    List<int> ages = new List<int>();

    protected override async Task OnInitializedAsync()
    {
        if (SessionChecker.IsSessionMissing(Key) || SessionLifeChecker.IsExpired(Key))
        {
            NavigationManager.NavigateTo(ConfigReader.Read("VasPortalUrl"));
            return;
        }

        if (!await PageAccessChecker.HasAccess("add_spouse", Key))
        {
            NavigationManager.NavigateTo($"access_denied/{Key}");
        }

        _dependantForm.InputTeller = SessionBridgeVmManager.GetFromBasket(Key).FullName;

        await FetchMember(Id);

        InitializeAges();
    }

    protected async Task FetchMember(long memberId)
    {
        member = await MemberService.GetMemberAsync(Id);

        if (member == null)
        {
            RedirectToMembers();
            return;
        }

        cannotAddSpouse = !(MemberDependantsUtils.CanAddSpouse(Mapper.Map<MainMemberDetails>(member), ConfigReader));
    }

    protected void InitializeAges()
    {
        int start = Convert.ToInt32(ConfigReader.Read("MemberMinimumAge"));
        int end = Convert.ToInt32(ConfigReader.Read("MemberMaximumAge"));
        int count = (end - start) + 1;

        ages = NumberService.Generate(start, count).ToList();
    }

    protected void RedirectToMembers()
    {
        NavigationManager.NavigateTo($"members/{Key}");
    }

    protected void RedirectToDependants()
    {
        NavigationManager.NavigateTo($"dependants/{Id}/{Key}");
    }

    protected async Task HandleValidSubmit()
    {
        if (await AddDependantAsync())
        {
            RedirectToDependants();
            return;
        }
        else
        {

            _dependantForm = new DependantForm();
            message = "Spouse not added. Please try again later";
        }
    }

    protected async Task<bool> AddDependantAsync()
    {
        _dependantForm.InputTeller = Convert.ToString(SessionBridgeVmManager.GetFromBasket(Key).TellerId);

        DependantFormUtil.Capitilize(ref _dependantForm);

        var dependantVm = Mapper.Map<DependantVm>(_dependantForm);
        dependantVm.MemberId = Id;
        dependantVm.Normal = 2;
        dependantVm.DateAdded = DateTime.Now;
        dependantVm.InputTeller = Convert.ToString(SessionBridgeVmManager.GetFromBasket(Key).TellerId);

        var dependant = Mapper.Map<Dependents>(dependantVm);

        bool submitted = await DependantsService.AddSpouseAsync(dependant);

        string action = submitted ? $"Added spouse for member with Id: {Id}"
           : $"Failed to add spouse for member with Id: {Id}";

        await ActionsService.AddAsync(SessionBridgeVmManager.GetFromBasket(Key),
                action, $"{dependantVm.FirstName} {dependantVm.SurName}");

        return submitted;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPortalUserActionsService ActionsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionLifeChecker SessionLifeChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionBridgeVmManager SessionBridgeVmManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPageAccessChecker PageAccessChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfigReader ConfigReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionChecker SessionChecker { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INumberService NumberService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AutoMapper.IMapper Mapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDependantsService DependantsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMemberService MemberService { get; set; }
    }
}
namespace __Blazor.BancaPortal.Pages.Members.AddSpouse
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "ReadOnly", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "ReadOnly", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
