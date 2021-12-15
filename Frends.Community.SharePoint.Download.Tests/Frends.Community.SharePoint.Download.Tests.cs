using NUnit.Framework;
using System;

namespace Frends.Community.SharePoint.Download.Tests
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void TestGetOauth()
        {
            var indata = new Input
            {
                BearerRealm = "97759401-0ff9-42fb-8eae-9163e29d19bf",
                ClientID = "",
                ClientSecret = "",
                SiteCollectionURL = "https://unthink.sharepoint.com/teams/icc-energy/"
            };

            var result = DownLoadFromSharePoint.GetOAuthToken(indata);
            Console.WriteLine(result);
        }

    }
}
