﻿using Meyer.Square.V1;
using Microsoft.Rest;
using System;
using System.Threading.Tasks;

namespace TestConsole
{
    partial class Program
    {
        const string baseurl = "https://connect.squareup.com/v1/";

        static void Main(string[] args)
        {
            var credentials = new TokenCredentials(token) as ServiceClientCredentials;

            using (var client = new Client(new Uri(baseurl), credentials)
            {
                LocationId = location,
            })
            {
                var payments = Task.Run(() => client.PaymentOperations.GetAsync());

                payments.Wait();

                foreach (var item in payments.Result)
                    System.Diagnostics.Debug.WriteLine(item.Id);
            }
        }
    }
}
