FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ForEncadeado/ForEncadeado.csproj", "ForEncadeado/"]
RUN dotnet restore "ForEncadeado/ForEncadeado.csproj"
COPY . .
WORKDIR "/src/ForEncadeado"
RUN dotnet build "ForEncadeado.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ForEncadeado.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ForEncadeado.dll"]
