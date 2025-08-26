using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace ShopHRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]   // This property can receive a value from the parent component.
        public Employee Employee { get; set; } = default!; 
    }
}
