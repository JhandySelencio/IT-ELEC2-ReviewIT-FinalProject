using ReviewIT.Modules;

namespace ReviewIT
{
    public partial class MainPage : ContentPage
    {
        private List<Questions> setofQnA;

        public MainPage(string username)
        {
            InitializeComponent();
            getUser.Text = "Hello " + username + ", Welcome to ReviewIT!";
        }

        private async void GoToCreateQuestions(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateQnA());
        }

        private async void GoToYourLibrary(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LibraryPage());
        }
    }
}
