<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/259715972/2020.1)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T884870)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
## How to Use the DevExpress CrossPlatform Drawing Engine in an ASP.NET Core Application

This example demonstrates how to enable the [DevExpress CrossPlatform Drawing Engine](https://www.nuget.org/packages/DevExpress.CrossPlatform.Printing.DrawingEngine) in an ASP.NET Core application to preview, [print](http://docs.devexpress.com/XtraReports/15797), or [export](http://docs.devexpress.com/XtraReports/2618) DevExpress XtraReports.

Refer to the [Use the DevExpress Cross-Platform Drawing Engine](http://docs.devexpress.com/XtraReports/401730) help topic for more information.

## Files to look at

- [Startup.cs](CS/ReportingWebApp/Startup.cs)

    At startup call the **DevExpress.Printing.CrossPlatform.CustomEngineHelper.RegisterCustomDrawingEngine** method to register the **DevExpress CrossPlatform Drawing Engine** in the application.
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-use-the-pango-based-drawing-engine&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-use-the-pango-based-drawing-engine&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
