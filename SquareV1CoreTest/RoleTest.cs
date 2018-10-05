using MeyerCorp.Square.V1;
using MeyerCorp.Square.V1.Business;
using System;
using System.Diagnostics;
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
                using (var client = new Client(new Uri(BaseUrl), Credentials))
                {
                    var roles = await client.RoleOperations.GetAsync();

                    foreach (var role in roles) Debug.WriteLine(role.Id);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        [Fact(DisplayName = "Role: Get Filtered")]
        public async Task GetFilteredTestAsync()
        {
            try
            {
                using (var client = new Client(new Uri(BaseUrl), Credentials))
                {
                    var roles = await client.RoleOperations.GetAsync(ListOrderType.Ascending,2);

                    Assert.Equal(2, roles.Count());

                    foreach (var role in roles) Debug.WriteLine(role.Id);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        [Fact(DisplayName = "Role: Get by Location ID")]
        public async Task GetSpecificTestAsync()
        {
            try
            {
                using (var client = new Client(new Uri(BaseUrl), Credentials))
                {
                    var role = await client.RoleOperations.GetAsync("FCv2Flm5C78ax4R8KOMx");

                    Assert.Equal("FCv2Flm5C78ax4R8KOMx", role.Id);

                    Debug.WriteLine(role.Id);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
