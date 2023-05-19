using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoyaPH.Models
{

    public class MyEarningRequest
    {
        public int ActionType { get; set; }
        public int ActiveStatus { get; set; }
        public string FromDate { get; set; }
        public string ProgramID { get; set; }
        public string SalesPersonId { get; set; }
        public string ToDate { get; set; }
    }


    public class MyEarningResponse
    {
        public Customerbasicinfolistjson[] customerBasicInfoListJson { get; set; }
        public int returnValue { get; set; }
        public object returnMessage { get; set; }
        public int totalRecords { get; set; }
    }

    public class Customerbasicinfolistjson
    {
        public object fullName { get; set; }
        public object email { get; set; }
        public bool isActive { get; set; }
        public object mobile { get; set; }
        public object createdDate { get; set; }
        public int merchantID { get; set; }
        public int row { get; set; }
        public int totalRows { get; set; }
        public object dob { get; set; }
        public bool rewardAdj { get; set; }
        public bool redemption { get; set; }
        public bool referral { get; set; }
        public bool editProfile { get; set; }
        public bool smsToCustomer { get; set; }
        public bool asmSeMapping { get; set; }
        public object customer_Type { get; set; }
        public int awardRewardId { get; set; }
        public float creditedPoint { get; set; }
        public object areaName { get; set; }
        public float debitedPoint { get; set; }
        public int balance { get; set; }
        public string invoiceNo { get; set; }
        public object enrolledDate { get; set; }
        public int pointsBalance { get; set; }
        public int behaviourId { get; set; }
        public object status { get; set; }
        public int verified { get; set; }
        public int countryId { get; set; }
        public object countryName { get; set; }
        public int verifiedTypeId { get; set; }
        public int cityId { get; set; }
        public object cityName { get; set; }
        public int asmUserId { get; set; }
        public int seUserId { get; set; }
        public object asmName { get; set; }
        public object seName { get; set; }
        public int createdById { get; set; }
        public object createdByName { get; set; }
        public object retailerName { get; set; }
        public object salesRepresentative { get; set; }
        public object registrationStatus { get; set; }
        public object accountType { get; set; }
        public object gender { get; set; }
        public object programName { get; set; }
        public string productName { get; set; }
        public object loyaltyTempId { get; set; }
        public object giftAmount { get; set; }
        public object imageUrl { get; set; }
        public bool vehicleManagement { get; set; }
        public object leadStatus { get; set; }
        public int districtId { get; set; }
        public object districtName { get; set; }
        public int talukId { get; set; }
        public object talukName { get; set; }
        public object accountNumber { get; set; }
        public object acountHolderName { get; set; }
        public object bankName { get; set; }
        public object bankBranch { get; set; }
        public object ifscCode { get; set; }
        public object walletNumber { get; set; }
        public int salesReturn { get; set; }
        public object categoryName { get; set; }
        public int batchNo { get; set; }
        public string trxnDate { get; set; }
        public object authorizedBy { get; set; }
        public float quantity { get; set; }
        public object isAvailble { get; set; }
        public object isCold { get; set; }
        public object resolveDate { get; set; }
        public object approverIp { get; set; }
        public object categoryChangeName { get; set; }
        public object mappedCount { get; set; }
        public int areaId { get; set; }
        public object transactionType { get; set; }
        public object salesPersonsName { get; set; }
        public object salesPersonsID { get; set; }
        public object partnerID { get; set; }
        public object partnerName { get; set; }
        public object assessmentCertificate { get; set; }
        public string assessmentName { get; set; }
        public object productDesc { get; set; }
        public string remarks { get; set; }
        public object sku { get; set; }
        public object pinCode { get; set; }
        public object landLine { get; set; }
        public object nationality { get; set; }
        public object tradLicence { get; set; }
        public object sapID { get; set; }
        public int customerTicketId { get; set; }
        public object verifiedName { get; set; }
        public object ticketReferenceNumber { get; set; }
        public int departmentId { get; set; }
        public int designationId { get; set; }
        public object anniversary { get; set; }
        public object approvedBy { get; set; }
        public object customerCategory { get; set; }
        public int customerCategoryId { get; set; }
        public object userOneHeader { get; set; }
        public object userTwoHeader { get; set; }
        public object requestTo { get; set; }
        public int customerTypeId { get; set; }
        public object whatsAppMobileNumber { get; set; }
        public object workSiteLandMark { get; set; }
        public object workSiteContactPersonName { get; set; }
        public object workSitePincode { get; set; }
        public object workSiteVerificationStatus { get; set; }
        public object workSiteContactNumber { get; set; }
        public int workSiteInfoID { get; set; }
        public object workSiteCityName { get; set; }
        public object workSiteAddress { get; set; }
        public int workSiteVerification { get; set; }
        public object approOneName { get; set; }
        public object approTwoName { get; set; }
        public object approOneDate { get; set; }
        public object approTwoDate { get; set; }
        public int approverId { get; set; }
        public int nominalPoints { get; set; }
        public int redeemablePoints { get; set; }
        public int redeemedPoints { get; set; }
        public object locationName { get; set; }
        public string productCode { get; set; }
        public int sellingPrice { get; set; }
        public object claimedRemarks { get; set; }
        public object dealerCode { get; set; }
        public object approvedQuantity { get; set; }
        public string pointExpiryDate { get; set; }
    }




}
