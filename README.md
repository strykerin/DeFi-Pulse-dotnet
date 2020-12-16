# DeFi Pulse dotnet
[![NuGet version (DeFiPulse)](https://img.shields.io/nuget/v/DeFiPulse.svg)](https://www.nuget.org/packages/DeFiPulse/) ![Nuget downloads](https://img.shields.io/nuget/dt/DeFiPulse.svg)


A dotnet standard wrapper for the DeFi Pulse API.

## Installation
Available on [Nuget](https://www.nuget.org/packages/DeFiPulse/).

``` PowerShell
Install-Package DeFiPulse -Version 1.0.1
```

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

## Example - Get Ethereum Gas Price
The following example shows how to get the Ethereum Gas Price:
```csharp
GasPrice gasPrice = await _deFiPulse.GetGasPriceAsync();
```

We get the following JSON response:
```json
{
  "fast": 780,
  "fastest": 780,
  "safeLow": 350,
  "average": 400,
  "block_time": 14.03125,
  "blockNum": 11461145,
  "speed": 0.9989337462556375,
  "safeLowWait": 13.7,
  "avgWait": 1.5,
  "fastWait": 0.5,
  "fastestWait": 0.5
}
``` 
