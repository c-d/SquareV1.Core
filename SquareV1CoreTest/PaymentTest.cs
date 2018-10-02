using MeyerCorp.Square.V1;
using MeyerCorp.Square.V1.Transaction;
using Microsoft.Rest;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Meyer.Square.V1.Test
{
    public partial class PaymentTest : Test
    {
        // Uncomment following two lines and populate your information from Square.
        //const string location = "";
        //const string token = "";

        [Fact(DisplayName = "Payments: Get All, (async)")]
        public async Task GetTestAsync()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var payments = await client.PaymentOperations.GetAsync(limit: 200, locationId: location);

                    foreach (var payment in payments)
                        System.Diagnostics.Debug.WriteLine(payment.Id);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }

        [Fact(DisplayName = "Payments: Get All, continously(async)")]
        public async Task GetContinuouslyTestAsync()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var payments = await client.PaymentOperations.GetAsync(locationId: location, isContinous: true, limit: 200);

                    foreach (var payment in payments)
                        System.Diagnostics.Debug.WriteLine(payment.Id);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }

        [Fact(DisplayName = "Payments: Get All")]
        public void GetTest()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var payments = client.PaymentOperations.Get(locationId: location/*, take: 2*/);

                    foreach (var payment in payments)
                        System.Diagnostics.Debug.WriteLine(payment.Id);
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

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var payments = await client.PaymentOperations.GetAsync(locationId: location,
                        beginTime: DateTime.Now - TimeSpan.FromDays(1),
                        endTime: DateTime.Now,
                        limit: 1);

                    foreach (var payment in payments)
                        System.Diagnostics.Debug.WriteLine(payment.Id);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }

        [Fact(DisplayName = "Payments: Get All, Take Limited")]
        public async Task GetTestAsyncTakeLimited()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var payments = await client.PaymentOperations.GetAsync(locationId: location,
                         limit: 50,
                         listOrder: ListOrderType.Descending);

                    Assert.Equal(50, payments.Count());
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }
 
        [Fact(DisplayName = "Payments: Get All, Take Limited, Filter by Date, continously(async)")]
        public async Task GetTestAsyncTakeLimitedFilterbyDate()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    var payments = await client.PaymentOperations.GetAsync(locationId: location,
                        endTime: DateTime.Now,
                        beginTime: DateTime.Today - TimeSpan.FromDays(1),
                        limit: 200,
                        isContinous: true);

                    foreach (var item in payments)
                        System.Diagnostics.Debug.WriteLine(item.Id);

                    //Assert.Equal(50, payments.Count);
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
