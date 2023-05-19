using HoyaPH.ViewModels;

namespace HoyaPH.Views;

public partial class MyEarningPage : ContentPage
{

	MyEarningViewModel viewModel = new MyEarningViewModel();
    
    public MyEarningPage()
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		viewModel.getMyEarningDetails();

        
    }
}