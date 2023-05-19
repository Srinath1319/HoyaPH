using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HoyaPH.Model;
using HoyaPH.Models;
using HoyaPH.Repository;
using HoyaPH.Services;
using HoyaPH.Test;
using HoyaPH.ViewModels;
using HoyaPH.Views;
using Newtonsoft.Json;
using Refit;

namespace HoyaPH.ViewModel
{
    public partial class MainPageViewModel : BaseViewModel

    {


        [ObservableProperty]
        string text;

        [ObservableProperty]
        string otp;

        [ObservableProperty]
        string btnText = "Get OTP";

        [ObservableProperty]
        Boolean visiblity;

        [ObservableProperty]
        Boolean enableMembershipID = true;

        //Popup popup = new Popup();

        [RelayCommand]
        public async void CheckExistancy()
        {

            if (BtnText.Equals("Get OTP"))
            {

                if (string.IsNullOrEmpty(Text))
                {

                    await Snackbar.Make("Please enter MembershipID / MobileNumber!", actionButtonText: "", visualOptions: new CommunityToolkit.Maui.Core.SnackbarOptions { BackgroundColor = Colors.Red }).Show();


                }
                else
                {
                    LoadingDialog.getInstance().showDialog(App.Current.MainPage);



                    ExistancyRequest existancyRequest = new ExistancyRequest
                    {

                        ActionType = "57",
                        Location = new Model.Location
                        {
                            UserName = Text
                        }
                    };



                    var response = await apiRepository.getExistancyR(existancyRequest);
                    LoadingDialog.getInstance().hideDialog();


                    if (response == 1)
                    {
                        EnableMembershipID = false;
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
                else if (!Otp.Equals("123456"))
                {

                    await Snackbar.Make("Please enter valid OTP!", actionButtonText: "", visualOptions: new CommunityToolkit.Maui.Core.SnackbarOptions { BackgroundColor = Colors.Red }).Show();


                }

                else
                {
                    LoadingDialog.getInstance().showDialog(App.Current.MainPage);
                    LoginRequest loginRequest = new LoginRequest
                    {

                        UserActionType = "GetPasswordDetails",
                        Browser = "Android",
                        LoggedDeviceName = "Android",
                        Password = Otp,
                        UserName = Text,
                        UserType = "Customer",
                        SessionId = "HOYA"
                    };

                    var loginResponse = await apiRepository.getLoginDetailsR(loginRequest);
                    LoadingDialog.getInstance().hideDialog();
                    if (loginResponse.userList[0].result != -1)
                    {

                        AppController.getInstance().setLoginDetails(loginResponse);



                        await Application.Current.MainPage.Navigation.PushAsync(new DashboardPage());

                    }
                    else
                    {

                        await Snackbar.Make("Please enter valid OTP!", actionButtonText: "", visualOptions: new CommunityToolkit.Maui.Core.SnackbarOptions { BackgroundColor = Colors.Red }).Show();
                    }




                }



            }



        }


        public bool OnBackPressed()
        {

            if (Visiblity)
            {
                EnableMembershipID = true;
                Visiblity = false;
                BtnText = "Get OTP";
                return true;
            }
            else
            {

                return false;
            }
        }

    }
}
