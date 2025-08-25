using BethanysPieShopHRM.Shared.Domain;

namespace ShopHRM.Pages
{
    //It's a partial class to accompany the EmployeeOverview.razor file.
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;

        protected override void OnInitialized()
        {
            Employees = Models.MockDataService.Employees;
        }
    }
}
