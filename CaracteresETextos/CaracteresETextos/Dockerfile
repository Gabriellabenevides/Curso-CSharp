FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CaracteresETextos/CaracteresETextos.csproj", "CaracteresETextos/"]
RUN dotnet restore "CaracteresETextos/CaracteresETextos.csproj"
COPY . .
WORKDIR "/src/CaracteresETextos"
RUN dotnet build "CaracteresETextos.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CaracteresETextos.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CaracteresETextos.dll"]
