#pragma checksum "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\Pages\Employees\Employees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c4e95f3e6a7eb3f259396686bd8d0ba8a68abf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BethanysPieShopHRM.Pages.Employees
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM.Infrastructure;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employees")]
    public partial class Employees : OwningComponentBase<ApplicationDbContext>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\Pages\Employees\Employees.razor"
      
    ApplicationDbContext _db => Service;
    [Inject] public IJSRuntime _js { get; set; }

    [Parameter] public bool IsSelection { get; set; }
    [Parameter] public EventCallback<Employee> SelectionCallBack { get; set; }

    private List<Employee> _items { get; set; }
    private List<Employee> _filteredItems { get; set; }

    private string searchTerm;
    public string _searchTerm
    {
        get { return searchTerm; }
        set
        {
            searchTerm = value;
            _filteredItems = _items.Where(x =>
                string.IsNullOrWhiteSpace(searchTerm) ||
                x.FirstName.ToLower().Contains(searchTerm) ||
                x.LastName.ToLower().Contains(searchTerm)
            ).ToList();
        }
    }

    private BethanysPieShopHRM.Pages.Employees.EmployeeAddEdit _employeeAddEdit;
    private BethanysPieShopHRM.Pages.Employees.EmployeeDetail _employeeDetail;

    protected override async Task OnInitializedAsync()
    {
        IsSelection = false;
        _items = await _db.Employees.ToListAsync();
        _filteredItems = _items;
        //AddEmployeeDialog.OnDialogClose += AddEmployeeDialog_OnDialogClose;
    }

    #region components
    private void showAddEdit(Employee item = null)
    {
        _employeeAddEdit.Show(item);
    }
    private async Task showDetail(Employee item)
    {
        await _employeeDetail.Show(item);
    }
    #endregion components

    protected async Task delete(Employee item)
    {
        bool confirmed = await _js.InvokeAsync<bool>("confirm", "Are you sure?");
        if (confirmed)
        {
            try
            {
                _db.Employees.Remove(item);
                await _db.SaveChangesAsync();

                await _js.InvokeVoidAsync("alert", "Saved!");

                await loadAsync();

            }
            catch (Exception)
            {
                await _js.InvokeVoidAsync("alert", "Error Saving Data!!!");
            }
        }
    }

    private async Task select(Employee selectedItem)
    {
        await SelectionCallBack.InvokeAsync(selectedItem);
        StateHasChanged();
    }

    private async Task OnAddEditClose()
    {
        await loadAsync();
    }

    private async Task loadAsync()
    {
        _items = await _db.Employees.ToListAsync();
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
