using Microsoft.Rest;

namespace Meyer.Square.V1.Test
{
    public partial class Test
    {
        // Uncomment following two lines and populate your information from Square.

        //protected const string ApplicationName = "";

        //protected const string ApplicationID = "";

        //protected const string PersonalAccessToken = "";

        //protected const string ApplicationSecret = "";

        protected const string BaseUrl = "https://connect.squareup.com/v1/";

        private ServiceClientCredentials _Credentials;

        protected ServiceClientCredentials Credentials
        {
            get
            {
                if (_Credentials == null)
                    _Credentials = new TokenCredentials(PersonalAccessToken) as ServiceClientCredentials;

                return _Credentials;
            }
        }

        //protected InitializeLocations()
        //{

        //}
    }
}
