using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using ShopHRM.Models;

namespace ShopHRM.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }

        public Employee? Employee { get; set; } = new Employee();

        // This method would typically fetch employee details of single from a MockDataService
        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));
            return base.OnInitializedAsync();
        }
    }
}
