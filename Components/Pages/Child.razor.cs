using Microsoft.AspNetCore.Components;

namespace BlazorAppFirstWithMacDemo.Components.Pages;

public partial class Child
{
    [Parameter]
    public string Message { get; set; } = string.Empty;

    [Parameter]
    public int Count { get; set; }

    [Parameter]
    public EventCallback<string> OnChildEvent { get; set; }

    private async Task SendToParent()
    {
        await OnChildEvent.InvokeAsync($"Child received: '{Message}' with count {Count}");
    }
}
