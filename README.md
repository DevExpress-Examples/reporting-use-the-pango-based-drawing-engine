<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/259715972/2021.2)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T884870)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
## How to Use the DevExpress CrossPlatform Drawing Engine in an ASP.NET Core Application

This example demonstrates how to enable the [DevExpress CrossPlatform Drawing Engine](https://www.nuget.org/packages/DevExpress.CrossPlatform.Printing.DrawingEngine) in an ASP.NET Core application to preview, [print](http://docs.devexpress.com/XtraReports/15797), or [export](http://docs.devexpress.com/XtraReports/2618) DevExpress XtraReports.

Refer to the [Use the DevExpress Cross-Platform Drawing Engine](http://docs.devexpress.com/XtraReports/401730) help topic for more information.

## Files to look at

- [Startup.cs](ReportingWebApp/Startup.cs)

    At startup call the **DevExpress.Printing.CrossPlatform.CustomEngineHelper.RegisterCustomDrawingEngine** method to register the **DevExpress CrossPlatform Drawing Engine** in the application.
