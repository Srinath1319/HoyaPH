using HoyaPH.ViewModels;

namespace HoyaPH.Views;

public partial class DashboardPage : ContentPage
{
    

    public DashboardPage(DashboardPageViewModel dashboardPageViewModel)
	{
		InitializeComponent();
		BindingContext = dashboardPageViewModel;
        
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        ((DashboardPageViewModel)(BindingContext)).getDashboardDetails();

    }
}