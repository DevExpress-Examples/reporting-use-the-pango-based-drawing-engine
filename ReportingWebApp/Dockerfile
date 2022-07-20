#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1-bullseye-slim AS base
RUN apt-get update && \
    apt-get install -y libc6 -f -o APT::Immediate-Configure=0 && \
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
EXPOSE 443
