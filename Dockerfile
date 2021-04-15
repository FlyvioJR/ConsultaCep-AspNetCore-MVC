#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

# copy csproj and restore as distinct layers
COPY *.sln .
COPY WebApplication1/*.csproj ./WebApplication1/
RUN dotnet restore

# copy everything else and build app
COPY WebApplication1/. ./WebApplication1/
RUN dotnet publish "WebApplication1/ConsultaCep.csproj" -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:5.0 as final
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "ConsultaCep.dll"]

#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "ConsultaCep.dll"]

#RUN useradd -m favo
#USER favo

#	CMD ASPNETCORE_URLS="http://*:$PORT" dotnet ConsultaCep.dll