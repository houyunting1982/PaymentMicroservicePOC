FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY *.sln .
COPY PaymentService.API/*.csproj PaymentService.API/
COPY PaymentService.Tests/*.csproj PaymentService.Tests/
RUN dotnet restore
COPY . .

FROM build AS testing
WORKDIR /src/PaymentService.API
RUN dotnet build
WORKDIR /src/PaymentService.Tests
RUN dotnet test

FROM build AS publish
WORKDIR /src/PaymentService.API
RUN dotnet publish -c Release -o /src/publish

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .
#NTRYPOINT ["dotnet", "PaymentService.API.dll"]
# heroku uses the following
CMD ASPNETCORE_URLS=http://*:$PORT dotnet PaymentService.API.dll