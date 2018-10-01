# Meyer Square V1 SDK for .NET Core
A software development kit in .NET Core for the Square API (V1)

## Getting Started
1. Use NuGet to include this in any .NET Core 2.1 project.

   `Package-Install MeyerCorp.Square.V1`

	Then write some code:
	```
	using Microsoft.Rest;
	using Meyer.Square.V1;

	var credentials = new TokenCredentials(<your token>) as ServiceClientCredentials;

	using (var client = new Client(new Uri(baseurl), credentials)
	{
		LocationId = "<your location ID>",
	})
	{
		var payments = await client.PaymentOperations.GetAsync();
	}
	```

### Prerequisites

* Create a developer account at [Square](https://squareup.com/us/en/developers).

### Installing

(Check back soon.)

## Running the tests

(Check back soon.)

### Break down into end to end tests

(Check back soon.)

```
(Check back soon.)
```

### And coding style tests

(Check back soon.)

```
(Check back soon.)
```

## Deployment

(Check back soon.)

## Built With

* [.NET Core SDK 2.1](https://www.microsoft.com/net/download) - You'll need the .NET Core SDK for your operating system.

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Authors

* **Daniel Przybylski** - *Initial work* - [GitHub](https://github.com/Alfetta159)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* The architecture is heavily based on the Microsoft REST Client generated when using a Open API standard to generated a REST API Client.
