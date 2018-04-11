using System.Xml;
using System.Threading;
using Frends.Community.SharePoint.Download;
using NUnit.Framework;

namespace Frends.Community.SharePoint.Download.Tests
{
    [TestFixture]
    public class DownloadFromSharePoint
    {
        //[Test]
        //public void TestConvertXmlToCsv()
        //{
        //    var indata = new Input
        //    {
        //        InputData = ConvertToCsvTestData.TestXml,
        //        FileType = FileType.Xml,
        //        CsvSeparator = ",",
        //        IncludeHeaders = true
        //    };

        //    var result = DownLoadFromSharePoint.ConvertToCsvTask(indata, new CancellationToken());
        //    System.Console.WriteLine(result.Result);
        //    Assert.AreEqual(ConvertToCsvTestData.ExpectedCsvResult, result.Result);

        //}

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
            

        }

    }
}
