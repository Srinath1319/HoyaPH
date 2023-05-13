using HoyaPH.ViewModel;
using HoyaPH.Views;

namespace HoyaPH;

public partial class MainPage : ContentPage
{
	
    MainPageViewModel viewModel = new MainPageViewModel();

	public MainPage(MainPageViewModel mainPageViewModel)
	{
        mainPageViewModel.Navigation = Navigation;
        BindingContext = mainPageViewModel;
        InitializeComponent();
       


    }

    protected override bool OnBackButtonPressed()
    {

        if (((MainPageViewModel)(BindingContext)).OnBackPressed())
        {

            ((MainPageViewModel)(BindingContext)).OnBackPressed();
            Preferences.Clear();
            return true;
        }
        else {
            Preferences.Clear();
            return base.OnBackButtonPressed();

        }
        


    }

}

