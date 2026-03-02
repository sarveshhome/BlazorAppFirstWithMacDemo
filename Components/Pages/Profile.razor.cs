namespace BlazorAppFirstWithMacDemo.Components.Pages;

public partial class Profile
{
    private ProfileModel profile = new();
    private string message = string.Empty;
    private bool showPreview = false;

    private void HandleSubmit()
    {
        message = "Profile saved successfully!";
        showPreview = true;
        StateHasChanged();
    }

    private void ResetForm()
    {
        profile = new ProfileModel();
        message = string.Empty;
        showPreview = false;
    }

    private string MaskCard(string? card)
    {
        if (string.IsNullOrEmpty(card) || card.Length < 4)
            return "****";
        return "**** **** **** " + card.Substring(card.Length - 4);
    }

    public class ProfileModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string CreditCard { get; set; } = string.Empty;
        public bool IsCorporate { get; set; }
        public string CorporateCreditCard { get; set; } = string.Empty;
    }
}
