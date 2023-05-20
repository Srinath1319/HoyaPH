using HoyaPH.ViewModels;

namespace HoyaPH.Views;

public partial class MyEarningPage : ContentPage
{

	MyEarningViewModel viewModel = new MyEarningViewModel();
    
    public MyEarningPage()
	{
		
		
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		viewModel.getMyEarningDetails();
        
        BindingContext = viewModel;
        InitializeComponent();


    }

    private void IB_clicked(object sender, EventArgs e)
    {
        viewModel.OnFilterClicked();
    }
}