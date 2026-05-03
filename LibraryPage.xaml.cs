using System.Threading.Tasks;
using ReviewIT.Modules;

namespace ReviewIT;

public partial class LibraryPage : ContentPage
{
	public LibraryPage()
	{
		InitializeComponent();
        displayLibrary.ItemsSource = "";
        displayLibrary.ItemsSource = AppData.ListOfQnA;
    }

    private async void OnReturn(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}