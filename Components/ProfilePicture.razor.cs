using Microsoft.AspNetCore.Components;

namespace ShopHRM.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; } // This allows you to pass in custom content to the component
    }
}
