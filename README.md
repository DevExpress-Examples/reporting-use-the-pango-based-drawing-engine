<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/259715972/2022.2)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T884870)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
## How to Use the DevExpress CrossPlatform Drawing Engine in an ASP.NET Core Application

This example demonstrates how to enable the [DevExpress CrossPlatform Drawing Engine](https://www.nuget.org/packages/DevExpress.CrossPlatform.Printing.DrawingEngine) in an ASP.NET Core application to preview, [print](http://docs.devexpress.com/XtraReports/15797), or [export](http://docs.devexpress.com/XtraReports/2618) DevExpress XtraReports.


The commands required to configure the host operating system environment for the DevExpress CrossPlatform Drawing Engine are included in the docker file.

## Files to look at

- [Startup.cs](ReportingWebApp/Startup.cs)

    At startup call the **DevExpress.Printing.CrossPlatform.CustomEngineHelper.RegisterCustomDrawingEngine** method to register the **DevExpress CrossPlatform Drawing Engine** in the application.
- [ReportingWebApp.csproj](ReportingWebApp/ReportingWebApp.csproj)

    The `DockerfileFile` property in the project file specifies the name of the docker file to use in the project. Edit the project file manually to change the default **Debian** docker file to docker files for **Alpine** or **Ubuntu**. For more information on the build properties in a project file, review the following help topic: [Container Tools build properties](https://docs.microsoft.com/en-us/visualstudio/containers/container-msbuild-properties?view=vs-2022).
- [Dockerfile](ReportingWebApp/Dockerfile)

    The **Debian** docker file.
- [Dockerfile.Alpine](ReportingWebApp/Dockerfile.Alpine)

    The **Alpine** docker file.
- [Dockerfile.Ubuntu](ReportingWebApp/Dockerfile.Ubuntu)

    The **Ubuntu** docker file.
    
- [Dockerfile.AmazonLinux](ReportingWebApp/Dockerfile.AmazonLinux)

    The **Amazon Linux** docker file.
    
## How to build and run this example

### Visual Studio

You can run the app on Windows platform, Windows Subsystem for Linux or Docker. Select a platform from the debug drop-down in the toolbar, and start debugging the app.

### CLI
Run the application from the dotnet CLI on Windows, Linux and MacOS with the `dotnet run` command.
To run the Docker contaier from the command line, build the Docker image. You should pass the DevExpress NuGet source URL as a secret to restore NuGet packages. Review the [BuildKit documentation](https://docs.docker.com/build/buildkit/) for more information.

```console
set DX_NUGET=https://nuget.devexpress.com/some-nuget-token/api
docker build -t reporting-app --secret id=dxnuget,env=DX_NUGET .
docker run -p 8080:80 reporting-app:latest
```

```shell
export DX_NUGET=https://nuget.devexpress.com/some-nuget-token/api
DOCKER_BUILDKIT=1 docker build -t reporting-app --secret id=dxnuget,env=DX_NUGET .
docker run -p 8080:80 reporting-app:latest
```

The application page is available at the following URL: http://localhost:8080/.


### Documentation

- [Use the DevExpress Cross-Platform Drawing Engine](http://docs.devexpress.com/XtraReports/401730)

    
