using MeyerCorp.Square.V1;
using MeyerCorp.Square.V1.Business;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

namespace Meyer.Square.V1.Test
{
    public class BusinessTest : Test
    {
        [Fact(DisplayName = "Business: Retrieve Business Async GET /v1/me")]
        public async Task RetrieveBusinessAsync()
        {
            using (var client = new Client(new Uri(BaseUrl), Credentials))
            {
                var merchant = await client.BusinessOperations.GetAsync();

                Debug.WriteLine(merchant);
            }
        }

        [Fact(DisplayName = "Business: Retrieve Business Sync GET /v1/me")]
        public void RetrieveBusiness()
        {
            using (var client = new Client(new Uri(BaseUrl), Credentials))
            {
                var merchant = client.BusinessOperations.Get();

                Debug.WriteLine(merchant);
            }
        }

        [Fact(DisplayName = "Locations: List Locations Async GET /v1/me/locations")]
        public async Task ListLocationsAsync()
        {
            using (var client = new Client(new Uri(BaseUrl), Credentials))
            {
                var locations = await client.LocationOperations.GetAsync();

                foreach (var location in locations)
                    Debug.WriteLine(location);
            }
        }

        [Fact(DisplayName = "Locations: List Locations Sync GET /v1/me/locations")]
        public void ListLocations()
        {
            using (var client = new Client(new Uri(BaseUrl), Credentials))
            {
                var locations = client.LocationOperations.Get();

                foreach (var location in locations)
                    Debug.WriteLine(location);
            }
        }

        [Fact(DisplayName = "Business: Retrieve Location Async GET /v1/me/locations/{locationId}")]
        public async Task RetrieveLocationsAsync()
        {
            using (var client = new Client(new Uri(BaseUrl), Credentials))
            {
                var locations = await client.LocationOperations.GetAsync();

                foreach (var location in locations)
                {
                    var merchant = await client.BusinessOperations.GetAsync(location.Id);

                    Debug.WriteLine(merchant);
                }
            }
        }

        [Fact(DisplayName = "Business: Retrieve Location Sync GET /v1/me/locations/{locationId}")]
        public void RetrieveLocations()
        {
            using (var client = new Client(new Uri(BaseUrl), Credentials))
            {
                var locations = client.LocationOperations.Get();

                foreach (var location in locations)
                {
                    var merchant = client.BusinessOperations.Get(location.Id);

                    Debug.WriteLine(merchant);
                }
            }
        }
    }
}