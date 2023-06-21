FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AtribuicoesDeVariaveis/AtribuicoesDeVariaveis.csproj", "AtribuicoesDeVariaveis/"]
RUN dotnet restore "AtribuicoesDeVariaveis/AtribuicoesDeVariaveis.csproj"
COPY . .
WORKDIR "/src/AtribuicoesDeVariaveis"
RUN dotnet build "AtribuicoesDeVariaveis.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AtribuicoesDeVariaveis.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AtribuicoesDeVariaveis.dll"]
