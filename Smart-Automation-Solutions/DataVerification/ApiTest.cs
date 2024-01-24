using ApiHelpers;
using ApiHelpers.ApiBase;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Net;

namespace DataVerification
{
    [TestFixture]
    public class ApiTest
    {
        [Test]
        public void ApiSampleTest()
        {
            ApiRestSharp baseApi = new(TestDataConstant.BaseUrl);
            var restResponse  = baseApi.GetMethod(TestDataConstant.EndPoint).Build();
            ClassicAssert.AreEqual(restResponse.StatusCode, HttpStatusCode.OK);
        }

        [Test]
        public void ApiSampleTestUsingHttpClient()
        {
            string apiUrl = "https://api.example.com/endpoint";

            // Create an instance of HttpClient
            using HttpClient httpClient = new();
            try
            {
                // Execute the GET request
                HttpResponseMessage response = httpClient.GetAsync(apiUrl).Result;

                // Check if the request was successful (status code in the range 200-299)
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    string responseBody =  response.Content.ReadAsStringAsync().Result;

                    // Process the response as needed
                    Console.WriteLine($"API Response: {responseBody}");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
    }