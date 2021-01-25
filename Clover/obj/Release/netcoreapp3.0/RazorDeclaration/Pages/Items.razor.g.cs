// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/items/{caseNumber}")]
    public partial class Items : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 169 "C:\Users\vetur\Downloads\Clover\Clover\Pages\Items.razor"
       
    public string searchText = "";

    public ItemOrderEnum itemOrder = ItemOrderEnum.TransactionDateAscending;

    public int deleteAllItemsCounter = 10;

    public bool isInOutButtonGroupClicked = false;

    [Parameter]
    public string caseNumber { get; set; }

    public bool isAddItemClicked = false;

    Case _case = new Case();

    List<Item> items = new List<Item>();

    //object used to hold the values for creating a new item.
    Item newItem = new Item();

    //runs when the page loads
    protected override async Task OnInitializedAsync()
    {
        _case = await caseService.GetCase(caseNumber);
        await GetItems();
        newItem.CaseNumber = caseNumber;
    }

    public async Task OrderBySender()
    {
        if (itemOrder == ItemOrderEnum.SenderAscending)
        {
            FlipOrder();
            await GetItems();
        }
        else
        {
            itemOrder = ItemOrderEnum.SenderAscending;
            await GetItems();
        }
    }

    public async Task OrderByReciever()
    {
        if (itemOrder == ItemOrderEnum.RecieverAscending)
        {
            FlipOrder();
            await GetItems();
        }
        else
        {
            itemOrder = ItemOrderEnum.RecieverAscending;
            await GetItems();
        }
    }

    public async Task OrderByAmount()
    {
        if (itemOrder == ItemOrderEnum.AmountAscending)
        {
            FlipOrder();
            await GetItems();
        }
        else
        {
            itemOrder = ItemOrderEnum.AmountAscending;
            await GetItems();
        }
    }

    public async Task OrderByTransactionDate()
    {
        if (itemOrder == ItemOrderEnum.TransactionDateAscending)
        {
            FlipOrder();
            await GetItems();
        }
        else
        {
            itemOrder = ItemOrderEnum.TransactionDateAscending;
            await GetItems();
        }
    }

    public async Task OrderByInOut()
    {
        if (itemOrder == ItemOrderEnum.InOutAscending)
        {
            FlipOrder();
            await GetItems();
        }
        else
        {
            itemOrder = ItemOrderEnum.InOutAscending;
            await GetItems();
        }
    }

    public void ModifyItem(Item item)
    {
        var parameters = new ModalParameters();
        parameters.Add("item", item);
        modalService.Show<ModifyItemModal>(localization.localizations.Modify, parameters);
        modalService.OnClose += ModifyItemModalClosed;
    }

    public void ModifyItemModalClosed(ModalResult result)
    {
        GetItems();
        this.StateHasChanged();

        modalService.OnClose -= ModifyItemModalClosed;
    }

    public void FlipOrder()
    {
        switch (itemOrder)
        {
            case ItemOrderEnum.SenderAscending:
                itemOrder = ItemOrderEnum.SenderDescending;
                break;
            case ItemOrderEnum.RecieverAscending:
                itemOrder = ItemOrderEnum.RecieverDescending;
                break;
            case ItemOrderEnum.AmountAscending:
                itemOrder = ItemOrderEnum.AmountDescending;
                break;
            case ItemOrderEnum.TransactionDateAscending:
                itemOrder = ItemOrderEnum.TransactionDateDescending;
                break;
            case ItemOrderEnum.InOutAscending:
                itemOrder = ItemOrderEnum.InOutDescending;
                break;
            case ItemOrderEnum.SenderDescending:
                itemOrder = ItemOrderEnum.SenderAscending;
                break;
            case ItemOrderEnum.RecieverDescending:
                itemOrder = ItemOrderEnum.RecieverAscending;
                break;
            case ItemOrderEnum.AmountDescending:
                itemOrder = ItemOrderEnum.AmountAscending;
                break;
            case ItemOrderEnum.TransactionDateDescending:
                itemOrder = ItemOrderEnum.TransactionDateAscending;
                break;
            case ItemOrderEnum.InOutDescending:
                itemOrder = ItemOrderEnum.InOutAscending;
                break;
            default:
                itemOrder = ItemOrderEnum.TransactionDateDescending;
                break;
        }
    }

    public async Task GetItems()
    {
        items = await itemService.GetItems(caseNumber, itemOrder, searchText);
    }

    public bool IsAddItemValid()
    {
        if (string.IsNullOrWhiteSpace(newItem.Sender))
        {
            return false;
        }
        if (string.IsNullOrWhiteSpace(newItem.Reciever))
        {
            return false;
        }
        if (!isInOutButtonGroupClicked)
        {
            return false;
        }
        return true;
    }

    public async Task CreateItem()
    {
        isAddItemClicked = true;

        if (IsAddItemValid())
        {
            await itemService.CreateItem(newItem);
            await GetItems();
        }
    }

    public async Task DeleteItem(long id)
    {
        await itemService.DeleteItem(id);
        await GetItems();
    }

    public async Task DeleteAllItems()
    {
        if (deleteAllItemsCounter >= 1)
        {
            deleteAllItemsCounter--;
            return;
        }
        deleteAllItemsCounter = 10;
        await itemService.DeleteAllItems(_case.CaseNumber);
        await GetItems();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CaseService caseService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ItemService itemService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalizationService localization { get; set; }
    }
}
#pragma warning restore 1591
