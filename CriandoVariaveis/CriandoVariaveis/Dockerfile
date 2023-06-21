FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CriandoVariaveis/CriandoVariaveis.csproj", "CriandoVariaveis/"]
RUN dotnet restore "CriandoVariaveis/CriandoVariaveis.csproj"
COPY . .
WORKDIR "/src/CriandoVariaveis"
RUN dotnet build "CriandoVariaveis.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CriandoVariaveis.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CriandoVariaveis.dll"]
