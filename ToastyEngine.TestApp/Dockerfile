FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ToastyEngine.TestApp/ToastyEngine.TestApp.csproj", "ToastyEngine.TestApp/"]
RUN dotnet restore "ToastyEngine.TestApp/ToastyEngine.TestApp.csproj"
COPY . .
WORKDIR "/src/ToastyEngine.TestApp"
RUN dotnet build "ToastyEngine.TestApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToastyEngine.TestApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToastyEngine.TestApp.dll"]
