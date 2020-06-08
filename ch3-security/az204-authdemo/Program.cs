using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Microsoft.Graph;
using Microsoft.Graph.Auth;

namespace az204_authdemo
{
    public static class Program
    {
        private const string _clientId = "d8297264-ee0c-4138-abda-c6e7f1ba7351";
        private const string _tenantId = "8ecb1e37-4a2c-4527-a613-0f08b6ca9036";

        public static async Task Main()
        {
            string[] scopes = { "user.read" };

            var app = PublicClientApplicationBuilder
                        .Create(_clientId)
                        .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
                        .WithRedirectUri("http://localhost")
                        .Build();

            // AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

            // Console.WriteLine("token: {0}", result.AccessToken);

            var provider = new DeviceCodeProvider(app, scopes);
            var client = new GraphServiceClient(provider);
            User me = await client.Me.Request().GetAsync();

            Console.WriteLine("Display name: {0}", me.DisplayName);
        }
    }
}
