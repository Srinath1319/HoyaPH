using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HoyaPH.Services
{

    public class AuthHeader : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)


        {

            Console.WriteLine("===============================================================================================================");
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine("REQUEST_URL : " + request.RequestUri.ToString());
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine("===============================================================================================================");
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine(" ->>->>->> API_REQUEST : " + await request.Content.ReadAsStringAsync());
            Console.WriteLine("                                                                                                               ");
            Console.WriteLine("===============================================================================================================");

            
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Preferences.Get("TOKEN", "Default_token"));
            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }

    }
}
