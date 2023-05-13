using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Views;
using HoyaPH.Models;
using Newtonsoft.Json;

namespace HoyaPH.Test
{
    public class AppController
    {

        public static AppController appController = null;

        private AppController() { }

        public static  AppController getInstance()
        {
            if (appController == null)
            {
                appController = new AppController();
            }
            return appController;
        }



        Popup popup; 

        public  void showLoadingDialog(Page page)
        {
            popup = new Popup();
            page.ShowPopup(popup);
        }
           

        public void hideLoadingDialog()
        {
            
            popup.closePopup();
        }


        public void setLoginDetails(LoginResponse loginResponse) {

            Preferences.Set("LOGIN_RESPONSE", JsonConvert.SerializeObject(loginResponse));

        }

        public LoginResponse getLoginDetails() {
            
            return JsonConvert.DeserializeObject<LoginResponse>(Preferences.Get("LOGIN_RESPONSE","Default_value"));
        }
    }
}
