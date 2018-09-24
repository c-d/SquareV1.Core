using MeyerCorp.Square.V1;
using Microsoft.Rest;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Meyer.Square.V1.Test
{
    public class BusinessTest : Test
    {
        // Uncomment following two lines and populate your information from Square.
        //const string location = "";
        //const string token = "";

        [Fact(DisplayName = "Locations: Get Me")]
        public async Task GetTestAsync()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials)
                {
                    LocationId = location,
                })
                {
                    var merchant = await client.BusinessOperations.GetAsync();

                    System.Diagnostics.Debug.WriteLine(merchant);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
