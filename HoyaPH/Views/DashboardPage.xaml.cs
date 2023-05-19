using HoyaPH.ViewModels;

namespace HoyaPH.Views;

public partial class DashboardPage : ContentPage
{

    DashboardPageViewModel  viewModel = new DashboardPageViewModel();
    

    public DashboardPage()
	{
		InitializeComponent();
		BindingContext = viewModel;
        
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.getDashboardDetails();

    }
}