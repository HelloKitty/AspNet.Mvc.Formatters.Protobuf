# AspNet.Mvc.Formatters.Protobuf

ASP.Net 5/Core and MVC 6 extensions and formatters for the Protobuf message format.

## Setup

To use this project you'll first need a couple of things:
  - Visual Studio 2015
  - Add Nuget Feed https://www.myget.org/F/hellokitty/api/v2 in VS (Options -> NuGet -> Package Sources)

## Builds

Available on a Nuget Feed: https://www.myget.org/F/hellokitty/api/v2 [![hellokitty MyGet Build Status](https://www.myget.org/BuildSource/Badge/hellokitty?identifier=a8048ae0-adcd-4997-8862-c3f5fc6adf34)](https://www.myget.org/feed/Packages/hellokitty)

## Tests

#### Linux/Mono - Unit Tests

(Warning: This is currently untested; new territory of .NET Core and DNX)

||Debug x86|Debug x64|Release x86|Release x64|
|:--:|:--:|:--:|:--:|:--:|:--:|
|**master**| N/A | N/A | N/A | [![Build Status](https://travis-ci.org/HelloKitty/AspNet.Mvc.Formatters.Protobuf.svg?branch=master)](https://travis-ci.org/HelloKitty/AspNet.Mvc.Formatters.Protobuf) |
|**dev**| N/A | N/A | N/A | [![Build Status](https://travis-ci.org/HelloKitty/AspNet.Mvc.Formatters.Protobuf.svg?branch=dev)](https://travis-ci.org/HelloKitty/AspNet.Mvc.Formatters.Protobuf)|

#### Windows - Unit Tests

(Warning: This is currently untested; new territory of .NET Core and DNX)

(Done locally)

##Licensing

This project is licensed under the MIT license.

## How to Use

```CSharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvcCore()
      .AddProtobufNetFormatters();
}
```

or

```CSharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddCore()
      .AddProtobufNetFormatters();
}
```

or you can register the formatters and header string manually.


