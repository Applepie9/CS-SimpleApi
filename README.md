How to recreate the project:

1. Create a New .NET Web API Project
```
mkdir SimpleApiProject
cd SimpleApiProject
dotnet new sln
dotnet new webapi -o SimpleApi
dotnet new xunit -o SimpleApi.Tests
 
cd SimpleApi.Tests
dotnet add reference ../SimpleApi/SimpleApi.csproj
```

2. Implement the Endpoint
Create the SimpleController in the SimpleApi project


3. Configure ```Program.cs``` for Minimal API Hosting Model, use the Startup class
```
builder.Services.AddControllers();
app.MapControllers(); // Top-level route registration
```

4. Write and Configure the Tests (+ Ensure reference is added in test csproj)

Create and implement the ```SimpleControllerTests``` class


5. Clean, Build, and Run the Tests
```
dotnet clean
dotnet build
dotnet test
```