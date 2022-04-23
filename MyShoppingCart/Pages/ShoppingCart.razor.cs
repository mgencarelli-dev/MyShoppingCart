using Microsoft.AspNetCore.Components;

namespace MyShoppingCart.Pages
{
    public partial class ShoppingCart : ComponentBase
    {
        private int NumApples { get; set; } = 0;
        private int NumBananas { get; set; } = 0;
        private int NumOranges { get; set; } = 0;

        private void AddApple()
        {
            NumApples++;
        }
        private void AddBanana()
        {
            NumBananas++;
        }
        private void AddOrange()
        {
            NumOranges++;
        }
    }
}
