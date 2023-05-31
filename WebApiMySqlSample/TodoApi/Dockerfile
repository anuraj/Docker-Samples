FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source

COPY TodoApi.csproj TodoApi.csproj
RUN dotnet restore

COPY . .
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "TodoApi.dll"]