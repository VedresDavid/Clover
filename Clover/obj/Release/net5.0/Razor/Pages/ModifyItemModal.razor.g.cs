#pragma checksum "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ac83cede332f3fef41f8bf630d76e195d27e790"
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
    public partial class ModifyItemModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>");
#nullable restore
#line 6 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
 if (item.IsIn)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "btn-group");
            __builder.AddAttribute(3, "role", "group");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "type", "button");
            __builder.AddAttribute(6, "class", "btn btn-success");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                  () => item.IsIn = true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, 
#nullable restore
#line 9 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                                            localization.localizations.In

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                  () => item.IsIn = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, 
#nullable restore
#line 10 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                                             localization.localizations.Out

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
}
else if (!item.IsIn)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "btn-group");
            __builder.AddAttribute(17, "role", "group");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                  () => item.IsIn = true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, 
#nullable restore
#line 16 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                                            localization.localizations.In

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-success");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                  () => item.IsIn = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, 
#nullable restore
#line 17 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                                             localization.localizations.Out

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "btn-group");
            __builder.AddAttribute(31, "role", "group");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                  () => item.IsIn = true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, 
#nullable restore
#line 23 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                                            localization.localizations.In

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                  () => item.IsIn = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, 
#nullable restore
#line 24 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                                                             localization.localizations.Out

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<br>\r\n");
            __builder.OpenElement(44, "label");
            __builder.AddContent(45, 
#nullable restore
#line 28 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
        localization.localizations.Sender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
 if (string.IsNullOrWhiteSpace(item.Sender))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "class", "form-control is-invalid");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                              item.Sender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Sender = __value, item.Sender));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenElement(52, "label");
            __builder.AddAttribute(53, "style", "color:red;");
            __builder.AddContent(54, 
#nullable restore
#line 32 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                               localization.localizations.SenderValidation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    <br>");
#nullable restore
#line 34 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
}
else if (!string.IsNullOrWhiteSpace(item.Sender))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "text");
            __builder.AddAttribute(58, "class", "form-control is-valid");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                            item.Sender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Sender = __value, item.Sender));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    <br>");
#nullable restore
#line 39 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "text");
            __builder.AddAttribute(64, "class", "form-control");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                   item.Sender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Sender = __value, item.Sender));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    <br>");
#nullable restore
#line 44 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(68, "label");
            __builder.AddContent(69, 
#nullable restore
#line 45 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
        localization.localizations.Reciever

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
 if (string.IsNullOrWhiteSpace(item.Reciever))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "text");
            __builder.AddAttribute(72, "class", "form-control is-invalid");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                              item.Reciever

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Reciever = __value, item.Reciever));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.OpenElement(76, "label");
            __builder.AddAttribute(77, "style", "color:red;");
            __builder.AddContent(78, 
#nullable restore
#line 49 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                               localization.localizations.RecieverValidation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    <br>");
#nullable restore
#line 51 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
}
else if (!string.IsNullOrWhiteSpace(item.Reciever))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "text");
            __builder.AddAttribute(82, "class", "form-control is-valid");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                            item.Reciever

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Reciever = __value, item.Reciever));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    <br>");
#nullable restore
#line 56 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "type", "text");
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                   item.Reciever

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Reciever = __value, item.Reciever));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n    <br>");
#nullable restore
#line 61 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(92, "label");
            __builder.AddContent(93, 
#nullable restore
#line 62 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
        localization.localizations.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.OpenElement(95, "input");
            __builder.AddAttribute(96, "type", "number");
            __builder.AddAttribute(97, "class", "form-control");
            __builder.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                                 item.Amount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Amount = __value, item.Amount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n<br>\r\n");
            __builder.OpenElement(101, "label");
            __builder.AddContent(102, 
#nullable restore
#line 65 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
        localization.localizations.TransactionDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n<br>\r\n");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "type", "text");
            __builder.AddAttribute(106, "class", "form-control");
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                               item.TransactionDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.TransactionDate = __value, item.TransactionDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\r\n<hr>\r\n");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "btn btn-success");
            __builder.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                       Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(113, 
#nullable restore
#line 70 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
                                              localization.localizations.Save

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\vetur\Downloads\Clover\Clover\Pages\ModifyItemModal.razor"
       
    [CascadingParameter] ModalParameters Parameters { get; set; }

    public Item item { get; set; } = new Item();

    //runs when the modal loads
    protected override async Task OnInitializedAsync()
    {
        item = Parameters.Get<Item>("item");
    }

    public async Task Save()
    {
        if (IsModifyItemValid())
        {
            await itemService.ModifyItem(item);
            modalService.Close(ModalResult.Ok("save"));
        }
    }

    public bool IsModifyItemValid()
    {
        if (string.IsNullOrWhiteSpace(item.Sender) || string.IsNullOrWhiteSpace(item.Reciever))
        {
            return false;
        }
        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalizationService localization { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ItemService itemService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modalService { get; set; }
    }
}
#pragma warning restore 1591