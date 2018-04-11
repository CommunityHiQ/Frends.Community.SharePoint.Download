using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using System.Net;
using System.Net.Http;


#pragma warning disable 1591

namespace Frends.Community.SharePoint.Download
{


    public class Input
    {
        /// <summary>
        /// The bearer realm of the current SharePoint site. Make GET request to https://your_site.sharepoint.com/_vti_bin/client.svc Header: Authorization: Bearer
        /// </summary>
        [DisplayName("Bearer Realm")]
        public string BearerRealm { get; set; }

        /// <summary>
        /// Client ID
        /// </summary>
        [DisplayName("Client ID")]
        public string ClientID { get; set; }

        /// <summary>
        /// Client secret
        /// </summary>
        [DisplayName("Client Secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Site Collection URL(without subsites or document library) e.g. https://My.sharepoint.com/sites/siteCollection
        /// </summary>
        [DisplayName("Site Collection URL")]
        public string SiteCollectionURL { get; set; }

        /// <summary>
        /// Document Library URL(without the site collection -part, but including subsites and folders if applicable) e.g. /SubSite/Document%20Library/Folder/SubFolder/ 
        /// </summary>
        [DisplayName("Document Library URL")]
        public string DocumentLibraryURL { get; set; }

        /// <summary>
        /// Source file name
        /// </summary>
        [DisplayName("Source file name")]
        public string SourceFileName { get; set; }

        /// <summary>
        /// Target file path
        /// </summary>
        [DisplayName("Target folder")]
        public string TargetFolder { get; set; }

        /// <summary>
        /// Target file name
        /// </summary>
        [DisplayName("Target file name")]
        public string TargetFileName { get; set; }


    }
    /// <summary>
    /// Return object
    /// </summary>
    public class Output
    {
        /// <summary>
        /// Result path of the created file
        /// </summary>
        public string Path { get; set; }
    }

    public class DownLoadFromSharePoint
    {
        /// <summary>
        /// Download file contents from SharePoint document library. Errors are always thrown by an exception.
        /// </summary>
        /// <param name="input">Input data</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Object {string Result }</returns>
        /// 

        public static Output DownLoadFromSharePointTask(Input input, CancellationToken cancellationToken)
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
            using (var httpClient = new HttpClient()) {

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

