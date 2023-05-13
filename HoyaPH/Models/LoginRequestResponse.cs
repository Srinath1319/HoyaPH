using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoyaPH.Models
{

    public class LoginRequest
    {
        public string UserActionType { get; set; }
        public string Browser { get; set; }
        public string LoggedDeviceName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string SessionId { get; set; }
    }


    public class LoginResponse
    {
        public Userlist[] userList { get; set; }
        public object objUserDetailedInfo { get; set; }
        public object merchantImageDetails { get; set; }
        public object lstMerchantImageDetails { get; set; }
        public int userId { get; set; }
    }

    public class Userlist
    {
        public string userType { get; set; }
        public string userImage { get; set; }
        public string userGender { get; set; }
        public string userLastName { get; set; }
        public object encrypted_OTP_PIN { get; set; }
        public int locationId { get; set; }
        public object merchant_logo { get; set; }
        public string custAccountNumber { get; set; }
        public int c_MerchantId { get; set; }
        public int merchantId { get; set; }
        public object merchantName { get; set; }
        public object commonUserName { get; set; }
        public object commonUserMobile { get; set; }
        public int pinStatus { get; set; }
        public string email { get; set; }
        public string prefix { get; set; }
        public int isGeofenceActive { get; set; }
        public string mobile { get; set; }
        public object dob { get; set; }
        public string merchantMobileNo { get; set; }
        public string merchantEmailID { get; set; }
        public object country { get; set; }
        public int locationCountryID { get; set; }
        public int customerTypeID { get; set; }
        public object custAccountType { get; set; }
        public string currency { get; set; }
        public string countryCode { get; set; }
        public object roleName { get; set; }
        public object customerGrade { get; set; }
        public object memberSince { get; set; }
        public string locationName { get; set; }
        public object parentLocationName { get; set; }
        public object locationType { get; set; }
        public object cityName { get; set; }
        public int parentLocationId { get; set; }
        public int superParentLocationId { get; set; }
        public int verifiedStatus { get; set; }
        public int isUserActive { get; set; }
        public int isBlacklisted { get; set; }
        public int isDormant { get; set; }
        public int isOnHold { get; set; }
        public object language { get; set; }
        public int isDelete { get; set; }
        public int languageId { get; set; }
        public object sapCode { get; set; }
        public int parentCustomerTypeId { get; set; }
        public int userId { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public int result { get; set; }
        public int actionType { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }


}
