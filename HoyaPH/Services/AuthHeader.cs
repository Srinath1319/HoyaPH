
using HoyaPH.Utils;
using Newtonsoft.Json;
using Refit;

using System.Net.Http.Headers;


namespace HoyaPH.Services
{

    public class AuthHeader : DelegatingHandler
    {
        List<KeyValuePair<string, string>> KeyContent;
        FormUrlEncodedContent TokenRequest;

        public class TokenResponse
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string userName { get; set; }

            [JsonProperty(".issued")]
            public string issued { get; set; }

            [JsonProperty(".expires")]
            public string expires { get; set; }
        }


        public interface TokenInterface
        {

            [Headers("Content-Type: application/x-www-form-urlencoded")]
            [Post("/token")]
            public Task<TokenResponse> getToken([Body(BodySerializationMethod.UrlEncoded)] FormUrlEncodedContent TokenRequest);
        }


        public AuthHeader()
        {
            InnerHandler = new HttpClientHandler();
            KeyContent = new List<KeyValuePair<string, string>> {
            new KeyValuePair<string, string>("grant_type",Constants.GRANT_TYPE),
            new KeyValuePair<string, string>("username",Constants.USERNAME),
            new KeyValuePair<string, string>("password",Constants.PASSWORD) };

        }


        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var authApi = RestService.For<TokenInterface>(Constants.TOKEN_URL);
            TokenRequest = new FormUrlEncodedContent(KeyContent);
            var Token = await authApi.getToken(TokenRequest);

            Console.WriteLine("===============================================================================================================");
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine("REQUEST_URL : " + request.RequestUri.ToString());
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine("===============================================================================================================");
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine(" ->>->>->> API_REQUEST : " + await request.Content.ReadAsStringAsync());
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine("===============================================================================================================");


            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token.access_token);
            var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            Console.WriteLine("===============================================================================================================");
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine(" <<-<<-<<- API_RESPONSE : " + await response.Content.ReadAsStringAsync());
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine("===============================================================================================================");
            return response;
        }

    }
}
