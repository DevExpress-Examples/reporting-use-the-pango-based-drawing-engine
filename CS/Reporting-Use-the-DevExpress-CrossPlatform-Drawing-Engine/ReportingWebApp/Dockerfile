#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
RUN apt-get update && \
    apt-get install -y software-properties-common && \
    add-apt-repository 'deb http://deb.debian.org/debian sid main' && \
    apt-get update && \
    apt-get install -y \
        libgdiplus \
        libicu-dev \
        libharfbuzz0b \
        libfontconfig1 \
        libfreetype6 \
        libpango-1.0-0 \
        libpangocairo-1.0

WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ReportingWebApp/ReportingWebApp.csproj", "ReportingWebApp/"]
COPY ["ReportingWebApp/NuGet.config", "ReportingWebApp/"]
RUN dotnet restore "ReportingWebApp/ReportingWebApp.csproj"
COPY . .
WORKDIR "/src/ReportingWebApp"
RUN dotnet build "ReportingWebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReportingWebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReportingWebApp.dll"]