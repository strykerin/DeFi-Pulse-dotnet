# DeFi-Pulse-dotnet

A dotnet standard wrapper for the DeFi Pulse API.

## Register service in your DI container
In order to use this package, simply add in the `ConfigureServices` method in your `Startup.cs` class:

`services.AddDeFiPulse("Your DeFi Pulse Api Key Here");`

## Usage
To have access to the DeFiPulse service, simply get it by constructor injection:

`
 private readonly IDeFiPulse _deFiPulse;

 public WeatherForecastController(IDeFiPulse deFiPulse)
 {
    _deFiPulse = deFiPulse;
 }
`
