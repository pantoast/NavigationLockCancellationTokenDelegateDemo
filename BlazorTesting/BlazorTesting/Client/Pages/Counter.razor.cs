using Microsoft.AspNetCore.Components.Routing;

namespace BlazorTesting.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }

        public void OnBeforeInternalNavigation(LocationChangingContext context)
        {
            context.CancellationToken.Register(() =>
            {
                Console.WriteLine("NAV CANCELED");
            });
        }
    }
}
