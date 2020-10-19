## How to Use the DevExpress CrossPlatform Drawing Engine in an ASP.NET Core Application

This example demonstrates how to enable the [DevExpress CrossPlatform Drawing Engine](https://www.nuget.org/packages/DevExpress.CrossPlatform.Printing.DrawingEngine) in an and ASP.NET Core application to preview, [print](xref:15797), or [export](xref:2618) [DevExpress XtraReports](http://docs.devexpress.com/XtraReports/2162).

See the [Use the DevExpress Cross-Platform Drawing Engine](xref:http://docs.devexpress.com/XtraReports/401730) topic for more information.

## Files to look at

- [Startup.cs](CS/ReportingWebApp/Startup.cs)

    The **ConfigureServices** method calls the **DevExpress.Printing.CrossPlatform.CustomEngineHelper.RegisterCustomDrawingEngine** method to register the **DevExpress CrossPlatform Drawing Engine** if the platform is not Windows. The engine does not need to be registered on Windows because reports are rendered without the issues described above.