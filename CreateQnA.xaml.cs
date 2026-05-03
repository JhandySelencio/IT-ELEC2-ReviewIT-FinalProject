using ReviewIT.Modules;

namespace ReviewIT;

public partial class CreateQnA : ContentPage
{
    public CreateQnA()
	{
		InitializeComponent();
        
	}

    //Method to create the questions!
    private async void OnCreateQuestions(object sender, EventArgs e)
    {
		if (string.IsNullOrEmpty(getQuestion.Text) || string.IsNullOrEmpty(getAnswer.Text))
		{
			await DisplayAlert("Error", "Please enter missing fields in order to continue", "OK");
			return;
		}

        Questions newQnA = new Questions
        {
            question = getQuestion.Text,
            answer = getAnswer.Text
        };

        AppData.ListOfQnA.Add(newQnA);
        await DisplayAlert("Success", "You've successfully created a questionnaire!", "OK");

        getQuestion.Text = "";
        getAnswer.Text = "";
        
    }

    private async void GoToLibrary(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new LibraryPage());
    }
}