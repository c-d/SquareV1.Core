using MeyerCorp.Square.V1;
using MeyerCorp.Square.V1.Business;
using Microsoft.Rest;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Meyer.Square.V1.Test
{
    public class RoleTest : Test
    {
        // Uncomment following two lines and populate your information from Square.
        //const string location = "";
        //const string token = "";

        [Fact(DisplayName = "Role: Get All")]
        public async Task GetTestAsync()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var roles = await client.RoleOperations.GetAsync();

                    foreach (var role in roles) System.Diagnostics.Debug.WriteLine(role.Id);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }

        [Fact(DisplayName = "Role: Get Filtered")]
        public async Task GetFilteredTestAsync()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var roles = await client.RoleOperations.GetAsync(RangeOrderType.Ascending,2);

                    Assert.Equal(2, roles.Count());

                    foreach (var role in roles) System.Diagnostics.Debug.WriteLine(role.Id);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }

        [Fact(DisplayName = "Role: Get by Location ID")]
        public async Task GetSpecificTestAsync()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var role = await client.RoleOperations.GetAsync("FCv2Flm5C78ax4R8KOMx");

                    Assert.Equal("FCv2Flm5C78ax4R8KOMx", role.Id);

                    System.Diagnostics.Debug.WriteLine(role.Id);
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
