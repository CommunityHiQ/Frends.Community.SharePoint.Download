using System.Text;
using System.Threading;
using System.Net;
using System.Net.Http;

#pragma warning disable 1591

namespace Frends.Community.SharePoint.Download
{
    public static class DownLoadFromSharePoint
    {
        /// <summary>
        /// Download file contents from SharePoint document library. Errors are always thrown by an exception.
        /// </summary>
        /// <param name="input">Input data</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Object {string Result }</returns>
        /// 

        public static Output DownloadFromSharePointTask(Input input, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var result = new Output();

            string oAuthToken = GetOAuthToken(input);

            return result;
        }

        public static string GetOAuthToken(Input input)
        {
            var oAuthURL = @"https://accounts.accesscontrol.windows.net/" + input.BearerRealm + "/tokens/OAuth/2";

            var postMessage = "grant_type=client_credentials&client_id=" + input.ClientID + "@" + input.BearerRealm + "&client_secret=" + input.ClientSecret + "&resource=00000003-0000-0ff1-ce00-000000000000/" + input.SiteCollectionURL.ToLower().Replace("https://", "").Substring(0, input.SiteCollectionURL.ToLower().IndexOf("sharepoint.com") + 6) + "@" + input.BearerRealm;

            var content = new StringContent(postMessage, Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = new HttpResponseMessage();
            using (var httpClient = new HttpClient())
            {
                response = httpClient.PostAsync(oAuthURL, content).Result;
            }

            return response.ToString();
        }

        public static string GetSharePointFile(Input input)
        {
            var sharePointFileURL = input.SiteCollectionURL + input.DocumentLibraryURL + input.SourceFileName;

            return "testi";
        }
    }
}
