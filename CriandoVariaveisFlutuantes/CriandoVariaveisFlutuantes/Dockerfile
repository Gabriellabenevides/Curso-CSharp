FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CriandoVariaveisFlutuantes/CriandoVariaveisFlutuantes.csproj", "CriandoVariaveisFlutuantes/"]
RUN dotnet restore "CriandoVariaveisFlutuantes/CriandoVariaveisFlutuantes.csproj"
COPY . .
WORKDIR "/src/CriandoVariaveisFlutuantes"
RUN dotnet build "CriandoVariaveisFlutuantes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CriandoVariaveisFlutuantes.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CriandoVariaveisFlutuantes.dll"]
