FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CalculaPoupanca/CalculaPoupanca.csproj", "CalculaPoupanca/"]
RUN dotnet restore "CalculaPoupanca/CalculaPoupanca.csproj"
COPY . .
WORKDIR "/src/CalculaPoupanca"
RUN dotnet build "CalculaPoupanca.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CalculaPoupanca.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CalculaPoupanca.dll"]
