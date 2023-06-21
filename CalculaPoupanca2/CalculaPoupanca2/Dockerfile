FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CalculaPoupanca2/CalculaPoupanca2.csproj", "CalculaPoupanca2/"]
RUN dotnet restore "CalculaPoupanca2/CalculaPoupanca2.csproj"
COPY . .
WORKDIR "/src/CalculaPoupanca2"
RUN dotnet build "CalculaPoupanca2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CalculaPoupanca2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CalculaPoupanca2.dll"]
