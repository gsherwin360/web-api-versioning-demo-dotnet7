# Web Api Versioning Demo (.NET 7)
In this demo app, I have implemented API versioning in a .NET 7 Web API. It showcases a controller that provides weather forecast data with version information. The controller is not versioned in this example, but the repository serves as a starting point for implementing API versioning in your ASP.NET Core application.

## Configuration
You can configure the application using the `appsettings.json` file, which includes a ReleaseNumber setting.
```json 
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ReleaseNumber": "1.0.0"
}
```
