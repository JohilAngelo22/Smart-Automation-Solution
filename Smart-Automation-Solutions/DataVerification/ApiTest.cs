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
            BaseApi baseApi = new(TestDataConstant.BaseUrl);
            var restResponse  = baseApi.GetMethod(TestDataConstant.EndPoint).Build();
            ClassicAssert.AreEqual(restResponse.StatusCode, HttpStatusCode.OK);
        }
    }
}
