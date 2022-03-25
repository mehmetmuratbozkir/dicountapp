# ShopsRUs Descount Calculater App

> A ASP.NET Core Api project

## Start And Setup
``` bash

# Run Project
dotnet run --project DiscountApp

# Build Project
dotnet build

# build for production and publish
dotnet publish

# run tests
dotnet test
```

For a detailed explanation on how to work command line commands, check out the [Documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet)

----------------------------------------------------------------------------------------------------------------------

### Swagger And End Points
``` bash
Swagger is an Interface Description Language for describing RESTful APIs expressed using JSON.

# Swagger Url
<Project Url>/swagger
```

#### How to use Calculater
``` bash

# CustomerTypes Endpoint
Request to CustomerTypes endpoints. Select a customer type and get "id". Thats CutomerTypeId "id".
Endpoint: <Project Url>/api/CutomerTypes/GetAll


## CalculateDiscount Endpoint
Request to CalculateDiscount endpoint and send "customerTypeId", "Price" in body.
Endpoint: /api/CalculateDiscount/Calculate
Body Example
{
  "price": Decimal,
  "customerTypeId": Int
}

For a easy practice [Swagger](<Project Url>/swagger)





