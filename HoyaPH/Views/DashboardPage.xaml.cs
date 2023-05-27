using CommunityToolkit.Maui.Behaviors;
using HoyaPH.ViewModels;

namespace HoyaPH.Views;

public partial class DashboardPage : ContentPage
{

    DashboardPageViewModel  viewModel = new DashboardPageViewModel();
    

    public DashboardPage()
	{
		InitializeComponent();
		BindingContext = viewModel;

        

        Loaded += (_, __) =>
        {
            this.notification.Behaviors.Add(new IconTintColorBehavior()
            {
                TintColor = Colors.White
            });

            this.logout.Behaviors.Add(new IconTintColorBehavior()
            {
                TintColor = Colors.White
            });

            this.home.Behaviors.Add(new IconTintColorBehavior()
            {
                TintColor = Colors.White
            });

            this.Support.Behaviors.Add(new IconTintColorBehavior()
            {
                TintColor = Colors.White
            });

            this.Profile.Behaviors.Add(new IconTintColorBehavior()
            {
                TintColor = Colors.White
            });
        };
        
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.getDashboardDetails();

    }
}