

using HoyaPH.Services;
using Refit;

namespace HoyaPH.Repository
{
    public class BaseRepository
    {
        ApiInterface apiInterface;
        List<KeyValuePair<string, string>> KeyContent;
        FormUrlEncodedContent TokenRequest;

        public BaseRepository(ApiInterface apiInterface)
        {

            this.apiInterface = apiInterface;
            KeyContent = new List<KeyValuePair<string, string>> {
            new KeyValuePair<string, string>("grant_type","password"),
            new KeyValuePair<string, string>("username","LtyHoyaThDemo"),
            new KeyValuePair<string, string>("password","H0)Y@7L$mK#9p87") };
        }


        public async Task RefreshToken()
        {
            TokenRequest = new FormUrlEncodedContent(KeyContent);
            var Token = await apiInterface.getToken(TokenRequest);

            Console.WriteLine("TOKEN : " + Token.access_token);
            Preferences.Set("TOKEN", Token.access_token);
        }

        public async Task<T> ApiCall<T>(Func<Task<T>> request)
        {

            try
            {
                T result = await request();
                return result;

            }catch (ApiException ex) {

                await RefreshToken();
                T result = await request();
                return result;

            }
        }



    }


}
