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

	/*public void OnClicked(object sender, EventArgs e)
	{
        
		Navigation.PushAsync(new DashboardPage());
	}*/

    
}

