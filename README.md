# Getting started

Testing Weather API 2

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (WeatherAPI2.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Weather%20API%202-CSharp&workspaceName=WeatherAPI2&projectName=WeatherAPI2.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the WeatherAPI2 library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Weather%20API%202-CSharp&workspaceName=WeatherAPI2&projectName=WeatherAPI2.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Weather%20API%202-CSharp&workspaceName=WeatherAPI2&projectName=WeatherAPI2.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Weather%20API%202-CSharp&workspaceName=WeatherAPI2&projectName=WeatherAPI2.Standard)

### 3. Add reference of the library project

In order to use the WeatherAPI2 library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Weather%20API%202-CSharp&workspaceName=WeatherAPI2&projectName=WeatherAPI2.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` WeatherAPI2.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```WeatherAPI2.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Weather%20API%202-CSharp&workspaceName=WeatherAPI2&projectName=WeatherAPI2.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Weather%20API%202-CSharp&workspaceName=WeatherAPI2&projectName=WeatherAPI2.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

WeatherAPI2Client client = new WeatherAPI2Client();
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SimpleGetWeatherController](#simple_get_weather_controller)
* [DynamicGetWeatherThatTakesLocationAndAPIKeyController](#dynamic_get_weather_that_takes_location_and_api_key_controller)

## <a name="simple_get_weather_controller"></a>![Class: ](https://apidocs.io/img/class.png "WeatherAPI2.Standard.Controllers.SimpleGetWeatherController") SimpleGetWeatherController

### Get singleton instance

The singleton instance of the ``` SimpleGetWeatherController ``` class can be accessed from the API Client.

```csharp
SimpleGetWeatherController simpleGetWeather = client.SimpleGetWeather;
```

### <a name="update_get_weather_endpoint"></a>![Method: ](https://apidocs.io/img/method.png "WeatherAPI2.Standard.Controllers.SimpleGetWeatherController.UpdateGetWeatherEndpoint") UpdateGetWeatherEndpoint

> TODO: Add a method description


```csharp
Task UpdateGetWeatherEndpoint()
```

#### Example Usage

```csharp

await simpleGetWeather.UpdateGetWeatherEndpoint();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="dynamic_get_weather_that_takes_location_and_api_key_controller"></a>![Class: ](https://apidocs.io/img/class.png "WeatherAPI2.Standard.Controllers.DynamicGetWeatherThatTakesLocationAndAPIKeyController") DynamicGetWeatherThatTakesLocationAndAPIKeyController

### Get singleton instance

The singleton instance of the ``` DynamicGetWeatherThatTakesLocationAndAPIKeyController ``` class can be accessed from the API Client.

```csharp
DynamicGetWeatherThatTakesLocationAndAPIKeyController dynamicGetWeatherThatTakesLocationAndAPIKey = client.DynamicGetWeatherThatTakesLocationAndAPIKey;
```

### <a name="get_weather_endpoint_dynamic"></a>![Method: ](https://apidocs.io/img/method.png "WeatherAPI2.Standard.Controllers.DynamicGetWeatherThatTakesLocationAndAPIKeyController.GetWeatherEndpointDynamic") GetWeatherEndpointDynamic

> TODO: Add a method description


```csharp
Task<Models.Weather> GetWeatherEndpointDynamic(string q, string appid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  ``` DefaultValue ```  | City Name |
| appid |  ``` Required ```  ``` DefaultValue ```  | API Key |


#### Example Usage

```csharp
string q = "Islamabad";
string appid = "3bfede6320fa429d3dac852b611871e6";

Models.Weather result = await dynamicGetWeatherThatTakesLocationAndAPIKey.GetWeatherEndpointDynamic(q, appid);

```


[Back to List of Controllers](#list_of_controllers)



