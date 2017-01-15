## Query String Versioning
This project shows how to add API versioning to an ASP.NET Core project using query string versioning.


## Setting Up The project 
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

### GreetingController V1.0
```shell
 api/greeting?api-version=1.0
   ```

### GreetingController V2.0 
```shell
 api/greeting?api-version=2.0
   ```
 
 if version is not specified in querystring, project fallbacks to API version 2.0.
 Use browser or a httpclient like postman. 
