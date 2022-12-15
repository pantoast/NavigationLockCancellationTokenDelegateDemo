A demonstration of how NavigationLock's OnBeforeInternalNavigation CancellationToken does not behave as expected.

NavigationLock component is inside of BlazorTesting.Client/Pages/Counter.razor. Navigating to the counter page and away will call the delegate registered against the cancellation token.
