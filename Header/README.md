## Query String Versioning
This project shows how to add API versioning to an ASP.NET Core project using header versioning.


## Setting Up The Project 
To run the service the first time, follow these steps.

1. Ensure that [.NET Core SDK](https://www.microsoft.com/net/core#windowscmd)  is installed.

2. Open a command prompt or a powershell command window.

3. Navigate to the app root folder

4. Run the following command to restore all the nuget packages:
  ```shell
  dotnet restore
  ```

## Running the project

1. Open a command prompt or a powershell command window.

2. Navigate to the app root folder

3. Run the following command to restore all the nuget packages:
  ```shell
  dotnet run
  ```

  ## Paths 
```shell
 api/greeting
   ```
 
 if version is not specified in header of the request, project fallbacks to API version 3.0.
 HeaderKey is "api-version", available versions is 1.0, 2.0 and 3.0
 Use a httpclient like postman. 
