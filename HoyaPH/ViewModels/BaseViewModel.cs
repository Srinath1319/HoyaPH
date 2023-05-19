using CommunityToolkit.Mvvm.ComponentModel;
using HoyaPH.Repository;
using HoyaPH.Services;
using HoyaPH.Utils;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoyaPH.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        public ApiRepository apiRepository = new ApiRepository(RestService.For<ApiInterface>(new HttpClient(new AuthHeader())
        {
            BaseAddress = new Uri(Constants.BASE_URL)

        }));
    }
}
