# Ingenico Connect .NET SDK

## Introduction

The .NET SDK helps you to communicate with the [Ingenico Connect](https://epayments.developer-ingenico.com/) Server API. It's primary features are:

* convenient C# wrapper around the API calls and responses
    * marshalls C# request objects to HTTP requests
    * unmarshalls HTTP responses to C# response objects or C# exceptions
* handling of all the details concerning authentication
* handling of required meta data

Its use is demonstrated by an example for each possible call. The examples execute a call using the provided API keys.

See the [Ingenico Connect Developer Hub](https://epayments.developer-ingenico.com/documentation/sdk/server/dotnet/) for more information on how to use the SDK.

## Structure of this repository

This repository consists out of four main components:

1. The source code of the SDK itself: `/connect-sdk-dotnet`
2. The source code of the SDK unit tests: `/connect-sdk-dotnet-tests`
3. The source code of the example integration tests: `/connect-sdk-dotnet-it`
4. The source code of the example calls: `/connect-sdk-dotnet-examples`

## Requirements

The .NET SDK supports .NET Framework 4.5 and [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) 2.0 and 2.1.

### .NET Framework 4.5

When using .NET Framework 4.5, the following packages are rquired:

* [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) 10.0.3 or higher
* [NLog](https://www.nuget.org/packages/NLog/) 4.3.7 or higher
* [System.Collections.Immutable](https://www.nuget.org/packages/System.Collections.Immutable/) 1.2.0 or higher

In addition, the following references are required, which are part of the .NET Framework:
* System.Configuration
* System.Net.Http

### .NET Standard 2.0 and 2.1

When using .NET Standard 2.0 or 2.1, the following packages are rquired:

* [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) 12.0.3 or higher
* [NLog](https://www.nuget.org/packages/NLog/) 4.6.8 or higher
* [System.Collections.Immutable](https://www.nuget.org/packages/System.Collections.Immutable/) 1.6.0 or higher
* [System.Configuration.ConfigurationManager](https://www.nuget.org/packages/System.Configuration.ConfigurationManager/) 4.6.0 or higher

## Installation
 
### Release

#### Package Manager

To install the latest .NET SDK release, run the following command in the Package Manager Console (`Tools -> NuGet Package Manager -> Package Manager Console`) in Visual Studio:

	PM> Install-Package connect-sdk-dotnet

#### .NET CLI

To install the latest .NET SDK release, run the following command:

	dotnet add package connect-sdk-dotnet

### Release (Strong-Named)

To install the latest .NET SDK release as a [Strong-Named assembly](https://docs.microsoft.com/en-us/dotnet/framework/app-domains/strong-named-assemblies), follow the instructions above but use `connect-sdk-dotnet.StrongName` instead of `connect-sdk-dotnet`.

## Building the repository

This repository uses [Visual Studio](https://www.visualstudio.com/) 2019 to build. Open `connect-sdk-dotnet.sln` in Visual Studio, and click build.
