# Use the official .NET 8 SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["SoapApi.csproj", "./"]
RUN dotnet restore "./SoapApi.csproj"
COPY . .
RUN dotnet publish "SoapApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Use the official .NET 8 ASP.NET runtime image for runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "SoapApi.dll"]
