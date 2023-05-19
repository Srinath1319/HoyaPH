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
    [Headers("Authorization: Bearer")]
    public interface ApiInterface
    {
        [Post("/CheckCustomerExistancyAndVerification")]
        public Task<int> getExistancy([Body] ExistancyRequest existancyRequest);

        [Post("/CheckIsAuthenticatedMobileApp")]
        public Task<LoginResponse> getLoginDetails([Body] LoginRequest loginRequest);

        [Post("/GetDashBoardDetailsApi")]
        public Task<DashboardResponse> getDashboardDetails([Body] DashboardRequest dashboardRequest);

        [Post("/GetPromotionDetailsMobileApp")]
        public Task<OffersResponse> getOffers([Body] OffersRequest offersRequest);

        [Post("/BindAssessmentRequestDetails")]
        public Task<MyEarningResponse> getMyEarnings([Body] MyEarningRequest myEarningRequest);
    }
}
