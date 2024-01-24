using RestSharp;
using RestSharp.Authenticators;

namespace ApiHelpers.ApiBase
{
    public class ApiRestSharp
    {
        private RestRequest? _restRequest;
        private readonly RestClient? _restClient;
        private readonly RestClientOptions? _restClientOptions;

        public ApiRestSharp() 
        { 
            _restClient = new();
            _restClientOptions = new RestClientOptions();
        }
        public ApiRestSharp(string baseUrl)
        {
            _restClientOptions = new (baseUrl);
            _restClient = new(_restClientOptions);

        }
        //public BaseApi(string baseUrl, RestClientOptions restClientOptions)
        //{
        //    var options = new RestClientOptions(baseUrl)
        //    {
        //        Authenticator = new HttpBasicAuthenticator(username, password)
        //    };
        //    restClient = new RestClient(options);
        //    _restClient = new(baseUrl);
        //}
        public ApiRestSharp AddRequest(string endpoint, Method method)
        {
            _restRequest = new RestRequest(endpoint, method);
            return this;
        }

        public ApiRestSharp PostMethod(string endpoint)
        {
            AddRequest(endpoint, Method.Post);
            return this;
        }
        public ApiRestSharp PutMethod(string endpoint)
        {
            AddRequest(endpoint, Method.Put);
            return this;
        }

        public ApiRestSharp DeleteMethod(string endpoint)
        {
            AddRequest(endpoint, Method.Delete);
            return this;
        }
        public ApiRestSharp GetMethod(string endpoint)
        {
            AddRequest(endpoint, Method.Get);
            return this;
        }

        public RestResponse Build()
        {
            return _restClient!.Execute(_restRequest!);
        }
        public ApiRestSharp AddQueryParameters(string name, string value)
        {
            _restRequest!.AddQueryParameter(name, value);
            return this;
        }

        public ApiRestSharp AddHeader(string name, string value)
        {
            _restRequest!.AddHeader(name, value);
            return this;
        }
        public ApiRestSharp AddBasicAuthentication(string username, string password)
        {
            _restClientOptions!.Authenticator = new HttpBasicAuthenticator(username, password);
            return this;
        }
    }
}
