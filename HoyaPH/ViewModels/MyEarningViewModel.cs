using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Alerts;
using HoyaPH.Models;
using HoyaPH.Test;
using HoyaPH.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoyaPH.ViewModels
{
    public partial class MyEarningViewModel:BaseViewModel
    {
        [ObservableProperty]
        public ObservableCollection<Customerbasicinfolistjson> customerbasicinfolistjsons = new ObservableCollection<Customerbasicinfolistjson>();

        
        public async void getMyEarningDetails() {

            //LoadingDialog.getInstance().showDialog(App.Current.MainPage);
            MyEarningRequest myEarningRequest = new MyEarningRequest { 
                ActionType = 7,
                ActiveStatus = 1,
                FromDate = "",
                ToDate = "",
                ProgramID = "-1",
                SalesPersonId = AppController.getInstance().getDashboardDetails().lstCustomerFeedBackJsonApi[0].loyaltyId
            
            };

            var myEarningResponse = await apiRepository.getMyEarningsR(myEarningRequest);
            //LoadingDialog.getInstance().hideDialog();
            
            for (int i = 0; i < myEarningResponse.customerBasicInfoListJson.Length; i++)
            {

                if (myEarningResponse.customerBasicInfoListJson[i].trxnDate != null)
                {
                    myEarningResponse.customerBasicInfoListJson[i].trxnDate = myEarningResponse.customerBasicInfoListJson[i].trxnDate.Split(" ")[0];
                }
                if (myEarningResponse.customerBasicInfoListJson[i].pointExpiryDate != null)
                {
                    myEarningResponse.customerBasicInfoListJson[i].pointExpiryDate = myEarningResponse.customerBasicInfoListJson[i].pointExpiryDate.Split(" ")[0];
                }
                Customerbasicinfolistjsons.Add(myEarningResponse.customerBasicInfoListJson[i]);
                
            }
            
        
        }


        [RelayCommand]
        public void OnFilterClicked()
        {
            Console.WriteLine(" click this ImageButton2 ");
            FilterDialog.getInstance().showDialog(App.Current.MainPage);
        }
    }
}
