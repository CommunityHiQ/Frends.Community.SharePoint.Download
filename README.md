**[Table of Contents](http://tableofcontent.eu)**
- [Frends.Community.SharePoint.Download](#frendscommunitysharepointdownload)
  - [Contributing](#contributing)
  - [Documentation](#documentation)
    - [Input](#input)
    - [Result](#result)
  - [License](#license)


# Frends.Community.SharePoint.Download
FRENDS Task to Download files from SharePoint document library

## Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repo on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

## Documentation

### Input

| Property				|  Type   | Description								| Example                     |
|-----------------------|---------|-----------------------------------------|-----------------------------|
| Bearer realm | string | The bearer realm of the current SharePoint site. Use GET request to get it [https://your_site.sharepoint.com/_vti_bin/client.svc](https://your_site.sharepoint.com/_vti_bin/client.svc) Header: Authorization: Bearer | 25c9cdd5-9c67-4f40-b8d0-de5179ee8673 |
| Client ID | string | Client ID | 78f8c3da-044e-4313-ae7f-f5a4245e482b |
| Client secret | string | Client secret |  |
| Site collection url | string | Site Collection URL (without subsites or document library) | https://My.sharepoint.com/sites/siteCollection |
| Document library url | string |  Document Library URL (without the site collection -part, but including subsites and folders if applicable) | /SubSite/Document%20Library/Folder/SubFolder/  |
| Source file name | string | Source file name |  |
| Target folder | string | Target file path |  |
| Target file name  | string | Target file name |  |

### Result

### Result

| Property      | Type     | Description                      | Example                     |
|---------------|----------|----------------------------------|-----------------------------|
| Result | string | Result path of the created file |  |

## License

This project is licensed under the MIT License - see the LICENSE file for details
