## Url Path Segement Versioning
This project shows how to add API versioning to an ASP.NET Core project using Url Path Segement.


## Setting Up The App 
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

### GreetingController v.1 

```shell
 api/1.0/greeting
   ```
 
 
### GreetingController v.2
```shell
 api/2.0/greeting
   ```
 Use a browser or a httpclient like postman. 



