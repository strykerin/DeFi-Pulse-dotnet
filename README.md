# DeFi-Pulse-dotnet
[![NuGet version (DeFiPulse)](https://img.shields.io/nuget/v/DeFiPulse.svg?style=flat-square)](https://www.nuget.org/packages/DeFiPulse/)

A dotnet standard wrapper for the DeFi Pulse API.

## Register service in your DI container
In order to use this package, simply add in the `ConfigureServices` method in your `Startup.cs` class:

```csharp
services.AddDeFiPulse("Your DeFi Pulse Api Key Here");
```

## Usage
To have access to the DeFiPulse service, simply get it by constructor injection:

```csharp
 private readonly IDeFiPulse _deFiPulse;

 public WeatherForecastController(IDeFiPulse deFiPulse)
 {
    _deFiPulse = deFiPulse;
 }
```
