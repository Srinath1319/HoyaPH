using CommunityToolkit.Mvvm.ComponentModel;
using HoyaPH.Models;
using HoyaPH.Test;
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
        public List<Customerbasicinfolistjson> customerbasicinfolistjsons = new List<Customerbasicinfolistjson>();

        



        /*public ObservableCollection<Customerbasicinfolistjson> Customerbasicinfolistjsons
        {
            get => customerbasicinfolistjsons;
            set => SetProperty(ref customerbasicinfolistjsons, value);
        }*/
        public async void getMyEarningDetails() {

            LoadingDialog.getInstance().showDialog(App.Current.MainPage);
            MyEarningRequest myEarningRequest = new MyEarningRequest { 
                ActionType = 7,
                ActiveStatus = 1,
                FromDate = "",
                ToDate = "",
                ProgramID = "-1",
                SalesPersonId = AppController.getInstance().getDashboardDetails().lstCustomerFeedBackJsonApi[0].loyaltyId
            
            };

            var myEarningResponse = await apiRepository.getMyEarningsR(myEarningRequest);
            LoadingDialog.getInstance().hideDialog();

            for(int i = 0; i < myEarningResponse.customerBasicInfoListJson.Length; i++)
            {

                Customerbasicinfolistjsons.Add(myEarningResponse.customerBasicInfoListJson[i]);
                
            }
            
        
        }
    }
}
