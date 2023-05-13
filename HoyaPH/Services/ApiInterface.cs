using HoyaPH.Model;
using HoyaPH.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoyaPH.Services
{
    public interface ApiInterface
    {
        [Headers("Content-Type: application/x-www-form-urlencoded")]
        [Post("/token")]
        public Task<TokenResponse> getToken([Body(BodySerializationMethod.UrlEncoded)] FormUrlEncodedContent TokenRequest);



        [Post("/Mobile/CheckCustomerExistancyAndVerification")]
        public Task<int> getExistancy([Body] ExistancyRequest existancyRequest);

        [Post("/Mobile/CheckIsAuthenticatedMobileApp")]
        public Task<LoginResponse> getLoginDetails([Body] LoginRequest loginRequest);

        [Post("/Mobile/GetDashBoardDetailsApi")]
        public Task<DashboardResponse> getDashboardDetails([Body] DashboardRequest dashboardRequest);

        [Post("/Mobile/GetPromotionDetailsMobileApp")]
        public Task<OffersResponse> getOffers([Body] OffersRequest offersRequest);
    }
}
