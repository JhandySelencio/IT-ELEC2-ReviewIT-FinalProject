namespace ReviewIT;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void onClickLogin(object sender, EventArgs e)
    {
		string username = getUser.Text;

		if (string.IsNullOrEmpty(getUser.Text) || string.IsNullOrEmpty(getPass.Text))
		{
			await DisplayAlert("Error", "Please enter the missing fields", "OK");
			return;
		}

		await DisplayAlert("Success", "You've successfully logged in!", "OK");
		await Navigation.PushAsync(new MainPage(username));

    }
}