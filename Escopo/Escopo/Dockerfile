FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Escopo/Escopo.csproj", "Escopo/"]
RUN dotnet restore "Escopo/Escopo.csproj"
COPY . .
WORKDIR "/src/Escopo"
RUN dotnet build "Escopo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Escopo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Escopo.dll"]
