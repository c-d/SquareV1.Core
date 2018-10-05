using MeyerCorp.Square.V1;
using Microsoft.Rest;
using System;
using System.Threading.Tasks;
using Xunit;
using MeyerCorp.Square.V1.Business;
using MeyerCorp.Square.V1.Webhooks;
using System.Collections.Generic;
using System.Diagnostics;

namespace Meyer.Square.V1.Test
{
    public class WebhookTest : Test
    {
        [Fact(DisplayName = "Webhook: List Webhooks Async GET /v1/{location_id}/webhooks")]
        public async Task ListWebhooksAsync()
        {
            using (var client = new Client(new Uri(BaseUrl), Credentials))
            {
                foreach (var location in await client.LocationOperations.GetAsync())
                {
                    var webhooktypes = await client.WebhookOperations.PutAsync(location.Id, new List<WebhookEventType>
                            {
                                WebhookEventType.InventoryUpdated,
                                WebhookEventType.PaymentUpdated,
                                WebhookEventType.TimecardUpdated,
                            });

                    Assert.Equal(3, webhooktypes.Count);

                    webhooktypes = await client.WebhookOperations.PutAsync(location.Id, new List<WebhookEventType> { });

                    Assert.Equal(0, webhooktypes.Count);
                }
            }
        }

        [Fact(DisplayName = "Webhook: List Webhooks Sync GET /v1/{location_id}/webhooks")]
        public void ListWebhooks()
        {
            using (var client = new Client(new Uri(BaseUrl), Credentials))
            {
                foreach (var location in client.LocationOperations.Get())
                {
                    var webhooktypes = client.WebhookOperations.Put(location.Id, new List<WebhookEventType>
                    {
                        WebhookEventType.InventoryUpdated,
                        WebhookEventType.PaymentUpdated,
                        WebhookEventType.TimecardUpdated,
                    });

                    Assert.Equal(3, webhooktypes.Count);

                    webhooktypes = client.WebhookOperations.Put(location.Id, new List<WebhookEventType> { });

                    Assert.Equal(0, webhooktypes.Count);
                }
            }
        }

        [Fact(DisplayName = "Webhook: Update Webhooks Sync PUT /v1/{location_id}/webhooks")]
        public void UpdateWebhooks()
        {
            using (var client = new Client(new Uri(BaseUrl), Credentials))
            {
                foreach (var location in client.LocationOperations.Get())
                {
                    var webhooktypes = client.WebhookOperations.Put(location.Id, new List<WebhookEventType>
                    {
                        WebhookEventType.InventoryUpdated,
                        WebhookEventType.PaymentUpdated,
                        WebhookEventType.TimecardUpdated,
                    });

                    Assert.Equal(3, webhooktypes.Count);

                    webhooktypes = client.WebhookOperations.Put(location.Id, new List<WebhookEventType> { });

                    Assert.Equal(0, webhooktypes.Count);
                }
            }
        }

        [Fact(DisplayName = "Webhook: Update Webhooks Async PUT /v1/{location_id}/webhooks")]
        public async Task UpdateWebhooksAsync()
        {
            using (var client = new Client(new Uri(BaseUrl), Credentials))
            {
                foreach (var location in await client.LocationOperations.GetAsync())
                {
                    var webhooktypes = await client.WebhookOperations.PutAsync(location.Id, new List<WebhookEventType>
                    {
                        WebhookEventType.InventoryUpdated,
                        WebhookEventType.PaymentUpdated,
                        WebhookEventType.TimecardUpdated,
                    });

                    Assert.Equal(3, webhooktypes.Count);

                    webhooktypes = await client.WebhookOperations.PutAsync(location.Id, new List<WebhookEventType> { });

                    Assert.Equal(0, webhooktypes.Count);
                }
            }
        }
    }
}
