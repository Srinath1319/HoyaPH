
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using HoyaPH.Models;
using HoyaPH.Repository;
using HoyaPH.Services;
using HoyaPH.Test;
using HoyaPH.Utils;
using HoyaPH.Views;
using Refit;
using System.Collections.ObjectModel;

namespace HoyaPH.ViewModels
{
    public partial class DashboardPageViewModel : BaseViewModel
    {  
        [ObservableProperty]
        string points;

        [ObservableProperty]
        string name;

        [ObservableProperty]
        string role;

        [ObservableProperty]
        string membershipId;

        

        public ObservableCollection<string> imageUrl = new ObservableCollection<string>();

        public ObservableCollection<string> ImageUrl
        {
            get => imageUrl;
            set => SetProperty(ref imageUrl, value);
        }

        [RelayCommand]
        public void MyEarningTapped() { 
            App.Current.MainPage.Navigation.PushAsync(new MyEarningPage(),true);
        }


        [RelayCommand]
        public async void getDashboardDetails()
        {
            LoadingDialog.getInstance().showDialog(App.Current.MainPage);
            DashboardRequest dashboardRequest = new DashboardRequest { ActorId = AppController.getInstance().getLoginDetails().userList[0].userId };

            var dashboardResponse = await apiRepository.getDashboardDetailsR(dashboardRequest);

            OffersRequest offersRequest = new OffersRequest { ActionType = 99, ActorId = AppController.getInstance().getLoginDetails().userList[0].userId, PromotionUserType = "HOYA" };

            var offersResponse = await apiRepository.getOffersR(offersRequest);

            Points = dashboardResponse.objCustomerDashboardList[0].overAllPoints.ToString();
            Name = "Hi, " + dashboardResponse.lstCustomerFeedBackJsonApi[0].firstName.ToString() + dashboardResponse.lstCustomerFeedBackJsonApi[0].lastName.ToString();
            Role = dashboardResponse.lstCustomerFeedBackJsonApi[0].customerType.ToString();
            MembershipId = dashboardResponse.lstCustomerFeedBackJsonApi[0].loyaltyId.ToString();

            AppController.getInstance().setDashboardDetails(dashboardResponse);

            for (int i = 0; i < offersResponse.lstPromotionJsonList.Length; i++)
            {
                ImageUrl.Add(Constants.PROMO_IMAGE_BASE+offersResponse.lstPromotionJsonList[i].proImage);
            }

            LoadingDialog.getInstance().hideDialog();






        }
    }
}
