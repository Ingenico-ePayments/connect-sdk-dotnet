# Ingenico Connect .NET SDK

## Introduction

The .NET SDK helps you to communicate with the [Ingenico Connect](http://www.ingenico.com/epayments) Server API. It's primary features are:

* convenient C# wrapper around the API calls and responses
    * marshalls C# request objects to HTTP requests
    * unmarshalls HTTP responses to C# response objects or C# exceptions
* handling of all the details concerning authentication
* handling of required meta data

Its use is demonstrated by an example for each possible call. The examples execute a call using the provided API keys.

See the [Ingenico Connect Developer Hub](https://developer.globalcollect.com/documentation/sdk/server/dotnet/) for more information on how to use the SDK.

## Structure of this repository

This repository consists out of four main components:

1. The source code of the SDK itself: `/connect-sdk-dotnet`
2. The source code of the SDK unit tests: `/connect-sdk-dotnet-tests`
3. The source code of the example integration tests: `/connect-sdk-dotnet-it`
4. The source code of the example calls: `/connect-sdk-dotnet-examples`

## Requirements

.NET Framework 4.5 is required. In addition, the following packages are required:

* [Microsoft BCL Portability Pack ](https://www.nuget.org/packages/Microsoft.Bcl/) 1.1.10 or higher
* [Microsoft BCL Build Components](https://www.nuget.org/packages/Microsoft.Bcl.Build/) 1.0.21 or higher
* [Microsoft HTTP Client Libraries](https://www.nuget.org/packages/Microsoft.Net.Http/) 2.2.29 or higher
* [System.Collections.Immutable](https://www.nuget.org/packages/System.Collections.Immutable/) 1.2.0 or higher
* [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) 9.0.1 or higher
* [NLog](https://www.nuget.org/packages/NLog/) 4.3.7 or higher

## Installation
 
### Release

To install the latest .NET SDK release, run the following command in the Package Manager Console (`Tools -> NuGet Package Manager -> Package Manager Console`) in Visual Studio:

	PM> Install-Package connect-sdk-dotnet

### Source

To install the latest .NET SDK source in a solution, clone the repository, and add the file `connect-sdk-dotnet.csproj` to the current solution. On the project depending on the Ingenico Connect SDK, add a reference to the `connect-sdk-dotnet` project.

## Building the repository

This repository uses [Visual Studio](https://www.visualstudio.com/) to build. Open `connect-sdk-dotnet.sln` in Visual Studio, and click build.
