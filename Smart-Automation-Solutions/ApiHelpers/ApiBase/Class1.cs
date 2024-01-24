using RestSharp;
using RestSharp.Authenticators;

namespace ApiHelpers.ApiBase
{
    public class BaseApi
    {
        private RestRequest? _restRequest;
        private readonly RestClient? _restClient;
        private readonly RestClientOptions? _restClientOptions;

        public BaseApi() 
        { 
            _restClient = new();
            _restClientOptions = new RestClientOptions();
        }
        public BaseApi(string baseUrl)
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
        public BaseApi AddRequest(string endpoint, Method method)
        {
            _restRequest = new RestRequest(endpoint, method);
            return this;
        }

        public BaseApi PostMethod(string endpoint)
        {
            AddRequest(endpoint, Method.Post);
            return this;
        }
        public BaseApi PutMethod(string endpoint)
        {
            AddRequest(endpoint, Method.Put);
            return this;
        }

        public BaseApi DeleteMethod(string endpoint)
        {
            AddRequest(endpoint, Method.Delete);
            return this;
        }
        public BaseApi GetMethod(string endpoint)
        {
            AddRequest(endpoint, Method.Get);
            return this;
        }

        public RestResponse Build()
        {
            return _restClient!.Execute(_restRequest!);
        }
        public BaseApi AddQueryParameters(string name, string value)
        {
            _restRequest!.AddQueryParameter(name, value);
            return this;
        }

        public BaseApi AddHeader(string name, string value)
        {
            _restRequest!.AddHeader(name, value);
            return this;
        }
        public BaseApi AddBasicAuthentication(string username, string password)
        {
            _restClientOptions!.Authenticator = new HttpBasicAuthenticator(username, password);
            return this;
        }
    }
}
