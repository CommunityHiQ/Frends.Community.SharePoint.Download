#pragma warning disable 1591

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frends.Community.Sharepoint.Download
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
}
