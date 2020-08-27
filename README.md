# Frends.Community.Sharepoint.Download

FRENDS Task to Download files from SharePoint document library

[![Actions Status](https://github.com/CommunityHiQ/Frends.Community.Sharepoint.Download/workflows/PackAndPushAfterMerge/badge.svg)](https://github.com/CommunityHiQ/Frends.Community.Sharepoint.Download/actions) ![MyGet](https://img.shields.io/myget/frends-community/v/Frends.Community.Sharepoint.Download) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) 

- [Installing](#installing)
- [Tasks](#tasks)
     - [DownloadFromSharepoint](#DownloadFromSharepoint)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

You can install the task via FRENDS UI Task View or you can find the NuGet package from the following NuGet feed
https://www.myget.org/F/frends-community/api/v3/index.json and in Gallery view in MyGet https://www.myget.org/feed/frends-community/package/nuget/Frends.Community.Sharepoint.Download

# Tasks

## DownloadFromSharepoint

Repeats message

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

| Property      | Type     | Description                      | Example                     |
|---------------|----------|----------------------------------|-----------------------------|
| Result | string | Result path of the created file |  |

# Building

Clone a copy of the repo

`git clone https://github.com/CommunityHiQ/Frends.Community.Sharepoint.Download.git`

Rebuild the project

`dotnet build`

Run Tests

`dotnet test`

Create a NuGet package

`dotnet pack --configuration Release`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repo on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

# Change Log

| Version | Changes |
| ------- | ------- |
| 0.0.2   | Converted to support .Net Standard & .Net Framework 4.7.1 |
