using MeyerCorp.Square.V1;
using Microsoft.Rest;
using System;
using System.Threading.Tasks;
using Xunit;
using MeyerCorp.Square.V1.Business;
using MeyerCorp.Square.V1.Webhooks;
using System.Collections.Generic;

namespace Meyer.Square.V1.Test
{
    public class WebhookTest : Test
    {
        // Uncomment following two lines and populate your information from Square.
        //const string location = "";
        //const string token = "";

        [Fact(DisplayName = "Webhook: List Async")]
        public async Task GetTestAsync()
        {
            var credentials = new TokenCredentials(token) as ServiceClientCredentials;

            using (var client = new Client(new Uri(baseurl), credentials))
            {
                foreach (var location in await client.LocationOperations.GetAsync())
                {
                    try
                    {
                        var webhooks = await client.WebhookOperations.GetAsync(location.Id);

                        System.Diagnostics.Debug.WriteLine(webhooks);
                    }
                    catch (HttpOperationException ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        System.Diagnostics.Debug.WriteLine(ex.Response.StatusCode.ToString());
                        System.Diagnostics.Debug.WriteLine(ex.Response.ReasonPhrase);
                        System.Diagnostics.Debug.WriteLine(ex.Request.RequestUri);
                        System.Diagnostics.Debug.WriteLine(ex.Request.Content);
                        throw;
                    }
                }
            }
        }

        [Fact(DisplayName = "Webhook: Update Async")]
        public async Task UpdateTestAsync()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    foreach (var location in await client.LocationOperations.GetAsync())
                    {
                        try
                        {
                            var webhooktypes = await client.WebhookOperations.PutAsync(location.Id, new List<WebhookEventType>
                            {
                                WebhookEventType.InventoryUpdated,
                                WebhookEventType.PaymentUpdated,
                                WebhookEventType.TimecardUpdated,
                            });

                            //System.Diagnostics.Debug.WriteLine(webhooktypes.Id);
                        }
                        catch (HttpOperationException ex)
                        {
                            System.Diagnostics.Debug.WriteLine(ex.Message);
                            System.Diagnostics.Debug.WriteLine(ex.Response.StatusCode.ToString());
                            System.Diagnostics.Debug.WriteLine(ex.Response.ReasonPhrase);
                            System.Diagnostics.Debug.WriteLine(ex.Request.RequestUri);
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }

        [Fact(DisplayName = "Webhook: List")]
        public  void GetTest()
        {
            var credentials = new TokenCredentials(token) as ServiceClientCredentials;

            using (var client = new Client(new Uri(baseurl), credentials))
            {
                foreach (var location in client.LocationOperations.Get())
                {
                    try
                    {
                        var webhooks = client.WebhookOperations.Get(location.Id);

                        System.Diagnostics.Debug.WriteLine(webhooks);
                    }
                    catch (HttpOperationException ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        System.Diagnostics.Debug.WriteLine(ex.Response.StatusCode.ToString());
                        System.Diagnostics.Debug.WriteLine(ex.Response.ReasonPhrase);
                        System.Diagnostics.Debug.WriteLine(ex.Request.RequestUri);
                        System.Diagnostics.Debug.WriteLine(ex.Request.Content);
                        throw;
                    }
                }
            }
        }

        [Fact(DisplayName = "Webhook: Update")]
        public void UpdateTest()
        {
            try
            {
                var credentials = new TokenCredentials(token) as ServiceClientCredentials;

                using (var client = new Client(new Uri(baseurl), credentials))
                {
                    foreach (var location in client.LocationOperations.Get())
                    {
                        try
                        {
                            var webhooktypes = client.WebhookOperations.Put(location.Id, new List<WebhookEventType>
                            {
                                WebhookEventType.InventoryUpdated,
                                WebhookEventType.PaymentUpdated,
                                WebhookEventType.TimecardUpdated,
                            });

                            //System.Diagnostics.Debug.WriteLine(webhooktypes.Id);
                        }
                        catch (HttpOperationException ex)
                        {
                            System.Diagnostics.Debug.WriteLine(ex.Message);
                            System.Diagnostics.Debug.WriteLine(ex.Response.StatusCode.ToString());
                            System.Diagnostics.Debug.WriteLine(ex.Response.ReasonPhrase);
                            System.Diagnostics.Debug.WriteLine(ex.Request.RequestUri);
                            throw;
                        }
                    }
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
