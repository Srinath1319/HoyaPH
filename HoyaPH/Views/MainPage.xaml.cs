using HoyaPH.ViewModel;
using HoyaPH.Views;

namespace HoyaPH;

public partial class MainPage : ContentPage
{
	

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
            return true;
        }
        else {
            return base.OnBackButtonPressed();
        }
        
        
    }

}

