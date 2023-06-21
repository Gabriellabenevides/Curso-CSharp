FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Condicionais/Condicionais.csproj", "Condicionais/"]
RUN dotnet restore "Condicionais/Condicionais.csproj"
COPY . .
WORKDIR "/src/Condicionais"
RUN dotnet build "Condicionais.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Condicionais.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Condicionais.dll"]
