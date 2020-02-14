#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["UserServices.csproj", ""]
RUN dotnet restore "./UserServices.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "UserServices.csproj" -c Debug -o /app/build

RUN dotnet dev-certs https
#RUN dotnet dev-certs https --trust
#RUN ls ${HOME}/.aspnet

FROM build AS publish
RUN dotnet publish "UserServices.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY %USERPROFILE%/.aspnet/https .

ENV PORT 5001
ENV ASPNETCORE_URLS https://*:${PORT}

ENTRYPOINT ["dotnet", "UserServices.dll"]