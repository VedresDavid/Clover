#pragma checksum "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a5a2084ff07ba62c3b13178f3cae5302e4aeb70"
// <auto-generated/>
#pragma warning disable 1591
namespace Clover.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Clover;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Clover.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Clover.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Clover.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Data.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\vetur\Downloads\Clover\Clover\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                       CreateCase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                    localization.localizations.NewCase

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "btn-group");
            __builder.AddAttribute(7, "role", "group");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "btn btn-danger");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                          DeleteAllCases

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, 
#nullable restore
#line 10 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                           localization.localizations.DeleteAllCases

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "btn btn-secondary disabled");
            __builder.AddContent(15, 
#nullable restore
#line 11 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                             deleteAllCasesCounter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    <span style=\"margin:5px;\"></span>");
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
 if (localization.GetLocale() == LocaleEnum.HuHu)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "btn-group");
            __builder.AddAttribute(19, "role", "group");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "btn btn-success");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                localization.SetHungarianLanguage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, 
#nullable restore
#line 17 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                                                    localization.localizations.Hungarian

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                localization.SetEnglishLanguage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, 
#nullable restore
#line 18 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                                                  localization.localizations.English

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
}
else if (localization.GetLocale() == LocaleEnum.EnUs)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "btn-group");
            __builder.AddAttribute(33, "role", "group");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                localization.SetHungarianLanguage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, 
#nullable restore
#line 24 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                                                    localization.localizations.Hungarian

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "type", "button");
            __builder.AddAttribute(42, "class", "btn btn-success");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                localization.SetEnglishLanguage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, 
#nullable restore
#line 25 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                                                  localization.localizations.English

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "btn-group");
            __builder.AddAttribute(47, "role", "group");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                localization.SetHungarianLanguage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, 
#nullable restore
#line 31 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                                                    localization.localizations.Hungarian

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "class", "btn btn-primary");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                localization.SetEnglishLanguage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, 
#nullable restore
#line 32 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                                                  localization.localizations.English

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-group");
            __builder.OpenElement(62, "label");
            __builder.AddContent(63, 
#nullable restore
#line 39 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
            localization.localizations.CaseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
     if (string.IsNullOrWhiteSpace(newCase.CaseNumber) && isAddCaseClicked)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "text");
            __builder.AddAttribute(66, "class", "form-control is-invalid");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                  newCase.CaseNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCase.CaseNumber = __value, newCase.CaseNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.OpenElement(70, "label");
            __builder.AddAttribute(71, "style", "color:red;");
            __builder.AddContent(72, 
#nullable restore
#line 44 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                   localization.localizations.CaseNumberValidation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        <br>");
#nullable restore
#line 46 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
    }
    else if (isAddCaseClicked && !(CaseService.IsCaseNameValid(newCase.CaseNumber)) && !isNewCaseAdded)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "text");
            __builder.AddAttribute(76, "class", "form-control is-invalid");
            __builder.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                  newCase.CaseNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCase.CaseNumber = __value, newCase.CaseNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.OpenElement(80, "label");
            __builder.AddAttribute(81, "style", "color:red;");
            __builder.AddContent(82, 
#nullable restore
#line 51 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                   localization.localizations.CaseNameAlreadyExists

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        <br>");
#nullable restore
#line 53 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
    }
    else if (isAddCaseClicked && (CaseService.IsCaseNameValid(newCase.CaseNumber)))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "type", "text");
            __builder.AddAttribute(86, "class", "form-control is-valid");
            __builder.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                newCase.CaseNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCase.CaseNumber = __value, newCase.CaseNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        <br>");
