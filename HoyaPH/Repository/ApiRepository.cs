using HoyaPH.Model;
using HoyaPH.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoyaPH.Repository
{
    public class ApiRepository : BaseRepository
    {
        ApiInterface apiInterface;
        public ApiRepository(ApiInterface apiInterface) : base(apiInterface)
        {
            this.apiInterface = apiInterface;
        }

        public async Task<int> getExistancyR(ExistancyRequest existancyRequest)
        {
            return await ApiCall(async () => await apiInterface.getExistancy(existancyRequest));
        }
    }
}
