using BethanysPieShopHRM.Shared.Domain;

namespace ShopHRM.Pages
{
    //It's a partial class to accompany the EmployeeOverview.razor file.
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;

        private Employee? _selectedEmployee;

        protected override void OnInitialized()
        {
            Employees = Models.MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
