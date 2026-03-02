namespace BlazorAppFirstWithMacDemo.Components.Pages;

public partial class Parent
{
    private string parentMessage = "Hello from Parent";
    private int count = 0;
    private string childResponse = string.Empty;

    private void UpdateData()
    {
        StateHasChanged();
    }

    private void HandleChildEvent(string message)
    {
        childResponse = message;
        StateHasChanged();
    }
}
