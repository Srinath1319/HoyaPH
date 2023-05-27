using HoyaPH.ViewModel;
using HoyaPH.Views;

namespace HoyaPH;

public partial class MainPage : ContentPage
{
	
    MainPageViewModel viewModel = new MainPageViewModel();

	public MainPage()
	{
        
        BindingContext = viewModel;
        InitializeComponent();
       


    }

    protected override bool OnBackButtonPressed()
    {

        if (viewModel.OnBackPressed())
        {

            viewModel.OnBackPressed();
            
            return true;
        }
        else {
            
            return base.OnBackButtonPressed();

        }
        


    }

}

