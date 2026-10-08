namespace Monitoring_pkl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object? sender, EventArgs e)
        {
            MessageLabel.IsVisible = false;

            var username = UsernameEntry.Text?.Trim();
            var password = PasswordEntry.Text ?? string.Empty;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageLabel.Text = "Enter username and password.";
                MessageLabel.IsVisible = true;
                return;
            }

            // Simple demo validation — replace with real authentication
            if (username == "admin" && password == "password")
            {
                await DisplayAlert("Success", "Login successful.", "OK");
                // TODO: navigate to the app main page
            }
            else
            {
                MessageLabel.Text = "Invalid username or password.";
                MessageLabel.IsVisible = true;
            }
        }
    }
}
