using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HoyaPH.Model;
using HoyaPH.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoyaPH.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        ApiRepository apiRepository;

        public MainPageViewModel(ApiRepository apiRepository)
        {
            this.apiRepository = apiRepository;

        }

        [ObservableProperty]
        string text;

        
        [RelayCommand]
        public async void CheckExistancy()
        {

            ExistancyRequest existancyRequest = new ExistancyRequest
            {

                ActionType = "57",
                Location = new Model.Location
                {
                    UserName = Text
                }
            };
            var response = await apiRepository.getExistancyR(existancyRequest);
            Console.WriteLine("RESPONSE_CHECK" + response);
            
        }

        
    }
}
