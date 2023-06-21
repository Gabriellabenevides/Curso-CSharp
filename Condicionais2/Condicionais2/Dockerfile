FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Condicionais2/Condicionais2.csproj", "Condicionais2/"]
RUN dotnet restore "Condicionais2/Condicionais2.csproj"
COPY . .
WORKDIR "/src/Condicionais2"
RUN dotnet build "Condicionais2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Condicionais2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Condicionais2.dll"]
