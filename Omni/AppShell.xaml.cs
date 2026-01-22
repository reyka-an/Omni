using Omni.Pages;

namespace Omni;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("todo", typeof(ToDoPage));
        Routing.RegisterRoute("tracktime", typeof(TrackTimePage));
        Routing.RegisterRoute("movielist", typeof(MovieListPage));
        Routing.RegisterRoute("calories", typeof(CaloriesPage));
    }
}