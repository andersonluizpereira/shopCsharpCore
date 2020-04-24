#Instalar dependências
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package Microsoft.AspNetCore.Authentication
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer  
dotnet add package Microsoft.EntityFrameworkCore.InMemory 
dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update  
dotnet watch run 

#Swagger
#Documentation
https://localhost:5001/swagger

https://localhost:5001/swagger/v1/swagger.json

#Initialize system, of seed system
https://localhost:5001/v1


#History
9448  dotnet sln add PaymentContext.Domain/PaymentContext.Domain.csproj
 9449  dotnet sln add PaymentContext.Shared/PaymentContext.Shared.csproj
 9450  dotnet sln add PaymentContext.Tests/PaymentContext.Tests.csproj
 9451  dotnet restore
 9452  dotnet build
 9454  dotnet add reference ../PaymentContext.Shared/PaymentContext.Shared.csproj
 9458  dotnet add reference ../PaymentContext.Shared/PaymentContext.Shared.csproj
 9459  dotnet add reference ../PaymentContext.Domain/PaymentContext.Domain.csproj
 9460  dotnet build
 9462  dotnet build
10218  dotnet version
10219  dotnet --version
10224  dotnet new webapi -o Shop
10230  dotnet build
10231  dotnet run
10232  dotnet dev-certs https --trust
10233  dotnet run
10253* dotnet add package Microsoft.EntityFrameworkCore.SqlServer
10254* dotnet add package Microsoft.EntityFrameworkCore.InMemory
10261* dotnet watch run
10262  history | grep dotnet
10263  dotnet tool install --global dotnet-ef