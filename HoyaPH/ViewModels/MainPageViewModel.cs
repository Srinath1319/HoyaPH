using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HoyaPH.Model;
using HoyaPH.Repository;
using HoyaPH.Views;

namespace HoyaPH.ViewModel
{
    public partial class MainPageViewModel : ObservableObject

    {
        ApiRepository apiRepository;
        ActivityIndicator activityIndicator = new ActivityIndicator();

        public MainPageViewModel(ApiRepository apiRepository)
        {
            this.apiRepository = apiRepository;

        }

        [ObservableProperty]
        string text;

        [ObservableProperty]
        string otp;

        [ObservableProperty]
        string btnText = "Get OTP";

        [ObservableProperty]
        Boolean visiblity;

        public INavigation Navigation { get; internal set; }

        [RelayCommand]
        public async void CheckExistancy()
        {

            if (BtnText.Equals("Get OTP"))
            {

                if (string.IsNullOrEmpty(Text))
                {

                    await Snackbar.Make("Please enter MembershipID / MobileNumber!", actionButtonText: "",visualOptions: new CommunityToolkit.Maui.Core.SnackbarOptions { BackgroundColor = Colors.Red}).Show();


                }
                else
                {
                    activityIndicator.IsRunning = true;
                    
                    ExistancyRequest existancyRequest = new ExistancyRequest
                    {

                        ActionType = "57",
                        Location = new Model.Location
                        {
                            UserName = Text
                        }
                    };



                    var response = await apiRepository.getExistancyR(existancyRequest);
                    //activityIndicator.IsRunning = false;
                    Console.WriteLine("RESPONSE_CHECK" + response);

                    if (response == 1)
                    {

                        Visiblity = true;
                        BtnText = "Submit";
                    }
                    else
                    {
                        await Snackbar.Make("MembershipID / MobileNo doesn't exist!", actionButtonText: "", visualOptions: new CommunityToolkit.Maui.Core.SnackbarOptions { BackgroundColor = Colors.Red }).Show();
                        Visiblity = false;
                        BtnText = "Get OTP";
                    }
                }



            }
            else if (BtnText.Equals("Submit"))
            {

                if (string.IsNullOrEmpty(Otp))
                {

                    await Snackbar.Make("Please enter OTP!", actionButtonText: "", visualOptions: new CommunityToolkit.Maui.Core.SnackbarOptions { BackgroundColor = Colors.Red }).Show();


                }
                else if (Otp.Length < 6)
                {

                    await Snackbar.Make("Please enter valid OTP!", actionButtonText: "", visualOptions: new CommunityToolkit.Maui.Core.SnackbarOptions { BackgroundColor = Colors.Red }).Show();


                }

                else if (Otp.Equals("123456"))
                {

                    await Navigation.PushAsync(new DashboardPage());

                }



            }



        }


    }
}
