#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# FROM ecr.aws/lambda/dotnet:5.0 AS base
# WORKDIR /app
# EXPOSE 80

# FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
# WORKDIR /src
# COPY ["BattleNotifications.Api/BattleNotifications.Api.csproj", "BattleNotifications.Api/"]
# RUN dotnet restore "BattleNotifications.Api/BattleNotifications.Api.csproj"
# COPY . .
# WORKDIR "/src/BattleNotifications.Api"
# RUN dotnet build "BattleNotifications.Api.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "BattleNotifications.Api.csproj" -c Release --runtime linux-x64 --self-contained false -p:PublishReadyToRun=true -o /app/publish

# FROM base AS final
# WORKDIR /var/task
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "BattleNotifications.Api.dll"]
# CMD [ "LambdaEntryPoint.Init" ]

FROM public.ecr.aws/lambda/dotnet:5.0 AS base

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /src
COPY ["BattleNotifications.Api/BattleNotifications.Api.csproj", "BattleNotifications.Api/"]
RUN dotnet restore "BattleNotifications.Api/BattleNotifications.Api.csproj"

WORKDIR "/src/BattleNotifications.Api"
COPY . .
RUN dotnet build "BattleNotifications.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BattleNotifications.Api.csproj" -c Release --runtime linux-x64 --self-contained false -p:PublishReadyToRun=true -o /app/publish

FROM base AS final
WORKDIR /var/task
COPY --from=publish /app/publish .
