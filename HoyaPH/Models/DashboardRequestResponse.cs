using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HoyaPH.Models
{
    public class DashboardRequest
    {
        public int ActorId { get; set; }
    }



    public class DashboardResponse
    {
        public object objCustomerDashboardMenuList { get; set; }
        public Objcustomerdashboardlist[] objCustomerDashboardList { get; set; }
        public object objActivityDetailsList { get; set; }
        public Objactivitydetailsjsonlist[] objActivityDetailsJsonList { get; set; }
        public object objGamificationTransaction { get; set; }
        public object lstUserDashboardDetails { get; set; }
        public Lstpromotionlistjsonapi[] lstPromotionListJsonApi { get; set; }
        public Lstcustomerfeedbackjsonapi[] lstCustomerFeedBackJsonApi { get; set; }
        public Lstloyaltyprogramreport[] lstLoyaltyProgramReport { get; set; }
        public object objImageGalleryList { get; set; }
        public object objCatalogueDetailsForCustomer { get; set; }
        public bool activeStatus { get; set; }
        public object objProductList { get; set; }
        public string sessionID { get; set; }
        public object deviceID { get; set; }
        public string loggedDeviceName { get; set; }
        public int returnValue { get; set; }
        public object returnMessage { get; set; }
        public int totalRecords { get; set; }
    }

    public class Objcustomerdashboardlist
    {
        public object monthName { get; set; }
        public object yearName { get; set; }
        public object previousYearMonthName { get; set; }
        public object priviousYearName { get; set; }
        public int priviousYearPoint { get; set; }
        public int totalEarnedPoints { get; set; }
        public int payBackPoints { get; set; }
        public int totalMileStonePoints { get; set; }
        public float currentPointBalance { get; set; }
        public float multiplierPointBalance { get; set; }
        public object profileImage { get; set; }
        public object qR_Code { get; set; }
        public string memberSince { get; set; }
        public int messageCount { get; set; }
        public int warningCount { get; set; }
        public int redeemPoints { get; set; }
        public float totalRedeemed { get; set; }
        public float customerTotalPoint { get; set; }
        public int giftEvoucherCount { get; set; }
        public int giftDonateCount { get; set; }
        public object objPromotionCommonList { get; set; }
        public object objActivityDetailsList { get; set; }
        public int giftingEvoucherCount { get; set; }
        public float redeemablePointsBalance { get; set; }
        public int redeemableEncashBalance { get; set; }
        public object customerType { get; set; }
        public int notificationCount { get; set; }
        public object programBehaviour { get; set; }
        public int behaviourWisePoints { get; set; }
        public int programBehaviourId { get; set; }
        public int isNotionalPoints { get; set; }
        public string lifeTimeEarningsOppor { get; set; }
        public string lifeTimeEarningsAchi { get; set; }
        public string lifeTimeEarningsMissed { get; set; }
        public string lifeTimeEarningsDue { get; set; }
        public string lifeTimeEarningsDamages { get; set; }
        public object name { get; set; }
        public int customerCredit { get; set; }
        public object customerGrade { get; set; }
        public int retailerId { get; set; }
        public int customerId { get; set; }
        public int totalRows { get; set; }
        public int identityProofsNotification { get; set; }
        public object mappedType { get; set; }
        public object mappedBalance { get; set; }
        public int overAllPoints { get; set; }
        public int subscriberCount { get; set; }
        public object teirUpgradeMessage { get; set; }
        public int referralCount { get; set; }
        public int pointExpiryCount { get; set; }
        public int referralBonusPoints { get; set; }
        public object nextTeirUpgradeMessage { get; set; }
        public int feedBackSurveyId { get; set; }
        public bool isFeedBackGave { get; set; }
        public int customerOrderStatusId { get; set; }
        public int customerCartCount { get; set; }
        public object behaviourImage { get; set; }
        public object mappedUserName { get; set; }
        public object mappedUserMobile { get; set; }
        public int approvedClaimCount { get; set; }
        public bool customerVerifiedStatus { get; set; }
        public float convertedCurrencyValue { get; set; }
        public int verificationStatus { get; set; }
        public int createdBy { get; set; }
        public object accessedDate { get; set; }
        public object createdDate { get; set; }
        public object bdeUserName { get; set; }
        public object bdeUserMobile { get; set; }
        public bool customerBonusCampaignStatus { get; set; }
        public int customerPendingGamesCount { get; set; }
        public int customerRaffleCount { get; set; }
        public float cashBackEligibility { get; set; }
        public object cashBackType { get; set; }
        public object remarks { get; set; }
        public object totalBrokarage { get; set; }
        public object cashBackEarned { get; set; }
        public int graphYear { get; set; }
        public object graphMonth { get; set; }
        public int sumOfBarChartPoints { get; set; }
        public int sumOfPointsForLineChart { get; set; }
        public int totalWithDrawl { get; set; }
        public int mappedRetailerCount { get; set; }
        public int notionalPointQuarter { get; set; }
        public int customerOrdersCartCount { get; set; }
        public int activeRaffelCount { get; set; }
        public int isReply { get; set; }
        public int totalMappedPlumbers { get; set; }
        public int totalMappedSubDealers { get; set; }
        public int totalMappedCSM { get; set; }
        public float totalEarning { get; set; }
        public int userActionId { get; set; }
        public object userAction { get; set; }
        public int walletBalance { get; set; }
        public object enrollment_Date { get; set; }
        public object memberShipId { get; set; }
        public object mobile { get; set; }
        public object residance_Address { get; set; }
        public object state { get; set; }
        public object city { get; set; }
        public object pincode { get; set; }
        public object kycType { get; set; }
        public object kycDetails { get; set; }
        public object panCardDetails { get; set; }
        public object distributorCode { get; set; }
        public object garageAddress { get; set; }
        public object garageName { get; set; }
        public object agp { get; set; }
        public object imagePath { get; set; }
        public object park { get; set; }
        public object mappedCustomerType { get; set; }
        public int mappedCustomerId { get; set; }
        public object mappedCustomerName { get; set; }
        public object behaviour { get; set; }
        public object part_No { get; set; }
        public object part_Desc { get; set; }
        public object points { get; set; }
        public object token { get; set; }
        public int actorId { get; set; }
        public bool isActive { get; set; }
        public object actorRole { get; set; }
        public int actionType { get; set; }
    }

    public class Objactivitydetailsjsonlist
    {
        public object message { get; set; }
        public string name { get; set; }
        public object activityDate { get; set; }
        public string jActivityDate { get; set; }
        public string type { get; set; }
        public object email { get; set; }
        public object mobile { get; set; }
        public object token { get; set; }
        public int actorId { get; set; }
        public bool isActive { get; set; }
        public object actorRole { get; set; }
        public int actionType { get; set; }
    }

    public class Lstpromotionlistjsonapi
    {
        public string promotionName { get; set; }
        public string proShortDesc { get; set; }
        public string proLongDesc { get; set; }
        public string proImage { get; set; }
        public string footer { get; set; }
        public bool is_Expired { get; set; }
        public bool is_Active { get; set; }
        public int views { get; set; }
        public int totalClaims { get; set; }
        public int promotion_Type { get; set; }
        public int totalViews { get; set; }
        public int totalBlocks { get; set; }
        public bool isReserved { get; set; }
        public bool isClaimed { get; set; }
        public int pushUserActionID { get; set; }
        public int totalResponses { get; set; }
        public bool cliamIdUsageStatus { get; set; }
        public object url { get; set; }
        public object view { get; set; }
        public object claim { get; set; }
        public object reserve { get; set; }
        public object comment { get; set; }
        public object validity { get; set; }
        public int targetCustomers { get; set; }
        public object promotionTypeName { get; set; }
        public object mobileNo { get; set; }
        public object memberId { get; set; }
        public object memberName { get; set; }
        public int totalRecords { get; set; }
        public bool canClaim { get; set; }
        public bool canReverse { get; set; }
        public bool canComment { get; set; }
        public int totalComment { get; set; }
        public object actionUrl { get; set; }
        public int categoryId { get; set; }
        public object categoryName { get; set; }
        public int albumImageID { get; set; }
        public object title { get; set; }
        public object firstName { get; set; }
        public object lastName { get; set; }
        public object fullName { get; set; }
        public int pointBalance { get; set; }
        public bool canView { get; set; }
        public bool allowUnReserve { get; set; }
        public bool isReservable { get; set; }
        public int approvalStatusID { get; set; }
        public object approvalStatus { get; set; }
        public object remarks { get; set; }
        public object emailID { get; set; }
        public bool isApprovable { get; set; }
        public string validFrom { get; set; }
        public string validTo { get; set; }
        public object outletName { get; set; }
        public bool redeemLocationAll { get; set; }
        public int promotionId { get; set; }
    }

    public class Lstcustomerfeedbackjsonapi
    {
        public string customerEmail { get; set; }
        public string merchantname { get; set; }
        public string merchantEmail { get; set; }
        public object merchantMobile { get; set; }
        public int merchantId { get; set; }
        public string customerImage { get; set; }
        public string password { get; set; }
        public string customerMobile { get; set; }
        public object lastActive { get; set; }
        public object prefix { get; set; }
        public string customerType { get; set; }
        public bool allowPlanner { get; set; }
        public int customerTypeId { get; set; }
        public object loyaltyIdQRCode { get; set; }
        public int customerStatus { get; set; }
        public int userId { get; set; }
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string loyaltyId { get; set; }
        public object title { get; set; }
        public object address { get; set; }
        public object designation { get; set; }
        public object company { get; set; }
        public bool present { get; set; }
        public bool tardy { get; set; }
        public object attendanceDate { get; set; }
        public int present_Count { get; set; }
        public int tardy_Count { get; set; }
        public int absent_Count { get; set; }
        public object month_Name { get; set; }
        public int month_No { get; set; }
        public object locationName { get; set; }
        public int encashBalance { get; set; }
        public string customerGrade { get; set; }
        public int languageId { get; set; }
        public object languageName { get; set; }
        public int nativeStateId { get; set; }
        public object nativeStateName { get; set; }
        public object district { get; set; }
        public int locationId { get; set; }
        public int requiredPoints { get; set; }
        public object profilePicture { get; set; }
        public object bonusDate { get; set; }
        public object bonusName { get; set; }
        public object bonusValue { get; set; }
        public object issueDescription { get; set; }
        public object storeName { get; set; }
        public int verifiedStatus { get; set; }
        public int cashBack { get; set; }
        public object verificationStatus { get; set; }
        public int callStatusId { get; set; }
        public object callRemarks { get; set; }
        public int isBlacklisted { get; set; }
        public int isDormant { get; set; }
        public int isOnHold { get; set; }
        public int pinStatus { get; set; }
        public object ownerName { get; set; }
        public object walletNumber { get; set; }
        public string referralCode { get; set; }
        public object insuranceReferanceId { get; set; }
        public object nominee { get; set; }
        public object nomineeDOB { get; set; }
        public object customerRelation { get; set; }
        public string targetAchieved { get; set; }
        public object insuranceExpiredDate { get; set; }
        public bool addressTypeVerified { get; set; }
        public bool identificationTypeVerified { get; set; }
        public int customerCartCount { get; set; }
        public object callingTime { get; set; }
        public string cityID { get; set; }
        public object cityName { get; set; }
        public int skuMinPrice { get; set; }
        public int skuMaxPrice { get; set; }
        public int targetPoint { get; set; }
        public object userCode { get; set; }
        public int stateID { get; set; }
        public object stateName { get; set; }
        public object passBookNumber { get; set; }
        public object mappedCustomerType { get; set; }
        public int mappedCustomerId { get; set; }
        public object mappedCustomerName { get; set; }
    }

    public class Lstloyaltyprogramreport
    {
        public object rewardCurrency { get; set; }
        public int rewardCurrencyID { get; set; }
        public float noofTrans { get; set; }
        public float totalAmount { get; set; }
        public float rewardGiven { get; set; }
        public float rewardDebited { get; set; }
        public float rewardQty { get; set; }
        public object txnsDate { get; set; }
        public object loyalityID { get; set; }
        public object programStartDate { get; set; }
        public object membershipName { get; set; }
        public object invoiceNo { get; set; }
        public int quantity { get; set; }
        public object merchantName { get; set; }
        public int totalAwarded { get; set; }
        public object transactionDate { get; set; }
        public object jTransactionDate { get; set; }
        public float amount { get; set; }
        public object currencyName { get; set; }
        public object transactionType { get; set; }
        public float discount { get; set; }
        public object serialNo { get; set; }
        public object remarks { get; set; }
        public object locationName { get; set; }
        public float grandTotalAmount { get; set; }
        public float grandTotalAwarded { get; set; }
        public int totAward { get; set; }
        public int totDeebit { get; set; }
        public int totAmt { get; set; }
        public int totSalesReturn { get; set; }
        public float salesReturn { get; set; }
        public int ltyTranTempId { get; set; }
        public object productCode { get; set; }
        public object productName { get; set; }
        public object authenticityCardImgPath { get; set; }
        public int isProgramValid { get; set; }
        public int merchantUserId { get; set; }
        public int memberCount { get; set; }
        public int noOfAwardTrxn { get; set; }
        public int noOfNotAwardTrxn { get; set; }
        public float grandTotalRedemed { get; set; }
        public object customerGrade { get; set; }
        public object customerType { get; set; }
        public object accountStatus { get; set; }
        public object verificationStatus { get; set; }
        public object brandName { get; set; }
        public int programID { get; set; }
        public object programName { get; set; }
        public object programDesc { get; set; }
        public bool status { get; set; }
        public int locationID { get; set; }
        public int locationUserID { get; set; }
        public int id { get; set; }
        public object name { get; set; }
    }



    public class OffersRequest
    {
        public int ActionType { get; set; }
        public int ActorId { get; set; }
        public string PromotionUserType { get; set; }
    }



    public class OffersResponse
    {
        public object lstPromotionList { get; set; }
        public object lstPromotionUserActionDetails { get; set; }
        public object lstPromotionView { get; set; }
        public Lstpromotionjsonlist[] lstPromotionJsonList { get; set; }
        public int returnValue { get; set; }
        public object returnMessage { get; set; }
        public int totalRecords { get; set; }
    }

    public class Lstpromotionjsonlist
    {
        public string promotionName { get; set; }
        public string proShortDesc { get; set; }
        public string proLongDesc { get; set; }
        public string proImage { get; set; }
        public string footer { get; set; }
        public bool is_Expired { get; set; }
        public bool is_Active { get; set; }
        public int views { get; set; }
        public int totalClaims { get; set; }
        public int promotion_Type { get; set; }
        public int totalViews { get; set; }
        public int totalBlocks { get; set; }
        public bool isReserved { get; set; }
        public bool isClaimed { get; set; }
        public int pushUserActionID { get; set; }
        public int totalResponses { get; set; }
        public bool cliamIdUsageStatus { get; set; }
        public string url { get; set; }
        public object view { get; set; }
        public object claim { get; set; }
        public object reserve { get; set; }
        public object comment { get; set; }
        public object validity { get; set; }
        public int targetCustomers { get; set; }
        public object promotionTypeName { get; set; }
        public object mobileNo { get; set; }
        public object memberId { get; set; }
        public object memberName { get; set; }
        public int totalRecords { get; set; }
        public bool canClaim { get; set; }
        public bool canReverse { get; set; }
        public bool canComment { get; set; }
        public int totalComment { get; set; }
        public object actionUrl { get; set; }
        public int categoryId { get; set; }
        public object categoryName { get; set; }
        public int albumImageID { get; set; }
        public object title { get; set; }
        public object firstName { get; set; }
        public object lastName { get; set; }
        public object fullName { get; set; }
        public int pointBalance { get; set; }
        public bool canView { get; set; }
        public bool allowUnReserve { get; set; }
        public bool isReservable { get; set; }
        public int approvalStatusID { get; set; }
        public object approvalStatus { get; set; }
        public object remarks { get; set; }
        public object emailID { get; set; }
        public bool isApprovable { get; set; }
        public object validFrom { get; set; }
        public string validTo { get; set; }
        public object outletName { get; set; }
        public bool redeemLocationAll { get; set; }
        public int promotionId { get; set; }
    }








}
