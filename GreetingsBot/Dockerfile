FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GreetingsBot/GreetingsBot.csproj", "GreetingsBot/"]
RUN dotnet restore "GreetingsBot/GreetingsBot.csproj"
COPY . .
WORKDIR "/src/GreetingsBot"
RUN dotnet build "GreetingsBot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GreetingsBot.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GreetingsBot.dll"]