#nullable restore
#line 59 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "text");
            __builder.AddAttribute(92, "class", "form-control");
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                       newCase.CaseNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCase.CaseNumber = __value, newCase.CaseNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        <br>");
#nullable restore
#line 65 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(96, "label");
            __builder.AddContent(97, 
#nullable restore
#line 66 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
            localization.localizations.Comment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.OpenElement(99, "input");
            __builder.AddAttribute(100, "type", "text");
            __builder.AddAttribute(101, "class", "form-control");
            __builder.AddAttribute(102, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                   newCase.Comment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCase.Comment = __value, newCase.Comment));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "input-group");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "input-group-append");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "input-group-text oi oi-magnifying-glass");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                       GetCases

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.OpenElement(113, "input");
            __builder.AddAttribute(114, "type", "text");
            __builder.AddAttribute(115, "class", "form-control");
            __builder.AddAttribute(116, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                   searchText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchText = __value, searchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n<br>\r\n");
            __builder.OpenElement(119, "table");
            __builder.AddAttribute(120, "class", "table table-striped table-bordered table-hover");
            __builder.OpenElement(121, "thead");
            __builder.AddAttribute(122, "class", "thead-dark");
            __builder.OpenElement(123, "tr");
            __builder.OpenElement(124, "th");
            __builder.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                          OrderByCaseNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(126, 
#nullable restore
#line 82 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                              localization.localizations.CaseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n            ");
            __builder.OpenElement(128, "th");
            __builder.AddAttribute(129, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                          OrderByNumberOfItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(130, 
#nullable restore
#line 83 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                 localization.localizations.NumberOfItems

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n            ");
            __builder.OpenElement(132, "th");
            __builder.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                          OrderBySum

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(134, 
#nullable restore
#line 84 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                       localization.localizations.Sum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n            ");
            __builder.OpenElement(136, "th");
            __builder.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                          OrderByComment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(138, 
#nullable restore
#line 85 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                           localization.localizations.Comment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n            ");
            __builder.OpenElement(140, "th");
            __builder.AddContent(141, 
#nullable restore
#line 86 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                 localization.localizations.Operations

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n    ");
            __builder.OpenElement(143, "tbody");
#nullable restore
#line 90 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
         foreach (var _case in cases)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(144, "tr");
            __builder.OpenElement(145, "td");
            __builder.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                () => OpenItems(_case.CaseNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(147, 
#nullable restore
#line 93 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                     _case.CaseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                ");
            __builder.OpenElement(149, "td");
            __builder.AddContent(150, 
#nullable restore
#line 94 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                     _case.NumberOfItems

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                ");
            __builder.OpenElement(152, "td");
            __builder.AddContent(153, 
#nullable restore
#line 95 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                     _case.Sum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                ");
            __builder.OpenElement(155, "td");
            __builder.AddContent(156, 
#nullable restore
#line 96 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                     _case.Comment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                ");
            __builder.OpenElement(158, "td");
            __builder.OpenElement(159, "span");
            __builder.AddAttribute(160, "class", "btn btn-danger oi oi-trash");
            __builder.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                         () => DeleteCase(_case.CaseNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(162, 
#nullable restore
#line 98 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                                                               localization.localizations.Delete

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                    ");
            __builder.OpenElement(164, "span");
            __builder.AddAttribute(165, "class", "btn btn-primary oi oi-list");
            __builder.AddAttribute(166, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                         () => ModifyCase(_case)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(167, 
#nullable restore
#line 99 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
                                                                                                    localization.localizations.Modify

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 102 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Index.razor"
       
    public bool isNewCaseAdded = false;

    public CaseOrderEnum caseOrder = CaseOrderEnum.CaseNumberAscending;

    public string searchText = "";

    public int deleteAllCasesCounter = 10;

    //makes the case number validation error not pop up on page load
    public bool isAddCaseClicked = false;

    public Case newCase = new Case();

    public List<Case> cases = new List<Case>();

    //runs when the page loads
    protected override async Task OnInitializedAsync()
    {
        await GetCases();
        await localization.GetLocalizations();
    }

    public async Task OrderByCaseNumber()
    {
        if (caseOrder == CaseOrderEnum.CaseNumberAscending)
        {
            FlipOrder();
            await GetCases();
        }
        else
        {
            caseOrder = CaseOrderEnum.CaseNumberAscending;
            await GetCases();
        }
    }

    public async Task OrderByNumberOfItems()
    {
        if (caseOrder == CaseOrderEnum.NumberOfItemsAscending)
        {
            FlipOrder();
            await GetCases();
        }
        else
        {
            caseOrder = CaseOrderEnum.NumberOfItemsAscending;
            await GetCases();
        }
    }

    public async Task OrderBySum()
    {
        if (caseOrder == CaseOrderEnum.SumAscending)
        {
            FlipOrder();
            await GetCases();
        }
        else
        {
            caseOrder = CaseOrderEnum.SumAscending;
            await GetCases();
        }
    }

    public async Task OrderByComment()
    {
        if (caseOrder == CaseOrderEnum.CommentAscending)
        {
            FlipOrder();
            await GetCases();
        }
        else
        {
            caseOrder = CaseOrderEnum.CommentAscending;
            await GetCases();
        }
    }

    public void ModifyCase(Case _case)
    {
        var parameters = new ModalParameters();
        parameters.Add("_case", _case);
        modalService.Show<ModifyCaseModal>(localization.localizations.Modify, parameters);
        modalService.OnClose += ModifyCaseModalClosed;
    }

    public void ModifyCaseModalClosed(ModalResult result)
    {
        GetCases();
        this.StateHasChanged();
        modalService.OnClose -= ModifyCaseModalClosed;
    }

    public void FlipOrder()
    {
        switch (caseOrder)
        {
            case CaseOrderEnum.CaseNumberAscending:
                caseOrder = CaseOrderEnum.CaseNumberDescending;
                break;
            case CaseOrderEnum.NumberOfItemsAscending:
                caseOrder = CaseOrderEnum.NumberOfItemsDescending;
                break;
            case CaseOrderEnum.SumAscending:
                caseOrder = CaseOrderEnum.SumDescending;
                break;
            case CaseOrderEnum.CommentAscending:
                caseOrder = CaseOrderEnum.CommentDescending;
                break;
            case CaseOrderEnum.CaseNumberDescending:
                caseOrder = CaseOrderEnum.CaseNumberAscending;
                break;
            case CaseOrderEnum.NumberOfItemsDescending:
                caseOrder = CaseOrderEnum.NumberOfItemsAscending;
                break;
            case CaseOrderEnum.SumDescending:
                caseOrder = CaseOrderEnum.SumAscending;
                break;
            case CaseOrderEnum.CommentDescending:
                caseOrder = CaseOrderEnum.CommentAscending;
                break;
            default:
                caseOrder = CaseOrderEnum.CaseNumberAscending;
                break;
        }
    }

    public async Task GetCases()
    {
        cases = await caseService.GetCases(caseOrder, searchText);
    }

    public void OpenItems(string caseNumber)
    {
        navigationManager.NavigateTo($"/items/{caseNumber}");
    }

    public async Task CreateCase()
    {
        isAddCaseClicked = true;
        if (!(string.IsNullOrWhiteSpace(newCase.CaseNumber) || !CaseService.IsCaseNameValid(newCase.CaseNumber)))
        {
            isNewCaseAdded = true;
            await caseService.CreateCase(newCase);
        }
        else
        {
            isNewCaseAdded = false;
        }
        await GetCases();
    }

    public async Task DeleteCase(string caseNumber)
    {
        await caseService.DeleteCase(caseNumber);
        await GetCases();
    }

    public async Task DeleteAllCases()
    {
        if (deleteAllCasesCounter >= 1)
        {
            deleteAllCasesCounter--;
            return;
        }
        deleteAllCasesCounter = 10;
        await caseService.DeleteAllCases();
        await GetCases();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ItemService itemService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CaseService caseService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalizationService localization { get; set; }
    }
}
#pragma warning restore 1591
