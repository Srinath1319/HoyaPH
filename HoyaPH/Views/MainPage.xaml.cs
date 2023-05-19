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
            Preferences.Clear();
            return true;
        }
        else {
            Preferences.Clear();
            return base.OnBackButtonPressed();

        }
        


    }

}

