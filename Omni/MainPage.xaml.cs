namespace Omni;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnToDoClicked(object sender, EventArgs e)
        => await Shell.Current.GoToAsync("todo");

    private async void OnTrackTimeClicked(object sender, EventArgs e)
        => await Shell.Current.GoToAsync("tracktime");

    private async void OnMovieListClicked(object sender, EventArgs e)
        => await Shell.Current.GoToAsync("movielist");

    private async void OnCaloriesClicked(object sender, EventArgs e)
        => await Shell.Current.GoToAsync("calories");
}