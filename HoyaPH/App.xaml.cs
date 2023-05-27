using HoyaPH.Test;
using HoyaPH.Utils;
using HoyaPH.Views;

namespace HoyaPH;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        if (Preferences.Get(Constants.IS_LOGGED_IN, "default") == "TRUE")
        {
            MainPage = new NavigationPage(new DashboardPage());

        }
        else {
            MainPage = new NavigationPage(new MainPage());
        }



    }
}
