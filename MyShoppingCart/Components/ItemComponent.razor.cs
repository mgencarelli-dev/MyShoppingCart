using Microsoft.AspNetCore.Components;

namespace MyShoppingCart.Components
{
    public partial class ItemComponent : ComponentBase
    {
        [Parameter]
        public string Name { get; set; } = "";

        [Parameter]
        public int Count { get; set; } = 0;
    }
}
