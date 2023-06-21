FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AprendendoCSharp/AprendendoCSharp.csproj", "AprendendoCSharp/"]
RUN dotnet restore "AprendendoCSharp/AprendendoCSharp.csproj"
COPY . .
WORKDIR "/src/AprendendoCSharp"
RUN dotnet build "AprendendoCSharp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AprendendoCSharp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AprendendoCSharp.dll"]
