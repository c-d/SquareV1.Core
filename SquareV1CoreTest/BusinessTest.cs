using MeyerCorp.Square.V1;
using MeyerCorp.Square.V1.Business;
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

        [Fact(DisplayName = "Business: Get Me async")]
        public async Task GetTestAsync()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
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

        [Fact(DisplayName = "Business: Get by Location ID async")]
        public async Task GetSpecificTestAsync()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var merchant = await client.BusinessOperations.GetAsync(location);

                    Assert.Equal("C16C5851HEJR5", merchant.Id);

                    System.Diagnostics.Debug.WriteLine(merchant.Id);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }

        [Fact(DisplayName = "Business: Get Me")]
        public void GetTest()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var merchant = client.BusinessOperations.Get();

                    System.Diagnostics.Debug.WriteLine(merchant);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }

        [Fact(DisplayName = "Business: Get by Location ID")]
        public void GetSpecificTest()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var merchant = client.BusinessOperations.Get(location);

                    Assert.Equal("C16C5851HEJR5", merchant.Id);

                    System.Diagnostics.Debug.WriteLine(merchant.Id);
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
