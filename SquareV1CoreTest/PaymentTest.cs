using MeyerCorp.Square.V1;
using Microsoft.Rest;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Meyer.Square.V1.Test
{
    public partial class PaymentTest
    {
        const string baseurl = "https://connect.squareup.com/v1/";
        // Uncomment following two lines and populate your information from Square.
        //const string location = "";
        //const string token = "";

        [Fact(DisplayName = "Payments: Get All")]
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
                    var payments = await client.PaymentOperations.GetAsync();

                    System.Diagnostics.Debug.WriteLine(payments);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }
 
        [Fact(DisplayName = "Payments: Get All, Date Limited")]
        public async Task GetTestAsyncDateLimited()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials)
                {
                    LocationId = location,
                })
                {
                    var payments = await client.PaymentOperations.GetAsync(beginTime: DateTime.Now - TimeSpan.FromDays(1),
                        endTime: DateTime.Now);

                    System.Diagnostics.Debug.WriteLine(payments);
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
