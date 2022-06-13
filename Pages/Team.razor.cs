using Microsoft.AspNetCore.Components;

namespace Amsthetic.Pages
{
    public partial class Team : ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}